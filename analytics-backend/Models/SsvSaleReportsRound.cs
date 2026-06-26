using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SsvSaleReportsRound
{
    public int? Id { get; set; }

    public int? HeadingId { get; set; }

    public int? ShopId { get; set; }

    public string? ShopCode { get; set; }

    public string? ShopDescription { get; set; }

    public string? ShopDesc { get; set; }

    public string? ShopNotes { get; set; }

    public int? PosId { get; set; }

    public string? PosCode { get; set; }

    public string? PosDescription { get; set; }

    public string? PosDesc { get; set; }

    public string? PosNotes { get; set; }

    public int? UnloadWarehouseId { get; set; }

    public string? UnloadWarehouseCode { get; set; }

    public string? UnloadWarehouseDescription { get; set; }

    public string? UnloadWarehouseDesc { get; set; }

    public int? OperatorId { get; set; }

    public string? OperatorCode { get; set; }

    public string? OperatorDescription { get; set; }

    public string? OperatorDesc { get; set; }

    public DateTime? TransactionDate { get; set; }

    public DateOnly? AccountingDate { get; set; }

    public DateTime? AnnullDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public DateOnly? TruncAnnullDate { get; set; }

    public DateOnly? TruncDeleteDate { get; set; }

    public int? TransactionNum { get; set; }

    public int? FiscalNum { get; set; }

    public string? InvoiceNum { get; set; }

    public int? ReceiptNum { get; set; }

    public int? ClosingNum { get; set; }

    public int? CurrencyId { get; set; }

    public string? Acronym { get; set; }

    public decimal? Change { get; set; }

    public DateTime? ChangeDate { get; set; }

    public int? SaleTypeId { get; set; }

    public string? SaleTypeCode { get; set; }

    public string? SaleTypeDesc { get; set; }

    public bool? ExcludeOnStatistics { get; set; }

    public int? SaleCausalId { get; set; }

    public string? SaleCausalCode { get; set; }

    public string? SaleCausalDesc { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerDesc { get; set; }

    public int? ReferenceCustomerId { get; set; }

    public string? CardNum { get; set; }

    public string? Notes { get; set; }

    public bool? Deleted { get; set; }

    public bool? Annulled { get; set; }

    public int? BillStatus { get; set; }

    public int? DetailOrder { get; set; }

    public bool? DetailDeleted { get; set; }

    public int? SellerId { get; set; }

    public string? SellerCode { get; set; }

    public string? SellerDescription { get; set; }

    public string? SellerDesc { get; set; }

    public int? SaleArticleId { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? ArticleNotes { get; set; }

    public int? ArticleId { get; set; }

    public string? WarehouseArticleCode { get; set; }

    public string? WarehouseArticleDesc { get; set; }

    public int? ReferenceId { get; set; }

    public int? MenuId { get; set; }

    public string? MenuCode { get; set; }

    public string? MenuDesc { get; set; }

    public string? RowType { get; set; }

    public int? GroupLevel1Id { get; set; }

    public int? GroupLevel2Id { get; set; }

    public int? GroupLevel3Id { get; set; }

    public int? GroupLevel4Id { get; set; }

    public int? GroupLevel5Id { get; set; }

    public string? GroupLevel1Desc { get; set; }

    public string? GroupLevel2Desc { get; set; }

    public string? GroupLevel3Desc { get; set; }

    public string? GroupLevel4Desc { get; set; }

    public string? GroupLevel5Desc { get; set; }

    public int? VatId { get; set; }

    public string? VatCode { get; set; }

    public string? Vat { get; set; }

    public decimal? VatPercent { get; set; }

    public string? MeasUnitCode { get; set; }

    public string? MeasUnit { get; set; }

    public decimal? ConversionFactor { get; set; }

    public int? SalePriceListId { get; set; }

    public string? SalePriceListCode { get; set; }

    public string? SalePriceListDesc { get; set; }

    public int? DetailSaleCausalId { get; set; }

    public string? DetailSaleCausalCode { get; set; }

    public string? DetailSaleCausalDesc { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Cost { get; set; }

    public decimal? PriceListPrice { get; set; }

    public decimal? BillPrice { get; set; }

    public decimal? Price { get; set; }

    public decimal? NetPrice { get; set; }

    public decimal? Discount { get; set; }

    public decimal? NetDiscount { get; set; }

    public decimal? PromotionDiscount { get; set; }

    public decimal? PromotionNetDiscount { get; set; }

    public decimal? RowTotalPrice { get; set; }

    public decimal? RowVat { get; set; }

    public decimal? NetRowPrice { get; set; }

    public decimal? NetRowPriceRound { get; set; }

    public decimal? RowVatRound { get; set; }

    public decimal? DiscountedRowTotalPrice { get; set; }

    public int? SalePaymentId { get; set; }
}
