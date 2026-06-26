using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class PurchasePriceList
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int SupplierId { get; set; }

    public string? Notes { get; set; }

    public bool IsValid { get; set; }

    public int CurrencyId { get; set; }

    public DateOnly? ValidityFrom { get; set; }

    public DateOnly? ValidityTo { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<DocumentRow> DocumentRows { get; set; } = new List<DocumentRow>();

    public virtual ICollection<PurchasePriceListDetail> PurchasePriceListDetails { get; set; } = new List<PurchasePriceListDetail>();

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<ShopGroup> ShopGroups { get; set; } = new List<ShopGroup>();
}
