using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class LegalDocumentsLang
{
    public int LegalDocumentId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? PublicTitle { get; set; }

    public int? UploadedDocumentId { get; set; }

    public virtual LegalDocument LegalDocument { get; set; } = null!;

    public virtual Upload? UploadedDocument { get; set; }
}
