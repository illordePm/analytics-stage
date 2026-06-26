using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Vat
{
    public int Id { get; set; }

    public decimal Percent { get; set; }

    public bool IsValid { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    public virtual ICollection<DocumentExpenseItem> DocumentExpenseItems { get; set; } = new List<DocumentExpenseItem>();

    public virtual ICollection<DocumentExpense> DocumentExpenses { get; set; } = new List<DocumentExpense>();

    public virtual ICollection<DocumentRow> DocumentRows { get; set; } = new List<DocumentRow>();

    public virtual ICollection<SalePriceListDetail> SalePriceListDetails { get; set; } = new List<SalePriceListDetail>();

    public virtual ICollection<SaleRow> SaleRows { get; set; } = new List<SaleRow>();

    public virtual VatsFiscal? VatsFiscal { get; set; }
}
