using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool IsValid { get; set; }

    public string? ContactEmail { get; set; }

    public bool ConsentTermsAndPrivacy { get; set; }

    public string? PhoneNumber { get; set; }

    public DateOnly? BirthDate { get; set; }

    public int Gender { get; set; }

    public int? MainAddressId { get; set; }

    public string? FidelityUserId { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool ConsentMarketing { get; set; }

    public bool ConsentProfiling { get; set; }

    public int Origin { get; set; }

    public virtual ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();

    public virtual ICollection<CustomerCard> CustomerCards { get; set; } = new List<CustomerCard>();

    public virtual ICollection<CustomerConsentsHistory> CustomerConsentsHistories { get; set; } = new List<CustomerConsentsHistory>();

    public virtual CustomerFiscal? CustomerFiscalCustomer { get; set; }

    public virtual ICollection<CustomerFiscal> CustomerFiscalReferenceCustomers { get; set; } = new List<CustomerFiscal>();

    public virtual ICollection<CustomerPoint> CustomerPoints { get; set; } = new List<CustomerPoint>();

    public virtual ICollection<CustomerPointsTransaction> CustomerPointsTransactions { get; set; } = new List<CustomerPointsTransaction>();

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();

    public virtual FidelityUser? FidelityUser { get; set; }

    public virtual Address? MainAddress { get; set; }

    public virtual ICollection<SaleHeading> SaleHeadingCustomers { get; set; } = new List<SaleHeading>();

    public virtual ICollection<SaleHeading> SaleHeadingReferenceCustomers { get; set; } = new List<SaleHeading>();

    public virtual ICollection<CustomersGroup> CustomerGroups { get; set; } = new List<CustomersGroup>();
}
