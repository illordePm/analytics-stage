import { Routes } from '@angular/router';
import { KpiPrincipali } from './kpi-principali/kpi-principali';
import { GraficoAcquisti } from './grafico-acquisti/grafico-acquisti';
import { GraficoVendite } from './grafico-vendite/grafico-vendite';

// creo le "strade" per collegarmi ai vari componenti
export const routes: Routes = [
  { path: '', redirectTo: '/kpi-principali', pathMatch: "full"},
  { path: 'kpi-principali', component: KpiPrincipali },
  { path: 'grafico-acquisti', component: GraficoAcquisti},
  { path: 'grafico-vendite', component: GraficoVendite},
];