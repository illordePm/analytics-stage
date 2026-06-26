import { Component, computed, signal, OnInit } from '@angular/core';
import { ChartData, ChartConfiguration } from 'chart.js';
import { BaseChartDirective, provideCharts, withDefaultRegisterables } from 'ng2-charts';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { DashboardResponse } from './grafico-vendite.types';
import { DataGraphService} from './grafico-vendite.service';
import { SharedFilterShops } from "../shared-filter-shops/shared-filter-shops";
import { SharedFilterComparison } from '../shared-filter-comparison/shared-filter-comparison';
import { Comparison } from '../shared-filter-comparison/shared-filter-comparison.type';
import { DecimalPipe } from '@angular/common';
import { SharedFilterMonths } from "../shared-filter-month/shared-filter-month";
import { SharedFilterYear } from "../shared-filter-year/shared-filter-year";
import { getDaysInMonth } from 'date-fns';



@Component({
  selector: 'app-grafico-vendite',
  standalone: true,   //autonomo->nn servono NgModule
  imports: [BaseChartDirective, MatCardModule, MatIconModule, SharedFilterShops, SharedFilterComparison, SharedFilterMonths, SharedFilterYear, DecimalPipe],
  templateUrl: './grafico-vendite.html',
  styleUrl: './grafico-vendite.css',
  providers: [provideCharts(withDefaultRegisterables())]
})
export class GraficoVendite implements OnInit{
      //potrà essere DataGraphResponse o null, di default=null

      //signal=wrapper per variabili
      //controlla dove viene piazzata e quando il suo valore vambia
    risposta = signal<DashboardResponse | null>(null);

    //VARIABILI DI STATO PER MANTERE IN MEMORIA IL VALORE DEI FILTRI
  negozioAttivo = signal<number | null>(null);
  meseAttivo = signal<number>(new Date().getMonth() + 1);
  annoAttivo = signal<number>(new Date().getFullYear());
  confrontoAttivo = signal<Comparison>(Comparison.previousMonth);
    
    periodoPrecedente = computed(()=>{
        const dati=this.risposta()?.salesGraph; //prende le date dal grafico             
        if (!dati || dati.dates[0]==null)
          return "Periodo Precedente"  //generico

        const dataCorrente = new Date(dati.dates[0]);
        switch(this.confrontoAttivo())
        {
            case Comparison.previousMonth:

              const dataMesePrecedente = new Date(dataCorrente.getFullYear(), dataCorrente.getMonth() - 1, 1);
              const meseOutput = dataMesePrecedente.toLocaleString('it', { month: 'long' , year:'numeric'});
              return meseOutput;

            case Comparison.sameMonthPreviousYear:

              const dataAnnoPrecedente = new Date(dataCorrente.getFullYear()-1, dataCorrente.getMonth(), 1);
              const AnnoOutput = dataAnnoPrecedente.toLocaleString('it', { month:'long' ,year: 'numeric' });
              return AnnoOutput;

            default:
              return "Periodo Precedente"  //generico
        }

    });

    scontriniTotalePercentuale = computed(() => {
  const dati = this.risposta()?.totalReceipts;
  if (!dati || dati==null) 
    return 'N/D';

  if (dati.previous == 0) {
    return dati.current > 0 ? '100.00' : '0.00';
  }

  const percentuale = ((dati.current - dati.previous) * 100) / dati.previous;
  return percentuale.toFixed(2);
});

scontriniMedioPercentuale = computed(() => {
  const dati = this.risposta()?.averageReceipts;
  if (!dati || dati==null) 
    return 'N/D';

  if (dati.previous == 0) {
    return dati.current > 0 ? '100.00' : '0.00';
  }
  const percentuale = ((dati.current - dati.previous) * 100) / dati.previous;
  return percentuale.toFixed(2);
});

colorePercentualeTotaleScontrini = computed(() => {
  const dati = this.risposta()?.totalReceipts;
  if (!dati || dati==null) 
    return "testo-nd";
  if (dati.previous == 0 && dati.current > 0) 
    return "testo-positivo";

  if (dati.current - dati.previous > 0) 
    return "testo-positivo";
  
  return "testo-negativo";
});

colorePercentualeMediaScontrini = computed(() => {
  const dati = this.risposta()?.averageReceipts;
  if (!dati || dati==null) 
    return "testo-nd";
  if (dati.previous == 0 && dati.current > 0) 
    return "testo-positivo";

  if (dati.current - dati.previous > 0) 
    return "testo-positivo";
  
  return "testo-negativo";
});

