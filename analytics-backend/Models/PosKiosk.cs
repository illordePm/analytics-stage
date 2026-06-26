using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class PosKiosk
{
    public int Id { get; set; }

    public bool TakeAwayEnabled { get; set; }

    public bool TableServiceEnabled { get; set; }

    public bool CashPaymentEnabled { get; set; }

    public bool CreditCardPaymentEnabled { get; set; }

    public int LayoutScheduleId { get; set; }

    public int MediaScheduleId { get; set; }

    public string Languages { get; set; } = null!;

    public virtual Po IdNavigation { get; set; } = null!;

    public virtual ICollection<KioskConfigOverride> KioskConfigOverrides { get; set; } = new List<KioskConfigOverride>();

    public virtual KioskLayoutSchedule LayoutSchedule { get; set; } = null!;

    public virtual KioskMediaSchedule MediaSchedule { get; set; } = null!;
}
