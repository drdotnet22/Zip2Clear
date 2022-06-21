using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Declaration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Submitted = table.Column<bool>(type: "INTEGER", nullable: false),
                    declarationCreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    declarationSubmittedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ManifestNumber = table.Column<string>(type: "TEXT", nullable: true),
                    BOLnumber = table.Column<string>(type: "TEXT", nullable: true),
                    DeclarationNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DeclarationType = table.Column<string>(type: "TEXT", nullable: false),
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
                    table.PrimaryKey("PK_Declaration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeclarationNumber = table.Column<string>(type: "TEXT", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: true),
                    UomId = table.Column<string>(type: "TEXT", nullable: false),
                    UomValue = table.Column<double>(type: "REAL", nullable: false),
                    HsCode = table.Column<double>(type: "REAL", nullable: false),
                    DutyGeneralRate = table.Column<double>(type: "REAL", nullable: false),
                    DutyExciseRate = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    VendorName = table.Column<string>(type: "TEXT", nullable: false),
                    VendorAddressLine = table.Column<string>(type: "TEXT", nullable: false),
                    VendorCityName = table.Column<string>(type: "TEXT", nullable: true),
                    VendorState = table.Column<string>(type: "TEXT", nullable: true),
                    VendorCountryCode = table.Column<string>(type: "TEXT", nullable: false),
                    VendorPostalCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeclarationId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "TEXT", nullable: false),
                    VendorName = table.Column<string>(type: "TEXT", nullable: false),
                    FreightValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    InsuranceValue = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Declaration_DeclarationId",
                        column: x => x.DeclarationId,
                        principalTable: "Declaration",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "DeclarationNumber", "DeclarationOffice", "DeclarationType", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "declarationCreatedDate", "declarationSubmittedDate" },
                values: new object[] { new Guid("6f22cfa1-bf4d-48f9-bda8-42710d89adbc"), "PEVMOB005096", "BS", "US", "2022DEC0000845474", "SAQPDK", "400", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, 40.0, "LB", 1.0, "EA", new DateTime(2022, 6, 20, 20, 33, 8, 535, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 6, 20, 20, 33, 8, 535, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "DeclarationNumber", "DeclarationOffice", "DeclarationType", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "declarationCreatedDate", "declarationSubmittedDate" },
                values: new object[] { new Guid("acf54c51-301a-4c5e-844d-0e95d64f621b"), "PEVMOB005095", "BS", "US", "2022DEC0000845484", "SAQPDK", "400", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, 390.0, "LB", 1.0, "EA", new DateTime(2022, 6, 20, 20, 33, 8, 535, DateTimeKind.Local).AddTicks(4634), new DateTime(2022, 6, 20, 20, 33, 8, 535, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorName" },
                values: new object[] { new Guid("04a28fd9-24a5-4d44-8ac3-7e905ca43a3b"), new DateTime(2022, 6, 20, 20, 33, 8, 535, DateTimeKind.Local).AddTicks(4565), null, 0m, 150m, "814184793", "ROADWAY TIRES" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorName" },
                values: new object[] { new Guid("4e720259-6fa1-4f9b-8185-f2c2d45cb07e"), new DateTime(2022, 6, 20, 20, 33, 8, 535, DateTimeKind.Local).AddTicks(4602), null, 0m, 0m, "2022ES7023", "TPH" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorName" },
                values: new object[] { new Guid("52fc13eb-dbd0-4527-94f6-323312a6a6b9"), new DateTime(2022, 6, 20, 20, 33, 8, 535, DateTimeKind.Local).AddTicks(4608), null, 75m, 150.23m, "11312272", "MONTE PACKAGE" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorName" },
                values: new object[] { new Guid("ee5b6589-5bd6-4c70-89ee-3e2fa6250247"), new DateTime(2022, 6, 20, 20, 33, 8, 535, DateTimeKind.Local).AddTicks(4605), null, 0m, 0m, "2022ES8200", "TPH" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "DeclarationNumber", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceNumber", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("740c615e-3b9f-4ac1-b64f-cf24b718614a"), "2022DEC0000845474", "MF", "ONION BAGS", 0.0, 45.0, 39232990.0, "11312272", 4.0, "LB", 40.0, 528m, 40.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "DeclarationNumber", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceNumber", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("76c63bd2-d1d7-42dd-ad79-d5c84b59ddf9"), "2022DEC0000845484", "MS", "INNER TUBES", 45.0, 0.0, 40131000.0, "814184793", 1.0, "EA", 1.0, 54.85m, 50.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "DeclarationNumber", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceNumber", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("8d152256-3c92-4729-ae4b-3b0924ab9b4e"), "2022DEC0000845484", "MS", "TIRES, CAR", 25.0, 0.0, 40111000.0, "814184793", 1.0, "EA", 1.0, 168.25m, 150.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "DeclarationNumber", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceNumber", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("b3422b77-2153-4c6b-a674-2adcd5127e91"), "2022DEC0000845484", "MS", "AUTO PARTS", 60.0, 0.0, 87071010.0, "2022ES7023", 5.0, "EA", 5.0, 55.89m, 90.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "DeclarationNumber", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceNumber", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("cd5c8038-4190-4d58-9528-10c83491ac65"), "2022DEC0000845484", "MS", "AUTO PARTS", 60.0, 0.0, 87071010.0, "2022ES7023", 49.0, "EA", 49.0, 691.78m, 100.0 });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "VendorAddressLine", "VendorCityName", "VendorCountryCode", "VendorName", "VendorPostalCode", "VendorState" },
                values: new object[] { new Guid("1c17049c-923a-46da-bdbb-cdefe7ff5d94"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "VendorAddressLine", "VendorCityName", "VendorCountryCode", "VendorName", "VendorPostalCode", "VendorState" },
                values: new object[] { new Guid("20cafe55-7730-4844-b66c-d24259565c22"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "VendorAddressLine", "VendorCityName", "VendorCountryCode", "VendorName", "VendorPostalCode", "VendorState" },
                values: new object[] { new Guid("40072443-0a76-4dde-95a5-56401a200f67"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "VendorAddressLine", "VendorCityName", "VendorCountryCode", "VendorName", "VendorPostalCode", "VendorState" },
                values: new object[] { new Guid("806a84bd-80ab-40f2-8166-a8e760e3bf33"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "VendorAddressLine", "VendorCityName", "VendorCountryCode", "VendorName", "VendorPostalCode", "VendorState" },
                values: new object[] { new Guid("ab4020ed-e260-46c0-9837-b43bf1a367eb"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_DeclarationId",
                table: "Invoice",
                column: "DeclarationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Declaration");
        }
    }
}
