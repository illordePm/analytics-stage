export interface DataCurrPrev {
  rangeOfTime:  Date[];
  rangeOfPurchase: number;  
}

export interface DataGraphResponse {
  dates: Date[];
  current: DataCurrPrev[];
  previous: DataCurrPrev[];
  suppliers: SuppliersData[]; 
}

export interface SuppliersData {
  name: string;
  total: number;
}