    scontrinoTotaleValore = computed(() => {
  const valore = this.risposta()?.totalReceipts?.current;
  if (valore == null) {
    return 'N/D';
  } 
  return valore;
});

    scontrinoMedioValore = computed(() => {
  const valore = this.risposta()?.averageReceipts?.current;
  //se non c'è il dato dà n/d
  if (valore == null) {
    return 'N/D';
  } 
  return valore.toFixed(2).replace('.', ',');
});

  mediaGiornalieraScontrinoTotaleValore  = computed(()=>{
    const dati=this.risposta()?.salesGraph;
    const totale = this.scontrinoTotaleValore();
    if(dati != null && typeof totale==='number'){
      const numeroGiorni = getDaysInMonth(new Date(dati.dates[0]));
      return (totale/numeroGiorni);
    }
    return 0;
    
  });



    //richiamato nel html con baseChart [data]="provaChartData"
    //<line> ->tipizzazione così da far rispettare le x proprietà dopoù
    //definisco le proprietà da andare a popolare dopo
  public provaChartData: ChartData<'line'> = {
    labels: [], // vuoti all'inizio, dati messi in OnInit->legende messe su asse X
    datasets: []  // avrà le "linee" da disegnare sul grafico
  };
  public scontriniTotaliIstogramma:ChartData<'bar'>={
    labels:[],
    datasets:[]
  };

  public scontriniMediaIstogramma:ChartData<'bar'>={
    labels:[],
    datasets:[]
  };

    //richiamato nel html con baseChart [options]="provaChartOptions"
   public provaChartOptions: ChartConfiguration<'line'>['options'] = {
    responsive: true,
    maintainAspectRatio: false,
    scales: {
      x: {},  //da 0 al valore max, come un grafico normale
      y: {}
    },
    plugins: {  //cose in più tipo legende
      tooltip: {  //quando passo sopra un punto
        callbacks: {    //funzioni automatiche quando c'è un evento
          // titolo dell'hover del mouse modificato
          title: (tooltipItems) => {
            const item = tooltipItems[0]; //punto dove c'è il mouse
            const dataset = item.dataset as any;  //estraggo oggetto (tipo la linea) senza fare controlli troppo rigidi (as any)
            
            // Recuperiamo l'array dei range salvato appositamente nel dataset
            // item.dataIndex da il numero del palline su cui punta il mouse
            if (dataset && dataset.giorniDelRange && dataset.giorniDelRange[item.dataIndex]) {
              //salva queste date
              //gli va bene sia date che str
              const rangeDate = dataset.giorniDelRange[item.dataIndex] as Date[] | string[];
              
              if (rangeDate.length > 0) {
                //prende prima e ultima e le formatta adeguatamente
                const primaData = new Date(rangeDate[0]).toLocaleDateString('it', { day: 'numeric', month: 'short' });
                const ultimaData = new Date(rangeDate[rangeDate.length - 1]).toLocaleDateString('it', { day: 'numeric', month: 'short' });
                
                // Ritorna la stringa del tipo "Dal 1 gen al 6 gen"
                return `Periodo: dal ${primaData} al ${ultimaData}`;
              }
            }
            return item.label; // Fallback se non trova il range
          }
        }
      }
    },
  };

  public barChartOptions: ChartConfiguration<'bar'>['options'] = {
    responsive: true,
    maintainAspectRatio: false,
    plugins: {
      legend: { display: false }, //nasconde la legenda
      tooltip: { enabled: true }  //mostra valore al passaggio del mouse
    },
    scales: {
      x: { display: false },      //toglie completamente asse x (date in basso)
      y: { display: false }       //(numeri a sinistra)
    }
  };


  //crea istanza del servizio
  constructor(private servizio: DataGraphService) {}

