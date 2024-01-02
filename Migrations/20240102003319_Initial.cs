using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Zip2Clear.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Declaration",
                columns: table => new
                {
                    DeclarationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Submitted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ManifestNumber = table.Column<string>(type: "TEXT", nullable: true),
                    BOLnumber = table.Column<string>(type: "TEXT", nullable: true),
                    DeclarationNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Regime = table.Column<string>(type: "TEXT", nullable: false),
                    DeclarationOffice = table.Column<string>(type: "TEXT", nullable: false),
                    PortOfEntry = table.Column<string>(type: "TEXT", nullable: false),
                    PortOfExit = table.Column<string>(type: "TEXT", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "TEXT", nullable: false),
                    ModeOfTransport = table.Column<string>(type: "TEXT", nullable: false),
                    CountryOfDestination = table.Column<string>(type: "TEXT", nullable: false),
                    TotalGrossMassMeasureQnty = table.Column<double>(type: "REAL", nullable: false),
                    TotalGrossMassMeasureUOM = table.Column<string>(type: "TEXT", nullable: false),
                    TotalPackageQnty = table.Column<double>(type: "REAL", nullable: false),
                    TotalPackageQntyUOM = table.Column<string>(type: "TEXT", nullable: false),
                    Importer = table.Column<string>(type: "TEXT", nullable: false),
                    Exporter = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Declaration", x => x.DeclarationId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Uom",
                columns: table => new
                {
                    UomId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uom", x => x.UomId);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AddressLine = table.Column<string>(type: "TEXT", nullable: false),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    CountryCode = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "Tariff",
                columns: table => new
                {
                    TariffId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    GeneralRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    ExciseRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    EnvironmentalLevy = table.Column<decimal>(type: "TEXT", nullable: false),
                    UomId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tariff", x => x.TariffId);
                    table.ForeignKey(
                        name: "FK_Tariff_Uom_UomId",
                        column: x => x.UomId,
                        principalTable: "Uom",
                        principalColumn: "UomId");
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeclarationId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    VendorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Shipping = table.Column<decimal>(type: "TEXT", nullable: false),
                    Insurance = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoice_Declaration_DeclarationId",
                        column: x => x.DeclarationId,
                        principalTable: "Declaration",
                        principalColumn: "DeclarationId");
                    table.ForeignKey(
                        name: "FK_Invoice_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InvoiceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Quantity = table.Column<double>(type: "REAL", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: true),
                    UomValue = table.Column<double>(type: "REAL", nullable: true),
                    TariffId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TariffCode = table.Column<string>(type: "TEXT", nullable: false),
                    TariffGeneralRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    TariffExciseRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    EnvironmentalLevy = table.Column<decimal>(type: "TEXT", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId");
                    table.ForeignKey(
                        name: "FK_Item_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_Tariff_TariffId",
                        column: x => x.TariffId,
                        principalTable: "Tariff",
                        principalColumn: "TariffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "DeclarationId", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[,]
                {
                    { new Guid("41b254a2-b09f-4012-a467-e1b9ad2e3d17"), "PEVMOB005095", "BS", "US", new DateTime(2024, 1, 1, 19, 33, 19, 102, DateTimeKind.Local).AddTicks(1941), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2024, 1, 1, 19, 33, 19, 102, DateTimeKind.Local).AddTicks(1990), 390.0, "LB", 1.0, "EA", "400" },
                    { new Guid("b0db578f-b858-48f6-8b40-de0b26c0baa2"), "PEVMOB005096", "BS", "US", new DateTime(2024, 1, 1, 19, 33, 19, 102, DateTimeKind.Local).AddTicks(1998), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2024, 1, 1, 19, 33, 19, 102, DateTimeKind.Local).AddTicks(2000), 40.0, "LB", 1.0, "EA", "400" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Code", "Email", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("19904b65-4819-4254-8878-95cea9b0fe84"), "MM", "mmf.lr@emypeople.net", true, "Mennonite Mission" },
                    { new Guid("553ba773-8996-40cb-9df8-e4b4f893a46c"), "MS", "mms.lr@emypeople.net", true, "Mechanic Shop" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[,]
                {
                    { new Guid("6e294201-0187-4aea-bc8b-3f63a7758806"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" },
                    { new Guid("7363e105-0bcd-4e89-9fb6-f125f2045479"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" },
                    { new Guid("75114055-ec83-4765-aa48-168b7c3d1c70"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" },
                    { new Guid("754f58fa-cc4c-4951-897f-f068462a2b2c"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" },
                    { new Guid("eed01065-5c18-4691-bea2-c0c31176eef7"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_DeclarationId",
                table: "Invoice",
                column: "DeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_VendorId",
                table: "Invoice",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_DepartmentId",
                table: "Item",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_InvoiceId",
                table: "Item",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TariffId",
                table: "Item",
                column: "TariffId");

            migrationBuilder.CreateIndex(
                name: "IX_Tariff_UomId",
                table: "Tariff",
                column: "UomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Tariff");

            migrationBuilder.DropTable(
                name: "Declaration");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Uom");
        }
    }
}
