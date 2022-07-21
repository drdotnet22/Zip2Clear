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
        public DbSet<Tariff> Tariff { get; set; }
        public DbSet<Department> Departments { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>().HasData(GetVendors());
            modelBuilder.Entity<Declaration>().HasData(GetDeclarations());
            modelBuilder.Entity<Tariff>().HasData(GetTariffs());
            modelBuilder.Entity<Department>().HasData(GetDepartments());
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

        private List<Tariff> GetTariffs()
        {
            return new List<Tariff>
            {
                new Tariff { Id = Guid.NewGuid(), Name = "APPLES", Number = 08081000, UomId = "LB", GeneralRate = 0, ExciseRate = 0 },
                new Tariff { Id = Guid.NewGuid(), Name = "BATTERIES", Number = 85073000, UomId = "EA", GeneralRate = 45, ExciseRate = 0 },
                new Tariff { Id = Guid.NewGuid(), Name = "CANDY", Number = 17049010, UomId = "LB", GeneralRate = 60, ExciseRate = 0 }
            };
        }

        private List<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department { Id = Guid.NewGuid(), Code = "MM", Email = "mmf.lr@emypeople.net" },
                new Department { Id = Guid.NewGuid(), Code = "MS", Email = "mms.lr@emypeople.net" }
            };
        }
        #endregion
    }
}