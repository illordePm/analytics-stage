using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentLink
{
    public int Id { get; set; }

    public int ParentHeadingId { get; set; }

    public int ChildHeadingId { get; set; }

    public virtual DocumentHeading ChildHeading { get; set; } = null!;

    public virtual DocumentHeading ParentHeading { get; set; } = null!;
}
