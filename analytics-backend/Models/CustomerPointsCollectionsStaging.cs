using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerPointsCollectionsStaging
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool? IsValid { get; set; }

    public string? BrandCode { get; set; }
}
