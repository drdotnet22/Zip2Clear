﻿using System.ComponentModel.DataAnnotations;

namespace Zip2Clear.Data
{
    #region Declaration class
    public class Declaration
    {
        public Guid DeclarationId { get; set; }
        public bool Submitted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string? ManifestNumber { get; set; }
        public string? BOLnumber { get; set; }
        public string DeclarationNumber { get; set; }
        public string Type { get; set; }
        public string? Status { get; set; }
        public string Regime { get; set; }
        public string DeclarationOffice { get; set; }
        public string PortOfEntry { get; set; }
        public string PortOfExit { get; set; }
        public string CountryOfOrigin { get; set; }
        public string ModeOfTransport { get; set; }
        public string CountryOfDestination { get; set; }
        public double TotalGrossMassMeasureQnty { get; set; }
        public string TotalGrossMassMeasureUOM { get; set; }
        public double TotalPackageQnty { get; set; }
        public string TotalPackageQntyUOM { get; set; }
        public string Importer { get; set; }
        public string Exporter { get; set; }
    }
    #endregion

    #region Invoice class
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public Guid? DeclarationId { get; set; } //This is a foreign key
        public Declaration? Declaration { get; set; } //This is a navigation property
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public decimal Shipping { get; set; }
        public decimal Insurance { get; set; }
        public Guid? DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
    #endregion

    #region Item class
    public class Item
    {
        public Guid ItemId { get; set; }
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public double Quantity { get; set; }
        public decimal Value { get; set; }
        public double? Weight { get; set; }
        public double? UomValue { get; set; }
        public Guid TariffId { get; set; }
        public Tariff Tariff { get; set; }
        public string TariffCode { get; set; }
        public decimal TariffGeneralRate { get; set; }
        public decimal TariffExciseRate { get; set; }
        public decimal EnvironmentalLevy { get; set; }
    }
    #endregion

    #region Vendor class
    public class Vendor
    {
        [Key] public Guid VendorId { get; set; }
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public string? CityName { get; set; }
        public string? State { get; set; }
        public string? CountryCode { get; set; }
        public string? PostalCode { get; set; }
    }
    #endregion

    #region Tariff codes class
    public class Tariff
    {
        public Guid TariffId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal GeneralRate { get; set; }
        public decimal ExciseRate { get; set; }
        public decimal EnvironmentalLevy { get; set; }
        public Guid? UomId { get; set; }
        public Uom Uom { get; set; }
    }
    #endregion

    #region Department
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
    #endregion

    #region UOM
    public class Uom
    {
        public Guid UomId { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
    }
    #endregion
}
