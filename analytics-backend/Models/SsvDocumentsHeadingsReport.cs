using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SsvDocumentsHeadingsReport
{
    public int? Id { get; set; }

    public int? DocumentCode { get; set; }

    public DateTime? DocumentDate { get; set; }

    public int? DocumentYear { get; set; }

    public string? DocumentExtCode { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public bool? UseSplitPayment { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentTypeCode { get; set; }

    public string? DocumentTypeDesc { get; set; }

    public int? DocumentCausalId { get; set; }

    public string? DocumentCausalCode { get; set; }

    public string? DocumentCausalDesc { get; set; }

    public string? RegistrationDateDesc { get; set; }

    public int? DocumentStateId { get; set; }

    public string? DocumentStateCode { get; set; }

    public string? DocumentStateDesc { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public bool? RowsConclused { get; set; }

    public DateTime? ValidationDate { get; set; }

    public bool? Conclused { get; set; }

    public int? NumberOfRows { get; set; }

    public decimal? ValueDiscount { get; set; }

    public decimal? PercentualADiscount { get; set; }

    public decimal? PercentualBDiscount { get; set; }

    public decimal? PercentualCDiscount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? GrossAmount { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyDesc { get; set; }

    public string? CompanyNotes { get; set; }

    public string? CompanyStreet { get; set; }

    public string? CompanyZipCode { get; set; }

    public string? CompanyCity { get; set; }

    public string? CompanyCountry { get; set; }

    public string? CompanyNation { get; set; }

    public string? CompanyPhoneA { get; set; }

    public string? CompanyPhoneB { get; set; }

    public string? CompanyFax { get; set; }

    public string? CompanyInternet { get; set; }

    public string? CompanyEmail { get; set; }

    public string? CompanyFiscalCodeA { get; set; }

    public string? CompanyFiscalCodeB { get; set; }

    public string? CompanyHeadquarters { get; set; }

    public int? CompanyTypeId { get; set; }

    public string? CompanyTypeCode { get; set; }

    public string? CompanyTypeDescription { get; set; }

    public int? ParentCompanyId { get; set; }

    public string? ParentCompanyCode { get; set; }

    public string? ParentCompanyDesc { get; set; }

    public string? ParentCompanyNotes { get; set; }

    public string? ParentCompanyStreet { get; set; }

    public string? ParentCompanyZipCode { get; set; }

    public string? ParentCompanyCity { get; set; }

    public string? ParentCompanyCountry { get; set; }

    public string? ParentCompanyNation { get; set; }

    public string? ParentCompanyPhoneA { get; set; }

    public string? ParentCompanyPhoneB { get; set; }

    public string? ParentCompanyFax { get; set; }

    public string? ParentCompanyInternet { get; set; }

    public string? ParentCompanyEmail { get; set; }

    public string? ParentCompanyFiscalCodeA { get; set; }

    public string? ParentCompanyFiscalCodeB { get; set; }

    public string? ParentCompanyHeadquarters { get; set; }

    public int? FromWarehouseId { get; set; }

    public string? FromWarehouseCode { get; set; }

    public string? FromWarehouseDesc { get; set; }

    public int? ToWarehouseId { get; set; }

    public string? ToWarehouseCode { get; set; }

    public string? ToWarehouseDesc { get; set; }

    public string? ToCompanyCode { get; set; }

    public string? ToCompanyDesc { get; set; }

    public string? ToCompanyNotes { get; set; }

    public string? ToCompanyStreet { get; set; }

    public string? ToCompanyZipCode { get; set; }

    public string? ToCompanyCity { get; set; }

    public string? ToCompanyCountry { get; set; }

    public string? ToCompanyNation { get; set; }

    public string? ToCompanyPhoneA { get; set; }

    public string? ToCompanyPhoneB { get; set; }

    public string? ToCompanyFax { get; set; }

    public string? ToCompanyInternet { get; set; }

    public string? ToCompanyEmail { get; set; }

    public string? ToCompanyFiscalCodeA { get; set; }

    public string? ToCompanyFiscalCodeB { get; set; }

    public string? ToCompanyHeadquarters { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierCode { get; set; }

    public string? SupplierDesc { get; set; }

    public string? SupplierNotes { get; set; }

    public string? SupplierStreet { get; set; }

    public string? SupplierZipCode { get; set; }

    public string? SupplierCity { get; set; }

    public string? SupplierCountry { get; set; }

    public string? SupplierNation { get; set; }

    public string? SupplierPhoneA { get; set; }

    public string? SupplierPhoneB { get; set; }

    public string? SupplierFax { get; set; }

    public string? SupplierInternet { get; set; }

    public string? SupplierEmail { get; set; }

    public string? SupplierFiscalCodeA { get; set; }

    public string? SupplierFiscalCodeB { get; set; }

    public string? SupplierInvoiceAddress { get; set; }

    public int? ReferenceSupplierId { get; set; }

    public string? RefSupplierCode { get; set; }

    public string? RefSupplierDesc { get; set; }

    public string? RefSupplierNotes { get; set; }

    public string? RefSupplierStreet { get; set; }

    public string? RefSupplierZipCode { get; set; }

    public string? RefSupplierCity { get; set; }

    public string? RefSupplierCountry { get; set; }

    public string? RefSupplierNation { get; set; }

    public string? RefSupplierPhoneA { get; set; }

    public string? RefSupplierPhoneB { get; set; }

    public string? RefSupplierFax { get; set; }

    public string? RefSupplierInternet { get; set; }

    public string? RefSupplierEmail { get; set; }

    public string? RefSupplierFiscalCodeA { get; set; }

    public string? RefSupplierFiscalCodeB { get; set; }

    public string? RefSupplierInvoiceAddress { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerDesc { get; set; }

    public string? CustomerNotes { get; set; }

    public string? CustomerStreet { get; set; }

    public string? CustomerZipCode { get; set; }

    public string? CustomerCity { get; set; }

    public string? CustomerCountry { get; set; }

    public string? CustomerNation { get; set; }

    public string? CustomerPhoneA { get; set; }

    public string? CustomerPhoneB { get; set; }

    public string? CustomerFax { get; set; }

    public string? CustomerInternet { get; set; }

    public string? CustomerEmail { get; set; }

    public string? CustomerFiscalCodeA { get; set; }

    public string? CustomerFiscalCodeB { get; set; }

    public string? CustomerInvoiceAddress { get; set; }

    public bool? CustomerPrintPrice { get; set; }

    public int? ReferenceCustomerId { get; set; }

    public string? RefCustomerCode { get; set; }

    public string? RefCustomerDesc { get; set; }

    public string? RefCustomerNotes { get; set; }

    public string? RefCustomerStreet { get; set; }

    public string? RefCustomerZipCode { get; set; }

    public string? RefCustomerCity { get; set; }

    public string? RefCustomerCountry { get; set; }

    public string? RefCustomerNation { get; set; }

    public string? RefCustomerPhoneA { get; set; }

    public string? RefCustomerPhoneB { get; set; }

    public string? RefCustomerFax { get; set; }

    public string? RefCustomerInternet { get; set; }

    public string? RefCustomerEmail { get; set; }

    public string? RefCustomerFiscalCodeA { get; set; }

    public string? RefCustomerFiscalCodeB { get; set; }

    public string? RefCustomerInvoiceAddress { get; set; }

    public bool? RefCustomerPrintPrice { get; set; }

    public string? OperatorId { get; set; }

    public string? OperatorCode { get; set; }

    public string? OperatorDesc { get; set; }

    public int? CurrencyId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyDesc { get; set; }

    public decimal? Change { get; set; }

    public DateTime? ChangeDate { get; set; }

    public string? Notes { get; set; }

    public string? DeliveryDescription { get; set; }

    public int? DeliveryItems { get; set; }

    public decimal? DeliveryWeight { get; set; }

    public int? ShopId { get; set; }

    public string? ShopCode { get; set; }

    public string? ShopDescription { get; set; }

    public string? ShopNotes { get; set; }

    public string? ShopFiscalCodeA { get; set; }

    public string? ShopFiscalCodeB { get; set; }

    public string? ShopReaCode { get; set; }

    public string? ShopReaProgr { get; set; }

    public string? ShopStreet { get; set; }

    public string? ShopZipCode { get; set; }

    public string? ShopCity { get; set; }

    public string? ShopCountry { get; set; }

    public string? ShopNation { get; set; }

    public string? ShopPhoneA { get; set; }

    public string? ShopPhoneB { get; set; }

    public string? ShopFax { get; set; }

    public string? ShopInternet { get; set; }

    public string? ShopEmail { get; set; }

    public int? PosId { get; set; }

    public string? PosCode { get; set; }

    public string? PosDesc { get; set; }

    public int? PaymentConditionId { get; set; }

    public string? PaymentCode { get; set; }

    public string? PaymentDesc { get; set; }

    public int? CompanyBankAccountId { get; set; }

    public string? CompanyBankName { get; set; }

    public string? CompanyBankAccount { get; set; }

    public int? BankAccountId { get; set; }

    public string? BankName { get; set; }

    public string? BankAccount { get; set; }
}
