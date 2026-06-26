using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerPointsTransactionsStaging
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? CollectionCode { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? Operation { get; set; }

    public decimal? Points { get; set; }

    public string? Notes { get; set; }
}
