import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DataGraphResponse } from './grafico-acquisti.types';


@Injectable({
  providedIn: 'root',
})
export class DataGraphService
{

  private apiBackend = 'https://localhost:7103/api/DataGraph'; 

  constructor(private http: HttpClient) {}

  getDataGraph(shopId: number | null, nMonth: number, nYear: number, comparisonMode: number): Observable<DataGraphResponse> 
  {
    var params = new HttpParams().set('nMonth', nMonth);
    params = params.set('nYear', nYear);
    params = params.set('comparisonMode', comparisonMode)

    if (shopId != null && shopId != undefined) {
      params = params.set('shopId', shopId.toString());
    }

    return this.http.get<DataGraphResponse>(this.apiBackend, { params });
  }
}