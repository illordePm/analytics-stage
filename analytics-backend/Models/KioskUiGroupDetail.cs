using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskUiGroupDetail
{
    public int Id { get; set; }

    public int KioskUiGroupId { get; set; }

    public int? ChildKioskUiGroupId { get; set; }

    public int? ChildArticleId { get; set; }

    public int OrderNumber { get; set; }

    public string ValidForServiceTypes { get; set; } = null!;

    public virtual Article? ChildArticle { get; set; }

    public virtual KioskUiGroup? ChildKioskUiGroup { get; set; }

    public virtual KioskUiGroup KioskUiGroup { get; set; } = null!;
}
