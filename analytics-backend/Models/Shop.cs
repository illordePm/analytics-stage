using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Shop
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? CompanyId { get; set; }

    public int? AddressId { get; set; }

    public int BrandId { get; set; }

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public int? ShopTypeId { get; set; }

    public int CurrencyId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Company? Company { get; set; }

    public virtual ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<DocumentCode> DocumentCodes { get; set; } = new List<DocumentCode>();

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();

    public virtual ICollection<DocumentRow> DocumentRows { get; set; } = new List<DocumentRow>();

    public virtual ICollection<KioskConfigOverride> KioskConfigOverrides { get; set; } = new List<KioskConfigOverride>();

    public virtual ICollection<OutOfStock> OutOfStocks { get; set; } = new List<OutOfStock>();

    public virtual ICollection<Po> Pos { get; set; } = new List<Po>();

    public virtual ICollection<RecipeIngredientsFlat> RecipeIngredientsFlats { get; set; } = new List<RecipeIngredientsFlat>();

    public virtual ICollection<SaleHeading> SaleHeadings { get; set; } = new List<SaleHeading>();

    public virtual ICollection<SalePriceListLink> SalePriceListLinks { get; set; } = new List<SalePriceListLink>();

    public virtual ICollection<SaleTransaction> SaleTransactions { get; set; } = new List<SaleTransaction>();

    public virtual ShopType? ShopType { get; set; }

    public virtual ICollection<ShopWarehouse> ShopWarehouses { get; set; } = new List<ShopWarehouse>();

    public virtual ShopsFidelityDatum? ShopsFidelityDatum { get; set; }

    public virtual ShopsFiscal? ShopsFiscal { get; set; }

    public virtual ICollection<WarehouseTransaction> WarehouseTransactions { get; set; } = new List<WarehouseTransaction>();

    public virtual ICollection<BackofficeUser> Accounts { get; set; } = new List<BackofficeUser>();

    public virtual ICollection<ShopGroup> ShopGroups { get; set; } = new List<ShopGroup>();
}
