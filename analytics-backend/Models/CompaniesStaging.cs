using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CompaniesStaging
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? CompanyCode { get; set; }

    public string? AddressType { get; set; }

    public string? AddressName { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? PostalCode { get; set; }

    public string? CountryCode { get; set; }

    public string? Email { get; set; }

    public string? Pec { get; set; }

    public string? PhoneNumberA { get; set; }

    public string? PhoneNumberB { get; set; }

    public string? Website { get; set; }
}
