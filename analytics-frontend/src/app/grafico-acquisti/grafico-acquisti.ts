import { Component, computed, signal, OnInit } from '@angular/core';
import { ChartData, ChartConfiguration } from 'chart.js';
import { BaseChartDirective, provideCharts, withDefaultRegisterables } from 'ng2-charts';

import ChartDataLabels from 'chartjs-plugin-datalabels';

import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { DataGraphResponse } from './grafico-acquisti.types';
import { DataGraphService} from './grafico-acquisti.service';
import { SharedFilterShops } from "../shared-filter-shops/shared-filter-shops";
import { SharedFilterMonths } from "../shared-filter-month/shared-filter-month";
import { SharedFilterYear } from "../shared-filter-year/shared-filter-year";
import { SharedFilterComparison } from "../shared-filter-comparison/shared-filter-comparison";
import { Comparison } from '../shared-filter-comparison/shared-filter-comparison.type';

@Component({
  selector: 'app-grafico-acquisti',
  standalone: true,
  imports: [BaseChartDirective, MatCardModule, MatIconModule, SharedFilterShops, SharedFilterMonths, SharedFilterYear, SharedFilterComparison],
  templateUrl: './grafico-acquisti.html',
  styleUrl: './grafico-acquisti.css',
  providers:[provideCharts(withDefaultRegisterables())]
})
export class GraficoAcquisti implements OnInit {

  rispostaTotale = signal<DataGraphResponse | null>(null);

  /*
  private datiMock = [
    { data: new Date('2026-04-01'), current: 100000, previous: 50000 },
    { data: new Date('2026-04-08'), current: 250000, previous: 70000 },
    { data: new Date('2026-04-15'), current: 200000, previous: 100000 },
    { data: new Date('2026-04-22'), current: 400000, previous: 200000 },
    { data: new Date('2026-04-29'), current: 750000, previous: 300000 }
  ];
  */

  // per i dati del totale acquistato
  public provaChartData: ChartData<'line'> = {
    labels: [], // vuoti all'inizio, dati messi in OnInit
    datasets: []
  };
  public provaChartOptions: ChartConfiguration<'line'>['options'] = {
    responsive: true,
    scales: {
      x: {},
      y: {}
    },
    plugins: {
      tooltip: {
        callbacks: {
          // titolo dell'hover del mouse modificato
          title: (tooltipItems) => {
            const item = tooltipItems[0];
            const dataset = item.dataset as any;
            
            // prendiamo l'array dei range salvato appositamente nel dataset
            if (dataset && dataset.giorniDelRange && dataset.giorniDelRange[item.dataIndex]) {
              const rangeDate = dataset.giorniDelRange[item.dataIndex] as Date[] | string[];
              
              if (rangeDate.length > 0) {
                const primaData = new Date(rangeDate[0]).toLocaleDateString('it', { day: 'numeric', month: 'short' });
                const ultimaData = new Date(rangeDate[rangeDate.length - 1]).toLocaleDateString('it', { day: 'numeric', month: 'short' });
                
                // ritorna stringa "Periodo: dal x1 y1 al x2 y2"
                return `Periodo: dal ${primaData} al ${ultimaData}`;
              }
            }
            return item.label; // fallback
          }
        }
      }
    },
  };
  

  public suppliersPlugin = [ChartDataLabels];

  // per i dati dei fornitori 
  public suppliersChartData: ChartData<'bar'> = {
    labels: [], 
    datasets: []
  };
  public suppliersChartOptions: ChartConfiguration<'bar'>['options'] = {
    responsive: true,
    scales: {
      y: {},
      x: {}
    },
    indexAxis: 'y',
    plugins: {
      datalabels: {
        anchor: 'end',
        align: 'end',
        formatter: function(value, context) {
        var sumSupplierTotals = 0;

        for (let index = 0; index < context.dataset.data.length; index++) 
        {
          sumSupplierTotals += context.dataset.data[index] as number;
        }
        
        return `${(value.toFixed(2))} (${(value/sumSupplierTotals*100).toFixed(2)}%)`;
        }

      }
    },
    layout: {
      padding: {
        right: 100 
      }
    }
  };

