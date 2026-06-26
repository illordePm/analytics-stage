import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ShopResponse } from './shared-filter-shops.type';

@Injectable({
  providedIn: 'root',
})
export class ShopService
{
  private apiShop = 'https://localhost:7103/api/Shop';

  constructor(private http: HttpClient) {}

  getShops(): Observable<ShopResponse[]> 
  {
    
    return this.http.get<ShopResponse[]>(this.apiShop);
  }
}