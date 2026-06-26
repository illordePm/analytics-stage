using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentCode
{
    public int Id { get; set; }

    public int DocumentTypeId { get; set; }

    public int ShopId { get; set; }

    public int CurrentCode { get; set; }

    public int Year { get; set; }

    public virtual DocumentType DocumentType { get; set; } = null!;

    public virtual Shop Shop { get; set; } = null!;
}
