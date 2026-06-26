using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Po
{
    public int Id { get; set; }

    public int PosType { get; set; }

    public string? ExternalId { get; set; }

    public int ShopId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();

    public virtual PosKiosk? PosKiosk { get; set; }

    public virtual ICollection<SaleHeading> SaleHeadings { get; set; } = new List<SaleHeading>();

    public virtual ICollection<SalePriceListLink> SalePriceListLinks { get; set; } = new List<SalePriceListLink>();

    public virtual Shop Shop { get; set; } = null!;

    public virtual ICollection<UpsellSetLink> UpsellSetLinks { get; set; } = new List<UpsellSetLink>();
}
