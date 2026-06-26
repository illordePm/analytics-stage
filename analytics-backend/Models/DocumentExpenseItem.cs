using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentExpenseItem
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int VatId { get; set; }

    public int ExpenseType { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<DocumentExpense> DocumentExpenses { get; set; } = new List<DocumentExpense>();

    public virtual Vat Vat { get; set; } = null!;
}
