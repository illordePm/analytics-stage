using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Article
{
    public int Id { get; set; }

    public string? PublicName { get; set; }

    public string? Description { get; set; }

    public string? LongDescription { get; set; }

    public string? BillDescription { get; set; }

    public int ArticleType { get; set; }

    public int ArticleSubtype { get; set; }

    public decimal ReferencePrice { get; set; }

    public int? MediaId { get; set; }

    public int VatId { get; set; }

    public int MeasUnitId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public int? ScalesPriceLookUp { get; set; }

    public decimal? Tare { get; set; }

    public decimal? Weight { get; set; }

    public int? WeightMeasUnitId { get; set; }

    public bool IsValid { get; set; }

    public virtual ICollection<ArticlesBarcode> ArticlesBarcodes { get; set; } = new List<ArticlesBarcode>();

    public virtual ICollection<ArticlesCategoriesLink> ArticlesCategoriesLinks { get; set; } = new List<ArticlesCategoriesLink>();

    public virtual ArticlesKioskDatum? ArticlesKioskDatum { get; set; }

    public virtual ICollection<ArticlesLang> ArticlesLangs { get; set; } = new List<ArticlesLang>();

    public virtual ICollection<ArticlesLink> ArticlesLinkChildren { get; set; } = new List<ArticlesLink>();

    public virtual ICollection<ArticlesLink> ArticlesLinkParents { get; set; } = new List<ArticlesLink>();

    public virtual ICollection<ArticlesMeasUnitsConversionFactor> ArticlesMeasUnitsConversionFactors { get; set; } = new List<ArticlesMeasUnitsConversionFactor>();

    public virtual ArticlesNutritional? ArticlesNutritional { get; set; }

    public virtual ArticlesWarehouseDatum? ArticlesWarehouseDatum { get; set; }

    public virtual ICollection<DocumentRow> DocumentRows { get; set; } = new List<DocumentRow>();

    public virtual ICollection<KioskUiGroupDetail> KioskUiGroupDetails { get; set; } = new List<KioskUiGroupDetail>();

    public virtual MeasUnit MeasUnit { get; set; } = null!;

    public virtual Medium? Media { get; set; }

    public virtual ICollection<OutOfStock> OutOfStocks { get; set; } = new List<OutOfStock>();

    public virtual ICollection<PurchasePriceListDetail> PurchasePriceListDetails { get; set; } = new List<PurchasePriceListDetail>();

    public virtual ICollection<RecipeIngredient> RecipeIngredientArticles { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<RecipeIngredient> RecipeIngredientSubstArticles { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<RecipeIngredientsFlat> RecipeIngredientsFlatArticles { get; set; } = new List<RecipeIngredientsFlat>();

    public virtual ICollection<RecipeIngredientsFlat> RecipeIngredientsFlatBaseArticles { get; set; } = new List<RecipeIngredientsFlat>();

    public virtual SaleArticleLink? SaleArticleLinkSaleArticle { get; set; }

    public virtual ICollection<SaleArticleLink> SaleArticleLinkWarehouseArticles { get; set; } = new List<SaleArticleLink>();

    public virtual ICollection<SaleArticleLinksHistory> SaleArticleLinksHistoryNewWarehouseArticles { get; set; } = new List<SaleArticleLinksHistory>();

    public virtual ICollection<SaleArticleLinksHistory> SaleArticleLinksHistoryOldWarehouseArticles { get; set; } = new List<SaleArticleLinksHistory>();

    public virtual ICollection<SaleArticleLinksHistory> SaleArticleLinksHistorySaleArticles { get; set; } = new List<SaleArticleLinksHistory>();

    public virtual ICollection<SalePriceListDetail> SalePriceListDetails { get; set; } = new List<SalePriceListDetail>();

    public virtual ICollection<SaleRow> SaleRows { get; set; } = new List<SaleRow>();

    public virtual ICollection<SaleTransaction> SaleTransactions { get; set; } = new List<SaleTransaction>();

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    public virtual ICollection<UpsellSetDetail> UpsellSetDetails { get; set; } = new List<UpsellSetDetail>();

    public virtual ICollection<UpsellSetLink> UpsellSetLinks { get; set; } = new List<UpsellSetLink>();

    public virtual Vat Vat { get; set; } = null!;

    public virtual ICollection<WarehouseTransaction> WarehouseTransactions { get; set; } = new List<WarehouseTransaction>();

    public virtual MeasUnit? WeightMeasUnit { get; set; }
}
