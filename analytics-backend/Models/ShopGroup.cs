using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ShopGroup
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<DocumentCausal> DocumentCausals { get; set; } = new List<DocumentCausal>();

    public virtual ICollection<PurchasePriceList> PurchasePriceLists { get; set; } = new List<PurchasePriceList>();

    public virtual ICollection<Shop> Shops { get; set; } = new List<Shop>();
}
