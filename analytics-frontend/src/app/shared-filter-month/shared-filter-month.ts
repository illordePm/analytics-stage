import { Component, input, output, signal } from '@angular/core';
import { MatSelectModule, MatSelectChange } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';

@Component({
  selector: 'app-shared-filter-month',
  standalone: true,
  imports: [MatFormFieldModule, MatSelectModule],
  templateUrl: './shared-filter-month.html',
  styleUrl: './shared-filter-month.css',
})
export class SharedFilterMonths {

  months = input([
    { value: 1, label: 'Gennaio' },
    { value: 2, label: 'Febbraio' },
    { value: 3, label: 'Marzo' },
    { value: 4, label: 'Aprile' },
    { value: 5, label: 'Maggio' },
    { value: 6, label: 'Giugno' },
    { value: 7, label: 'Luglio' },
    { value: 8, label: 'Agosto' },
    { value: 9, label: 'Settembre' },
    { value: 10, label: 'Ottobre' },
    { value: 11, label: 'Novembre' },
    { value: 12, label: 'Dicembre' }
  ]);
    
  currMonth: number = new Date().getMonth() + 1;

  selectedMonth = output<number>();

  onSelectionChange(event: MatSelectChange) {
    this.selectedMonth.emit(event.value);
  }
}