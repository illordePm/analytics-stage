using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomersStaging
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Street { get; set; }

    public string? PostalCode { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? CountryCode { get; set; }

    public string? PhoneNumber { get; set; }

    public string? ContactEmail { get; set; }

    public DateOnly? BirthDate { get; set; }

    public bool? IsValid { get; set; }

    public string? CustomerCode { get; set; }

    public string? CardNumber { get; set; }

    public string? CardTypeCode { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool? Enabled { get; set; }

    public int? Origin { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? ConsentMarketing { get; set; }

    public bool? ConsentProfiling { get; set; }

    public bool? ConsentTermsAndPrivacy { get; set; }
}
