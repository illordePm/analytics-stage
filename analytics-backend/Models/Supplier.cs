using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Notes { get; set; }

    public string? Sdi { get; set; }

    public bool IsValid { get; set; }

    public int? AddressId { get; set; }

    public int? ReferenceSupplierId { get; set; }

    public int? SupplierGroupId { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();

    public virtual ICollection<Supplier> InverseReferenceSupplier { get; set; } = new List<Supplier>();

    public virtual ICollection<PurchasePriceList> PurchasePriceLists { get; set; } = new List<PurchasePriceList>();

    public virtual Supplier? ReferenceSupplier { get; set; }

    public virtual SuppliersGroup? SupplierGroup { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
