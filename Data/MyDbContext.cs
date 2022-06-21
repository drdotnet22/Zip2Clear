using Microsoft.EntityFrameworkCore;

namespace Zip2Clear.Data
{ 
    public class MyDbContext : DbContext
    {
        #region Constructor
        public MyDbContext(DbContextOptions<MyDbContext> options)
                : base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Declaration> Declaration { get; set; }
        public DbSet<Item> Item { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>().HasData(GetVendors());
            modelBuilder.Entity<Invoice>().HasData(GetInvoices());
            modelBuilder.Entity<Declaration>().HasData(GetDeclarations());
            modelBuilder.Entity<Item>().HasData(GetItems());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        private List<Vendor> GetVendors()
        {
            return new List<Vendor>
            {
                new Vendor { Id = Guid.NewGuid(), VendorName = "WALPOLE FEED", VendorAddressLine = "PO BOX 1723", VendorCityName = "OKEECHOBEE", VendorState = "FL", VendorPostalCode = "34973", VendorCountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), VendorName = "AGRIVET", VendorAddressLine = "12029 W DOPHIN CT", VendorCityName = "HOMOSASSA", VendorState = "FL", VendorPostalCode = "34448", VendorCountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), VendorName = "ROADWAY TIRES", VendorAddressLine = "1301 SW 2ND ST", VendorCityName = "POMPANO BEACH", VendorState = "FL", VendorPostalCode = "33069", VendorCountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), VendorName = "TPH", VendorAddressLine = "2968 RAVENSWOOD ROAD", VendorCityName = "FORT LAUDERDALE", VendorState = "FL", VendorPostalCode = "33312", VendorCountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), VendorName = "MONTE PACKAGE", VendorAddressLine = "4300 STEWART ROAD", VendorCityName = "LAKELAND", VendorState = "FL", VendorPostalCode = "33815", VendorCountryCode = "US" }
            };
        }

        private List<Declaration> GetDeclarations()
        {
            return new List<Declaration>
            {
                new Declaration { Id = Guid.NewGuid(), Regime = "4", DeclarationType = "400", ModeOfTransport = "1", DeclarationOffice = "SAQPDK", DeclarationNumber = "2022DEC0000845484", CountryOfOrigin = "US", CountryOfDestination = "BS", PortOfEntry = "SAQ", PortOfExit = "USPVS", Exporter = "Mennonite Messianic Mission", Importer = "Mennonite Messianic Mission", declarationCreatedDate = DateTime.Now, declarationSubmittedDate = DateTime.Now, TotalPackageQnty = 1, TotalPackageQntyUOM = "EA", TotalGrossMassMeasureQnty = 390, TotalGrossMassMeasureUOM = "LB", Submitted = true, Status = "Compliance", ManifestNumber = "MSTRNO30613", BOLnumber = "PEVMOB005095" },
                new Declaration { Id = Guid.NewGuid(), Regime = "4", DeclarationType = "400", ModeOfTransport = "1", DeclarationOffice = "SAQPDK", DeclarationNumber = "2022DEC0000845474", CountryOfOrigin = "US", CountryOfDestination = "BS", PortOfEntry = "SAQ", PortOfExit = "USPVS", Exporter = "Mennonite Messianic Mission", Importer = "Mennonite Messianic Mission", declarationCreatedDate = DateTime.Now, declarationSubmittedDate = DateTime.Now, TotalPackageQnty = 1, TotalPackageQntyUOM = "EA", TotalGrossMassMeasureQnty = 40, TotalGrossMassMeasureUOM = "LB", Submitted = true, Status = "Compliance", ManifestNumber = "MSTRNO30613", BOLnumber = "PEVMOB005096" }
            };
        }

        private List<Invoice> GetInvoices()
        {
            return new List<Invoice>
            {
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "814184793", VendorName = "ROADWAY TIRES", FreightValue = 0M, InsuranceValue = 150M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "2022ES7023", VendorName = "TPH", FreightValue = 0M, InsuranceValue = 0M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "2022ES8200", VendorName = "TPH", FreightValue = 0M, InsuranceValue = 0M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "11312272", VendorName = "MONTE PACKAGE", FreightValue = 75M, InsuranceValue = 150.23M }
            };
        }
        
        private List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item { Id = Guid.NewGuid(), DeclarationNumber = "2022DEC0000845484", InvoiceNumber = "814184793", Department = "MS", Quantity = 1, Description = "INNER TUBES", Value = 54.85M, Weight = 50, UomId = "EA", UomValue = 1, HsCode = 40131000, DutyGeneralRate = 0, DutyExciseRate = 45 },
                new Item { Id = Guid.NewGuid(), DeclarationNumber = "2022DEC0000845484", InvoiceNumber = "814184793", Department = "MS", Quantity = 1, Description = "TIRES, CAR", Value = 168.25M, Weight = 150, UomId = "EA", UomValue = 1, HsCode = 40111000, DutyGeneralRate = 0, DutyExciseRate = 25 },
                new Item { Id = Guid.NewGuid(), DeclarationNumber = "2022DEC0000845484", InvoiceNumber = "2022ES7023", Department = "MS", Quantity = 49, Description = "AUTO PARTS", Value = 691.78M, Weight = 100, UomId = "EA", UomValue = 49, HsCode = 87071010, DutyGeneralRate = 0, DutyExciseRate = 60 },
                new Item { Id = Guid.NewGuid(), DeclarationNumber = "2022DEC0000845484", InvoiceNumber = "2022ES7023", Department = "MS", Quantity = 5, Description = "AUTO PARTS", Value = 55.89M, Weight = 90, UomId = "EA", UomValue = 5, HsCode = 87071010, DutyGeneralRate = 0, DutyExciseRate = 60 },
                new Item { Id = Guid.NewGuid(), DeclarationNumber = "2022DEC0000845474", InvoiceNumber = "11312272", Department = "MF", Quantity = 4, Description = "ONION BAGS", Value = 528M, Weight = 40, UomId = "LB", UomValue = 40, HsCode = 39232990, DutyGeneralRate = 45, DutyExciseRate = 0 }
            };
        }
        #endregion
    }
}