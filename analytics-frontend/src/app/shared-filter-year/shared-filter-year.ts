import { Component, input, output, signal } from '@angular/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectChange, MatSelectModule } from '@angular/material/select';

@Component({
  selector: 'app-shared-filter-year',
  imports: [MatFormFieldModule, MatSelectModule],
  templateUrl: './shared-filter-year.html',
  styleUrl: './shared-filter-year.css',
})
export class SharedFilterYear {

  // per avere l'anno
  currentYear = new Date().getFullYear(); 

  years =  input([
    { value: this.currentYear - 2 },
    { value: this.currentYear - 1 },
    { value: this.currentYear }
  ]);
    
  currYear = signal<number>(this.currentYear);

  selectedYear = output<number>();

  onSelectionChange(event: MatSelectChange) {
    this.selectedYear.emit(event.value);
  }
}
