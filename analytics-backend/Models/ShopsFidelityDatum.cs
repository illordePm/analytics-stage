using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ShopsFidelityDatum
{
    public int ShopId { get; set; }

    public bool ShowInShopLocator { get; set; }

    public virtual Shop Shop { get; set; } = null!;
}
