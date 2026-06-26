using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Currency
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();

    public virtual ICollection<PurchasePriceList> PurchasePriceLists { get; set; } = new List<PurchasePriceList>();

    public virtual ICollection<SaleHeading> SaleHeadings { get; set; } = new List<SaleHeading>();

    public virtual ICollection<SalePriceList> SalePriceLists { get; set; } = new List<SalePriceList>();

    public virtual ICollection<SaleTransaction> SaleTransactions { get; set; } = new List<SaleTransaction>();

    public virtual ICollection<Shop> Shops { get; set; } = new List<Shop>();

    public virtual ICollection<WarehouseTransaction> WarehouseTransactions { get; set; } = new List<WarehouseTransaction>();
}
