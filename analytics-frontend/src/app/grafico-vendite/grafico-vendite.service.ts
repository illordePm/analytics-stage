import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DashboardResponse } from './grafico-vendite.types';


    //prende i dati da internet->da api-db

    //accessibile ovunque nel programma
@Injectable({
  providedIn: 'root',
})
export class DataGraphService
{

  private apiBackend = 'https://localhost:7103/api/SalesDataGraph'; 

  //mette a disposzione this.http per chiamate web
  constructor(private http: HttpClient) {}

    //con observable gestisco in maniera async il flusso di dati
    //non si blocca il browser 
    //obs. invia notifica quando i dati sono pronti/arrivati
  getDataGraph(shopId: number | null, comparisonMode: number,  month: number, year: number): Observable<DashboardResponse>
  //returna Observable<DataGraphResponse>
  {
    var params = new HttpParams();

    //se c'è il negozio lo include
    if (shopId != null && shopId != undefined) {
      params = params.set('shopId', shopId.toString());
    }

    //ed include previousMonth di default
    params =params.set('comparisonMode', comparisonMode);  //col valore a mo di stringa perchè accetta solo str
    params=params.set('month', month);
    params=params.set('year', year);

    //fa richiesta get 
    return this.http.get<DashboardResponse>(this.apiBackend, { params });
  }
}