  //si avvia in automatico appena il componenete viene inizializzato
  getData(shopId: number | null, comparisonMode: Comparison, month: number, year: number) {
    //ritorna observable che fa .subscribe() -> dopo parte chiamatae e resta in attesa async
      this.servizio.getDataGraph(shopId, comparisonMode, month, year).subscribe({
        //se è andato a buon fine (next) salva in data di tipo DataGraphResponse
        next: (dashboard: DashboardResponse) => 
          {
          
          this.risposta.set(dashboard);  //aggiorna il signal inserendo i dati
  
          if(dashboard == null || !dashboard.salesGraph)  //controllo x vedere se server ha risposto con file vuoto
          {
            return;
          }
  
          console.log("Dati del grafico:", dashboard);
          
          const grafData = dashboard.salesGraph;

          // label, scritte in maniera carina
          const datesToString = grafData.dates.map(d => 
            new Date(d).toLocaleDateString('it', { day: 'numeric', month: 'short' })
          );
  
          // rangeOfPurchase
          //sono liste di dati filtrati per semplice numero 
          const currentValues = grafData.current.map(c => c.rangeOfSales);
          const previousValues = grafData.previous.map(p => p.rangeOfSales);
          

          //idem con tutet le singole date
          // Mappatura dei range di tempo estratti dagli oggetti complessi del backend
          const currentRanges = grafData.current.map(c => c.rangeOfTime);
          const previousRanges = grafData.previous.map(p => p.rangeOfTime);
  
          // rangeOfData
          const esData = new Date(grafData.dates[0]); //prende la prima data
          const currName = esData.toLocaleString('it', { month: 'long' });  //trasforma in mese scritto in parole
  
          this.provaChartData = {
            labels: datesToString,  //le 5 dati principali
            datasets: [
              {
                data: currentValues,
                label: currName,  //cioè il mese scritto a parole
                borderColor: 'blue',
                backgroundColor: 'blue',
                pointRadius: 7,  //grandezza pallini
                ...({ giorniDelRange: currentRanges } as any)
              },
              {
                data: previousValues,
                label: this.periodoPrecedente(), //riuso il computed
                borderColor: 'lightgrey',
                backgroundColor: 'lightgrey',
                borderDash: [10, 5],
                pointRadius: 7,
                ...({ giorniDelRange: previousRanges } as any)
              }
            ]
          };
          
          //per le label degli istrogrammi degli scontrini
          const datiGiornalieriTotaleScontrini = dashboard.totalReceipts.dailyData;
          const datiGiornalieriMediaScontrini =dashboard.averageReceipts.dailyAverageData;

          this.scontriniTotaliIstogramma = {
          labels: datiGiornalieriTotaleScontrini.map(giorno => 
          new Date(giorno.day).toLocaleDateString('it-IT', {
            day: '2-digit',
            month: '2-digit',
            year: 'numeric'
            })
          ),
          datasets: [{
            data: datiGiornalieriTotaleScontrini.map(giorno => giorno.count),
            backgroundColor: '#1e40af',
            borderRadius: 2,  //arrotonda punte delle barre
            barPercentage: 0.7 //spessore +distanziamento tra i giorni
          }]
        };       

          this.scontriniMediaIstogramma = {
          labels: datiGiornalieriMediaScontrini.map(giorno => 
          new Date(giorno.day).toLocaleDateString('it-IT', {
            day: '2-digit',
            month: '2-digit',
            year: 'numeric'
            })
          ),
          datasets: [{
            data: datiGiornalieriMediaScontrini.map(giorno => giorno.average),
            backgroundColor: '#1e40af',
            borderRadius: 2,  //arrotonda punte delle barre
            barPercentage: 0.7 //spessore +distanziamento tra i giorni
          }]
        };


        },
        //se chiamata http fallisce
        error: (errore) => console.error(errore)
      });
    }

    ngOnInit(){
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

  private aggiornaDati() {
  this.getData(
    this.negozioAttivo(), 
    this.confrontoAttivo(),
    this.meseAttivo(), 
    this.annoAttivo(), 
  )
}
}