  constructor(private servizio: DataGraphService) {}

  getData(shopId: number | null, nMonth: number, nYear: number, comparisons: Comparison) {
    this.servizio.getDataGraph(shopId, nMonth, nYear, comparisons).subscribe({
      next: (data: DataGraphResponse) => {
        
        this.rispostaTotale.set(data);

        if(data == null)
        {
          return;
        }

        console.log("Dati del grafico:", data);

        /*
         *
         * dati per totale acquistato |
         *                            |
         *                            V
        */

        // label
        const datesToString = data.dates.map(d => 
          new Date(d).toLocaleDateString('it', { day: 'numeric', month: 'short' })
        );

        // rangeOfPurchase
        const currentValues = data.current.map(c => c.rangeOfPurchase);
        const previousValues = data.previous.map(p => p.rangeOfPurchase);

        // map per estrarre dati dei range di tempo
        const currentRanges = data.current.map(c => c.rangeOfTime);
        const previousRanges = data.previous.map(p => p.rangeOfTime);

        // rangeOfData
        const esData = new Date(this.currYear, this.currMonth - 1);
        const currName = esData.toLocaleString('it', { month: 'long' });
        const prevDate = new Date(this.currYear, this.currMonth - 2);
        const prevName = prevDate.toLocaleString('it', { month: 'long' });

        this.provaChartData = {
          labels: datesToString,
          datasets: [
            {
              data: currentValues,
              label: currName,
              borderColor: 'blue',
              backgroundColor: 'blue',
              pointRadius: 10,
              ...({ giorniDelRange: currentRanges } as any)
            },
            {
              data: previousValues,
              label: prevName,
              borderColor: 'lightgrey',
              backgroundColor: 'lightgrey',
              borderDash: [10, 5],
              pointRadius: 10,
              ...({ giorniDelRange: previousRanges } as any)
            }
          ]
        };

        /*
         *
         * dati per fornitori |
         *                    |
         *                    V
        */

        const supplierLabels = data.suppliers.map(s => s.name);
        var supplierTotals = data.suppliers.map(s => s.total);

        this.suppliersChartData = {
          labels: supplierLabels,
          datasets: [
            {
              data: supplierTotals,
              label: 'Totale acquistato',
              backgroundColor: 'blue'
            }
          ]
        };
      },
      error: (errore) => console.error(errore)
    });
  }

  // somma acquisti dei fornitori
  totalSuppliersPurchases = computed(() => {
    var boh = this.rispostaTotale();
    var sum = 0;
    if(boh)
    {
      for (let index = 0; index < boh.suppliers.length; index++) 
      {
        sum += boh.suppliers[index].total;
      }
    }
    return sum.toFixed(2);
  });

  ngOnInit(){
    this.getData(this.currShopId, this.currMonth, this.currYear, this.comparisonMode);
  }

  currShopId: number | null = null;
  currMonth: number = new Date().getMonth() + 1; 
  currYear: number = new Date().getFullYear();
  comparisonMode: Comparison = Comparison.previousMonth; 

  onSelectorChange(shopId: number | null) {
    this.currShopId = shopId;
    this.getData(this.currShopId, this.currMonth, this.currYear, this.comparisonMode);
  }
  
  onMonthChange(nMonth: number) {
    this.currMonth = nMonth;
    this.getData(this.currShopId, this.currMonth, this.currYear, this.comparisonMode);
  }

  onYearChange(nYear: number) {
    this.currYear = nYear;
    this.getData(this.currShopId, this.currMonth, this.currYear, this.comparisonMode);
  }

  onComparisonChange(value: Comparison) {
    this.comparisonMode = value;
    this.getData(this.currShopId, this.currMonth, this.currYear, this.comparisonMode);
  }
}