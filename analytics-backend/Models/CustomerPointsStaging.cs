using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerPointsStaging
{
    public int Id { get; set; }

    public string? CustomerCode { get; set; }

    public string? CollectionCode { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public decimal? PointsAmount { get; set; }
}
