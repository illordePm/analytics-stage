namespace analytics_backend.DTOs
{

    public class KpiContainer
    {
        public KpiValueResponse TotalBought { get; set; }
        public KpiValueResponse TotalSales { get; set; }
        public KpiValueResponse TotalReceipts { get; set; }
        public KpiValueResponse AverageReceipt { get; set; }
    }

    public class KpiValueResponse
    {
        public decimal CurrentValue { get; set; }
        public decimal PreviousValue { get; set; }
    }
}
