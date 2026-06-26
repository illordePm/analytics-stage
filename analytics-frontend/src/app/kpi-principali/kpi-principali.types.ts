// i nomi delle variabili devono essere uguali a quelli del backend
export interface KPIResponse {
  previousMonth: string,
  currentMonth: string,
  previousTotal: number
  currentTotal: number,
} 

export interface KpiValueResponse{  
  currentValue: number
  previousValue:number
}

export interface KpiContainer{
  totalBought:KpiValueResponse,
  totalSales:KpiValueResponse,
  totalReceipts:KpiValueResponse,
  averageReceipt:KpiValueResponse
}