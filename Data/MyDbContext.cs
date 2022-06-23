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
                new Vendor { Id = Guid.NewGuid(), Name = "WALPOLE FEED", AddressLine = "PO BOX 1723", CityName = "OKEECHOBEE", State = "FL", PostalCode = "34973", CountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), Name = "AGRIVET", AddressLine = "12029 W DOPHIN CT", CityName = "HOMOSASSA", State = "FL", PostalCode = "34448", CountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), Name = "ROADWAY TIRES", AddressLine = "1301 SW 2ND ST", CityName = "POMPANO BEACH", State = "FL", PostalCode = "33069", CountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), Name = "TPH", AddressLine = "2968 RAVENSWOOD ROAD", CityName = "FORT LAUDERDALE", State = "FL", PostalCode = "33312", CountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), Name = "MONTE PACKAGE", AddressLine = "4300 STEWART ROAD", CityName = "LAKELAND", State = "FL", PostalCode = "33815", CountryCode = "US" }
            };
        }

        private List<Declaration> GetDeclarations()
        {
            return new List<Declaration>
            {
                new Declaration { Id = Guid.NewGuid(), Regime = "4", Type = "400", ModeOfTransport = "1", DeclarationOffice = "SAQPDK", DeclarationNumber = "2022DEC0000845484", CountryOfOrigin = "US", CountryOfDestination = "BS", PortOfEntry = "SAQ", PortOfExit = "USPVS", Exporter = "Mennonite Messianic Mission", Importer = "Mennonite Messianic Mission", CreatedDate = DateTime.Now, SubmittedDate = DateTime.Now, TotalPackageQnty = 1, TotalPackageQntyUOM = "EA", TotalGrossMassMeasureQnty = 390, TotalGrossMassMeasureUOM = "LB", Submitted = true, Status = "Compliance", ManifestNumber = "MSTRNO30613", BOLnumber = "PEVMOB005095" },
                new Declaration { Id = Guid.NewGuid(), Regime = "4", Type = "400", ModeOfTransport = "1", DeclarationOffice = "SAQPDK", DeclarationNumber = "2022DEC0000845474", CountryOfOrigin = "US", CountryOfDestination = "BS", PortOfEntry = "SAQ", PortOfExit = "USPVS", Exporter = "Mennonite Messianic Mission", Importer = "Mennonite Messianic Mission", CreatedDate = DateTime.Now, SubmittedDate = DateTime.Now, TotalPackageQnty = 1, TotalPackageQntyUOM = "EA", TotalGrossMassMeasureQnty = 40, TotalGrossMassMeasureUOM = "LB", Submitted = true, Status = "Compliance", ManifestNumber = "MSTRNO30613", BOLnumber = "PEVMOB005096" }
            };
        }

        private List<Invoice> GetInvoices()
        {
            return new List<Invoice>
            {
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "814184793", FreightValue = 0M, InsuranceValue = 150M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "2022ES7023", FreightValue = 0M, InsuranceValue = 0M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "2022ES8200", FreightValue = 0M, InsuranceValue = 0M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "11312272", FreightValue = 75M, InsuranceValue = 150.23M }
            };
        }
        
        private List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item { Id = Guid.NewGuid(), Department = "MS", Quantity = 1, Description = "INNER TUBES", Value = 54.85M, Weight = 50, UomId = "EA", UomValue = 1, HsCode = 40131000, DutyGeneralRate = 0, DutyExciseRate = 45 },
                new Item { Id = Guid.NewGuid(), Department = "MS", Quantity = 1, Description = "TIRES, CAR", Value = 168.25M, Weight = 150, UomId = "EA", UomValue = 1, HsCode = 40111000, DutyGeneralRate = 0, DutyExciseRate = 25 },
                new Item { Id = Guid.NewGuid(), Department = "MS", Quantity = 49, Description = "AUTO PARTS", Value = 691.78M, Weight = 100, UomId = "EA", UomValue = 49, HsCode = 87071010, DutyGeneralRate = 0, DutyExciseRate = 60 },
                new Item { Id = Guid.NewGuid(), Department = "MS", Quantity = 5, Description = "AUTO PARTS", Value = 55.89M, Weight = 90, UomId = "EA", UomValue = 5, HsCode = 87071010, DutyGeneralRate = 0, DutyExciseRate = 60 },
                new Item { Id = Guid.NewGuid(), Department = "MF", Quantity = 4, Description = "ONION BAGS", Value = 528M, Weight = 40, UomId = "LB", UomValue = 40, HsCode = 39232990, DutyGeneralRate = 45, DutyExciseRate = 0 }
            };
        }
        #endregion
    }
}