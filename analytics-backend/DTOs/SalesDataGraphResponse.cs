namespace analytics_backend.DTOs
{
    public class SalesDataGraphResponse
    {
        public DateTime[] Dates { get; set; }
        public SalesDataCurrPrev[] Current { get; set; }
        public SalesDataCurrPrev[] Previous { get; set; }
    }

    public class SalesDataCurrPrev
    {
        public DateTime[] RangeOfTime { get; set; }
        public decimal RangeOfSales { get; set; }
    }




    public class DailyCountDetail
    {
        public DateTime Day { get; set; }
        public int Count { get; set; }
    }

    public class DailyAverageDetail
    {
        public DateTime Day { get; set; }
        public decimal Average { get; set; }
    }

    public class Report<T>      //per i 2 schemi con valore singolo
    {
        public T Current { get; set; }     //da mostrare direttamente
        public T Previous { get; set; }     //da mostrare direttamente
        public DailyCountDetail[] DailyData { get; set; }   //per fare istogramma del totale degli scontrini
        public DailyAverageDetail[] DailyAverageData { get; set; }      //per fare istogramma della media degli scontrini
    }

    public class DashboardResponse
    {
        public SalesDataGraphResponse SalesGraph { get; set; }   //dati per il grafico
        public Report<int> TotalReceipts { get; set; }  //totale di scontrini
        public Report<decimal> AverageReceipts { get; set; }    //media degli scontrini
    }



    public enum Comparison
    {
        PreviousMonth,
        SameMonthPreviousYear,
    }
}
