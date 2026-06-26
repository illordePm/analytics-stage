using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class MediaSchedulesView
{
    public int? Id { get; set; }

    public int? WelcomeMediaId { get; set; }

    public int? TopBannerMediaId { get; set; }
}
