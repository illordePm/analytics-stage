import { Component, signal, computed, effect } from '@angular/core';

import { KPIService } from './kpi-principali.service';
import { KpiContainer } from './kpi-principali.types';

import { MatIconRegistry, MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatSelectChange, MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { SharedFilterShops } from "../shared-filter-shops/shared-filter-shops";
import { SharedFilterMonths } from "../shared-filter-month/shared-filter-month";
import { SharedFilterYear } from "../shared-filter-year/shared-filter-year";
import { Comparison } from '../shared-filter-comparison/shared-filter-comparison.type';
import { SharedFilterComparison } from "../shared-filter-comparison/shared-filter-comparison";
import { DecimalPipe } from '@angular/common';

/*  
 *
 *  TODO: rinominare con nome generico più adatto alla pagina KPI principali
 *
*/

@Component({
  selector: 'app-kpi-principali',
  imports: [MatCardModule, MatIconModule, MatFormFieldModule, MatSelectModule, SharedFilterShops, SharedFilterMonths, SharedFilterYear, SharedFilterComparison, DecimalPipe],
  templateUrl: './kpi-principali.html',
  styleUrl: './kpi-principali.css',
})
export class KpiPrincipali {
  
  // i segnali servono per tenere traccia dei dati nel tempo
  KpiResponse = signal<KpiContainer | null>(null); 

    //VARIABILI DI STATO PER MANTERE IN MEMORIA IL VALORE DEI FILTRI

  negozioAttivo = signal<number | null>(null);
  meseAttivo = signal<number>(new Date().getMonth() + 1);
  annoAttivo = signal<number>(new Date().getFullYear());
  confrontoAttivo = signal<Comparison>(Comparison.previousMonth);

  //computed così cambiano al cambiare di KpiResponse
  totalBought = computed(() =>
  this.KpiResponse()?.totalBought
);
  
  totalSales = computed(() => 
    this.KpiResponse()?.totalSales
);

  totalReceipt = computed(() =>
    this.KpiResponse()?.totalReceipts
);
  averageReceipt = computed(() => 
    this.KpiResponse()?.averageReceipt
);

  // i computed servono per creare dati nuovi che si aggiornano solo quando cambiano i dati del segnale
  // funzione per calcolare percentuale di crescita/calo delle vendite
  calcoloPercentualeTotalSales = computed(() => {
      const data = this.totalSales();
      if (!data || data==null)
         return 'N/D';
      if (data.previousValue == 0) 
        return data.currentValue > 0 ? '100.00' : '0.00';
      
      return this.CalcoloPercentualeBack(data.currentValue ?? 0, data.previousValue ?? 0);
  });

  calcoloPercentualeTotalBought = computed(() => {
      const data = this.totalBought();
      if (!data || data==null) 
        return 'N/D';
      if (data.previousValue == 0) 
        return data.currentValue > 0 ? '100.00' : '0.00';
      
      return this.CalcoloPercentualeBack(data.currentValue ?? 0, data.previousValue ?? 0);
  });

  calcoloPercentualeTotalReceipt = computed(() => {
      const data = this.totalReceipt();
      if (!data || data==null)
         return 'N/D';
      if (data.previousValue == 0) 
        return data.currentValue > 0 ? '100.00' : '0.00';
      
      return this.CalcoloPercentualeBack(data.currentValue ?? 0, data.previousValue ?? 0);
  });

  calcoloPercentualeAverageReceipt = computed(() => {
      const data = this.averageReceipt();
      if (!data || data==null) 
        return 'N/D';
      if (data.previousValue == 0) 
        return data.currentValue > 0 ? '100.00' : '0.00';
      
      return this.CalcoloPercentualeBack(data.currentValue ?? 0, data.previousValue ?? 0);
  });


  CalcoloPercentualeBack(current: number, previous: number): number {
    console.log( { 
        corrente: current, 
        precedente: previous 
    });
    if (previous == 0) 
      return 0;
    var ris = (current - previous) * 100 / previous;
    
    //col "+" davanti converte da str a number
    return +ris.toFixed(2);
  }


  //funzione unica per gestire il colore 
// 1. Cambia la firma per accettare sia string che number
getColore(valore: number | string): string {
    
    // 2. Converto tutto in un numero pulito per il confronto
    // Se è stringa, faccio il parsing; se è numero lo tengo tale
    const numero = typeof valore === 'string' ? parseFloat(valore) : valore;

    // 3. Gestione N/D: 
    // isNaN controlla se parseFloat ha fallito (es. con 'N/D')
    // Controlliamo anche che non sia 0 (se per te 0 è 'N/D')
    if (valore === 'N/D' || isNaN(numero) || numero === 0) {
        return 'testo-nd';
    }

    // 4. Ora che sappiamo che è un numero valido e diverso da 0:
    return numero > 0 ? 'testo-positivo' : 'testo-negativo';
}

  
  periodoPrecedente = computed(() => {
    const mese = this.meseAttivo();
    const anno = this.annoAttivo();
    const confronto = this.confrontoAttivo();
    
    //crea data basata sui filtri messi attualmente
    const dataCorrente = new Date(anno, mese - 1, 1);

    switch (confronto) {
        case Comparison.previousMonth:
            //toglie un mese
            return new Date(dataCorrente.getFullYear(), dataCorrente.getMonth() - 1, 1)
                .toLocaleString('it', { month: 'long', year: 'numeric' });

        case Comparison.sameMonthPreviousYear:
            //toglie un anno
            return new Date(dataCorrente.getFullYear() - 1, dataCorrente.getMonth(), 1)
                .toLocaleString('it', { month: 'long', year: 'numeric' });

        default:
            return "Periodo Precedente";
    }
});



  constructor( private servizio: KPIService) {}

  // per KPI
  getKpi(shopId: number | null | undefined, nMonth: number, nYear: number, comparisons: Comparison) {

      this.servizio.getKPI(shopId, nMonth, nYear, comparisons).subscribe({
        next: (data: KpiContainer) => { 
          this.KpiResponse.set(data); 
          console.log("KPI arrivati", this.KpiResponse()); 
        },
        error: (errore) => {
          console.error(errore);
        }
      }
    );
  }

  
  ngOnInit() 
  {
    // per KPI
    this.aggiornaDati();
  }

  onSelectorChange(shopId: number | null) {
  this.negozioAttivo.set(shopId);
  this.aggiornaDati();
}

onMonthChange(nMonth: number) {
  this.meseAttivo.set(nMonth);
  this.aggiornaDati();
}

onYearChange(nYear: number) {
  this.annoAttivo.set(nYear);
  this.aggiornaDati();
}

onComparisonChange(value: Comparison) {
  this.confrontoAttivo.set(value);
  this.aggiornaDati();
}

//metodo unico e comodo
private aggiornaDati() {
  this.getKpi(
    this.negozioAttivo(), 
    this.meseAttivo(), 
    this.annoAttivo(), 
    this.confrontoAttivo()
  );
}
}

