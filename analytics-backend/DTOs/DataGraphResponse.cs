using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace analytics_backend.DTOs
{
    public class DataGraphResponse
    {
        public DateTime[] Dates { get; set; }
        public DataCurrPrev[] Current { get; set; }
        public DataCurrPrev[] Previous { get; set; }

        public SuppliersPurchases[]? Suppliers { get; set; }
    }

    public class DataCurrPrev
    {
        public DateTime[] RangeOfTime { get; set; }
        public decimal RangeOfPurchase { get; set; }
    }

    public class SuppliersPurchases
    {
        public string? Name { get; set; }
        public decimal Total { get; set; }
    }
}
