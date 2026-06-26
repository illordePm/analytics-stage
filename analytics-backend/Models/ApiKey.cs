using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ApiKey
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public string KeyPreview { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsEnabled { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public bool IsDeleted { get; set; }

    public string? Deleter { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ICollection<ApiKeyClaim> ApiKeyClaims { get; set; } = new List<ApiKeyClaim>();
}
