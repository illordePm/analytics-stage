using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class WarehouseTransaction
{
    public int Id { get; set; }

    public int DocumentHeadingId { get; set; }

    public int CausalId { get; set; }

    public int ShopId { get; set; }

    public int WarehouseId { get; set; }

    public int ArticleId { get; set; }

    public int CurrencyId { get; set; }

    public DateTime TransactionDate { get; set; }

    public decimal Quantity { get; set; }

    public decimal Cost { get; set; }

    public decimal RowTotalCost { get; set; }

    public string Operator { get; set; } = null!;

    public int DocumentDetailId { get; set; }

    public int DocumentStateId { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual DocumentCausal Causal { get; set; } = null!;

    public virtual Currency Currency { get; set; } = null!;

    public virtual DocumentHeading DocumentHeading { get; set; } = null!;

    public virtual DocumentState DocumentState { get; set; } = null!;

    public virtual Shop Shop { get; set; } = null!;

    public virtual ShopWarehouse Warehouse { get; set; } = null!;
}
