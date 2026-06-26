export interface SalesDataCurrPrev {
  rangeOfTime:  Date[];
  rangeOfSales: number;  
}


//stessi nomi di c#
export interface SalesDataGraphResponse {
  dates: Date[];    //le 5 principali date
  current: SalesDataCurrPrev[];  //somma dei valori delle 6/7 date + le singole date di quel "blocco"
  previous: SalesDataCurrPrev[];
}

export interface DailyCountDetail {
  day: Date;
  count: number;
}

export interface DailyAverageDetail{
  day:Date,
  average:number
}

export interface Report<T>{
  current: T,
  previous: T,
  dailyData: DailyCountDetail[];
  dailyAverageData : DailyAverageDetail[]
}

export interface DashboardResponse{
  salesGraph: SalesDataGraphResponse,
  totalReceipts: Report<number>,
  averageReceipts: Report<number>
}