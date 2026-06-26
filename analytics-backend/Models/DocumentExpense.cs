using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentExpense
{
    public int Id { get; set; }

    public int DocumentHeadingId { get; set; }

    public int ExpenseItemId { get; set; }

    public int VatId { get; set; }

    public decimal NetAmount { get; set; }

    public decimal VatAmount { get; set; }

    public decimal GrossAmount { get; set; }

    public virtual DocumentHeading DocumentHeading { get; set; } = null!;

    public virtual DocumentExpenseItem ExpenseItem { get; set; } = null!;

    public virtual Vat Vat { get; set; } = null!;
}
