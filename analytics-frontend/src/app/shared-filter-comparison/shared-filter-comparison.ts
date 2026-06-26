import { Component, signal, output } from '@angular/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule, MatSelectChange } from '@angular/material/select';
import { Comparison } from './shared-filter-comparison.type';

@Component({
  selector: 'app-shared-filter-comparison',
  imports: [MatFormFieldModule, MatSelectModule],
  templateUrl: './shared-filter-comparison.html',
  styleUrl: './shared-filter-comparison.css',
})
export class SharedFilterComparison {

  readonly Comp = Comparison; //proprietà per leggere tipo enum

  //di default a previousMonth
  selectedComparison = signal<Comparison>(Comparison.previousMonth);

  //definisce evento (comparisonChange) per il parent (html)
  comparisonChange = output<Comparison>();

  //faccio attivare quando si preme sulla tendina
  onComparisonChange(value: Comparison) {
    //aggiorno se stesso ->cambia quello che viene scritto graficamente (campo [value]->vedi html)
    this.selectedComparison.set(value);

    //aggiorna output che serve al padre (html) per poi richiedere in maniera specifica a backend 
    this.comparisonChange.emit(value);
  }
}
