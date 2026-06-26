using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Address
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? PostalCode { get; set; }

    public string? Email { get; set; }

    public string? Pec { get; set; }

    public string? PhoneNumberA { get; set; }

    public string? PhoneNumberB { get; set; }

    public string? Website { get; set; }

    public int? CountryId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Shop? Shop { get; set; }

    public virtual Supplier? Supplier { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
