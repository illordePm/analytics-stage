using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ShopWarehouse
{
    public int Id { get; set; }

    public int ShopId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsValid { get; set; }

    public bool IsDefault { get; set; }

    public virtual ICollection<DocumentHeading> DocumentHeadingFromWarehouses { get; set; } = new List<DocumentHeading>();

    public virtual ICollection<DocumentHeading> DocumentHeadingToWarehouses { get; set; } = new List<DocumentHeading>();

    public virtual ICollection<DocumentRow> DocumentRows { get; set; } = new List<DocumentRow>();

    public virtual ICollection<SaleTransaction> SaleTransactions { get; set; } = new List<SaleTransaction>();

    public virtual Shop Shop { get; set; } = null!;

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    public virtual ICollection<WarehouseTransaction> WarehouseTransactions { get; set; } = new List<WarehouseTransaction>();
}
