using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class LegalDocument
{
    public int Id { get; set; }

    public bool IsValid { get; set; }

    public DateOnly IssueDate { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? PublicTitle { get; set; }

    public int Type { get; set; }

    public int UploadedDocumentId { get; set; }

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<LegalDocumentsLang> LegalDocumentsLangs { get; set; } = new List<LegalDocumentsLang>();

    public virtual Upload UploadedDocument { get; set; } = null!;
}
