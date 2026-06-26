import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { KpiContainer, KPIResponse } from './kpi-principali.types';

@Injectable({
  providedIn: 'root',
})
export class KPIService
{
                                // con route ("api/[controller]")
  private apiBackend = 'https://localhost:7103/api/Kpi'; 

  constructor(private http: HttpClient) {}

  getKPI(shopId: number | null | undefined, nMonth: number, nYear: number, comparisonMode: number): Observable<KpiContainer>
  {
    // inizializzo i parametri
    var params = new HttpParams().set('month', nMonth);
    params = params.set('year', nYear);
    params = params.set('comparisonMode', comparisonMode)

    if (shopId != null && shopId != undefined) {
      params = params.set('shopId', shopId);
    }
    // passo i parametri
    return this.http.get<KpiContainer>(this.apiBackend, {params});
  }
}
