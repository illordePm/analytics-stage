using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomersGroup
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<CouponTemplate> CouponTemplates { get; set; } = new List<CouponTemplate>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
