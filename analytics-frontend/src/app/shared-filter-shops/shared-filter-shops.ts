import { Component, Input, Output, EventEmitter, input, output, signal } from '@angular/core';
import { MatSelectModule, MatSelectChange } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';

import { ShopResponse } from '../shared-filter-shops/shared-filter-shops.type';
import { ShopService } from '../shared-filter-shops/shared-filter-shops.service'

// questo sarà il child component, tutti gli altri saranno parents

@Component({
  selector: 'app-shared-filter-shops',
  imports: [MatFormFieldModule, MatSelectModule],
  templateUrl: './shared-filter-shops.html',
  styleUrl: './shared-filter-shops.css',
})
export class SharedFilterShops {

  shopSignal = signal<ShopResponse[]>([]);
  selectedShop = signal<number | null>(null);

  // output
  selectorChange = output<number | null>();

  // evento output
  onSelectorChange(event: MatSelectChange) {
    this.selectorChange.emit(event.value);
  }


  constructor( private shopService: ShopService ) {}

  ngOnInit() {
    
    // per shops
    this.shopService.getShops().subscribe({
      next: (data: ShopResponse[]) => {
        this.shopSignal.set(data);
        console.log("Negozi arrivati", this.shopSignal());
      },
      error: (errore) => {
        console.error(errore);
      }
    });
  }
}
