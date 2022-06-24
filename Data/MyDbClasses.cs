using System.ComponentModel.DataAnnotations;

namespace Zip2Clear.Data
{
    #region Declaration class
    public class Declaration
    {
        public Guid Id { get; set; }
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
        public Guid Id { get; set; }
        public Guid? DeclarationId { get; set; } //This is a foreign key
        public Declaration? Declaration { get; set; } //This is a navigation property
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public Guid? VendorId { get; set; }
        public Vendor? Vendor { get; set; }
        public string? VendorName { get; set; }
        public decimal FreightValue { get; set; }
        public decimal InsuranceValue { get; set; }
    }

    public class Item
    {
        public Guid Id { get; set; }
        public Guid? InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
        public string? Department { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public double? Weight { get; set; }
        public string UomId { get; set; }
        public double UomValue { get; set; }
        public double HsCode { get; set; }
        public double DutyGeneralRate { get; set; }
        public double DutyExciseRate { get; set; }
    }
    #endregion

    #region Vendor class
    public class Vendor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public string? CityName { get; set; }
        public string? State { get; set; }
        public string? CountryCode { get; set; }
        public string? PostalCode { get; set; }
    }
    #endregion
}
