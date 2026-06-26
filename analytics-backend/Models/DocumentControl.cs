using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentControl
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsRowControl { get; set; }

    public string Statement { get; set; } = null!;

    public string Message { get; set; } = null!;

    public virtual ICollection<CausalControl> CausalControls { get; set; } = new List<CausalControl>();
}
