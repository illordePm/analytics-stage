using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentRow
{
    public int Id { get; set; }

    public int HeadingId { get; set; }

    public int ShopId { get; set; }

    public int WarehouseId { get; set; }

    public int ArticleId { get; set; }

    public int? SalePriceListId { get; set; }

    public int? PurchasePriceListId { get; set; }

    public string? Barcode { get; set; }

    public string? SuppArticleCode { get; set; }

    public string? SuppArticleDescription { get; set; }

    public int VatId { get; set; }

    public int MeasUnitId { get; set; }

    public decimal ConversionFactor { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ConfirmedQuantity { get; set; }

    public decimal? StockQuantity { get; set; }

    public decimal? DiffQuantity { get; set; }

    public decimal? PriceListAmount { get; set; }

    public decimal? Amount { get; set; }

    public decimal? ValueDiscount { get; set; }

    public decimal? PercentDiscount { get; set; }

    public decimal? RowTotalAmount { get; set; }

    public decimal? GrossTotalAmount { get; set; }

    public decimal? VatTotalAmount { get; set; }

    public int? SourceDetailId { get; set; }

    public int? SourceHeadingId { get; set; }

    public bool Concluded { get; set; }

    public int? CausalId { get; set; }

    public string? Notes { get; set; }

    public string? OperationsNotes { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public bool IsDeleted { get; set; }

    public string? Deleter { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual DocumentCausal? Causal { get; set; }

    public virtual DocumentHeading Heading { get; set; } = null!;

    public virtual ICollection<DocumentRow> InverseSourceDetail { get; set; } = new List<DocumentRow>();

    public virtual MeasUnit MeasUnit { get; set; } = null!;

    public virtual PurchasePriceList? PurchasePriceList { get; set; }

    public virtual SalePriceList? SalePriceList { get; set; }

    public virtual Shop Shop { get; set; } = null!;

    public virtual DocumentRow? SourceDetail { get; set; }

    public virtual DocumentHeading? SourceHeading { get; set; }

    public virtual Vat Vat { get; set; } = null!;

    public virtual ShopWarehouse Warehouse { get; set; } = null!;
}
