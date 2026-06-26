using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SaleHeading
{
    public int Id { get; set; }

    public int ShopId { get; set; }

    public int PosId { get; set; }

    public int Code { get; set; }

    public DateTime TransactionDate { get; set; }

    public DateOnly AccountingDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? CurrencyId { get; set; }

    public string? ExternalCausalCode { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public bool Acquired { get; set; }

    public int? ExternalId { get; set; }

    public int? OperatorId { get; set; }

    public int? DeleteOperatorId { get; set; }

    public int? SalePriceListId { get; set; }

    public int? SaleCausalId { get; set; }

    public string? Notes { get; set; }

    public string? CardNum { get; set; }

    public int? FiscalNum { get; set; }

    public int? SaleTypeId { get; set; }

    public int? CustomerId { get; set; }

    public bool Suspended { get; set; }

    public string? InvoiceNum { get; set; }

    public string? FiscalCode { get; set; }

    public decimal? TotalQuantity { get; set; }

    public int? TotalItems { get; set; }

    public decimal? TotalDiscounts { get; set; }

    public string? ReferenceCardNum { get; set; }

    public int? ReferenceCustomerId { get; set; }

    public string? DocumentExtCode { get; set; }

    public int BillStatus { get; set; }

    public int? LunchTableId { get; set; }

    public bool UseSplitPayment { get; set; }

    public decimal? TotalNetAmount { get; set; }

    public int? ClosingNum { get; set; }

    public string? PrinterSerialNum { get; set; }

    public string? PosSerialNum { get; set; }

    public int? SourceFiscalNum { get; set; }

    public int? SourceClosingNum { get; set; }

    public DateTime? SourceTransactionDate { get; set; }

    public string? SourcePrinterSerialNum { get; set; }

    public string? SourcePosSerialNum { get; set; }

    public string? LotteryCode { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Po Pos { get; set; } = null!;

    public virtual Customer? ReferenceCustomer { get; set; }

    public virtual DocumentCausal? SaleCausal { get; set; }

    public virtual SalePriceList? SalePriceList { get; set; }

    public virtual ICollection<SaleRow> SaleRows { get; set; } = new List<SaleRow>();

    public virtual Shop Shop { get; set; } = null!;
}
