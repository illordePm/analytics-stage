using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentHeading
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? ExternalCode { get; set; }

    public DateTime Date { get; set; }

    public int Year { get; set; }

    public DateTime RegistrationDate { get; set; }

    public int TypeId { get; set; }

    public int CausalId { get; set; }

    public int StateId { get; set; }

    public int? PriceListId { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? ConclusionDate { get; set; }

    public bool Concluded { get; set; }

    public int NumberOfRows { get; set; }

    public decimal? ValueDiscount { get; set; }

    public decimal? PercentualADiscount { get; set; }

    public decimal? PercentualBDiscount { get; set; }

    public decimal? PercentualCDiscount { get; set; }

    public int ShopId { get; set; }

    public int? PosId { get; set; }

    public int? FromWarehouseId { get; set; }

    public int? ToWarehouseId { get; set; }

    public int? SupplierId { get; set; }

    public int? CustomerId { get; set; }

    public int CurrencyId { get; set; }

    public string? Notes { get; set; }

    public string? OperationsNotes { get; set; }

    public int? PaymentConditionId { get; set; }

    public bool UseSplitPayment { get; set; }

    public string IntegrationGuid { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public bool IsDeleted { get; set; }

    public string? Deleter { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual DocumentCausal Causal { get; set; } = null!;

    public virtual Currency Currency { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<DocumentExpense> DocumentExpenses { get; set; } = new List<DocumentExpense>();

    public virtual ICollection<DocumentLink> DocumentLinkChildHeadings { get; set; } = new List<DocumentLink>();

    public virtual ICollection<DocumentLink> DocumentLinkParentHeadings { get; set; } = new List<DocumentLink>();

    public virtual ICollection<DocumentRecent> DocumentRecents { get; set; } = new List<DocumentRecent>();

    public virtual ICollection<DocumentRow> DocumentRowHeadings { get; set; } = new List<DocumentRow>();

    public virtual ICollection<DocumentRow> DocumentRowSourceHeadings { get; set; } = new List<DocumentRow>();

    public virtual ICollection<DocumentTotalsAmount> DocumentTotalsAmounts { get; set; } = new List<DocumentTotalsAmount>();

    public virtual ICollection<DocumentWorkflow> DocumentWorkflows { get; set; } = new List<DocumentWorkflow>();

    public virtual ShopWarehouse? FromWarehouse { get; set; }

    public virtual Po? Pos { get; set; }

    public virtual SalePriceList? PriceList { get; set; }

    public virtual Shop Shop { get; set; } = null!;

    public virtual DocumentState State { get; set; } = null!;

    public virtual Supplier? Supplier { get; set; }

    public virtual ShopWarehouse? ToWarehouse { get; set; }

    public virtual DocumentType Type { get; set; } = null!;

    public virtual ICollection<WarehouseTransaction> WarehouseTransactions { get; set; } = new List<WarehouseTransaction>();
}
