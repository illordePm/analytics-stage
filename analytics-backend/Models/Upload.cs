using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Upload
{
    public int Id { get; set; }

    public string FileName { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public string Url { get; set; } = null!;

    public long FileSize { get; set; }

    public bool IsPending { get; set; }

    public DateTime UploadDate { get; set; }

    public int AccessLevel { get; set; }

    public int Type { get; set; }

    public virtual ICollection<LegalDocument> LegalDocuments { get; set; } = new List<LegalDocument>();

    public virtual ICollection<LegalDocumentsLang> LegalDocumentsLangs { get; set; } = new List<LegalDocumentsLang>();
}
