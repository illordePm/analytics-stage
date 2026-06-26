using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentTotalsAmount
{
    public int Id { get; set; }

    public int DocumentHeadingId { get; set; }

    public int TotalId { get; set; }

    public decimal? VatPercent { get; set; }

    public int? LabelStatementConditionId { get; set; }

    public string LabelResult { get; set; } = null!;

    public decimal NetAmount { get; set; }

    public decimal VatAmount { get; set; }

    public decimal GrossAmount { get; set; }

    public virtual DocumentHeading DocumentHeading { get; set; } = null!;

    public virtual DocumentTotal Total { get; set; } = null!;
}
