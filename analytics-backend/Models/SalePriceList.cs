using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SalePriceList
{
    public int Id { get; set; }

    public DateOnly? ValidityFrom { get; set; }

    public DateOnly? ValidityTo { get; set; }

    public bool IsValid { get; set; }

    public int CurrencyId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();

    public virtual ICollection<DocumentRow> DocumentRows { get; set; } = new List<DocumentRow>();

    public virtual ICollection<SaleHeading> SaleHeadings { get; set; } = new List<SaleHeading>();

    public virtual ICollection<SalePriceListDetail> SalePriceListDetails { get; set; } = new List<SalePriceListDetail>();

    public virtual ICollection<SalePriceListLink> SalePriceListLinks { get; set; } = new List<SalePriceListLink>();

    public virtual ICollection<SaleRow> SaleRows { get; set; } = new List<SaleRow>();
}
