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
                    table.PrimaryKey("PK_Declaration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AddressLine = table.Column<string>(type: "TEXT", nullable: false),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    CountryCode = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true)
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
                    VendorId = table.Column<Guid>(type: "TEXT", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Invoice_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    InvoiceId = table.Column<Guid>(type: "TEXT", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Item_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("7819b5af-e784-4723-927c-19084c303a1f"), "PEVMOB005095", "BS", "US", new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6512), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6514), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("8d513ba9-4ca0-405d-919b-ce2f704cd200"), "PEVMOB005096", "BS", "US", new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6522), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6524), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId" },
                values: new object[] { new Guid("23f60462-01b9-4559-bfec-fc2155a04aef"), new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6444), null, 0m, 150m, "814184793", null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId" },
                values: new object[] { new Guid("252d0531-b07d-4938-ab1b-c5f034abcccc"), new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6480), null, 0m, 0m, "2022ES8200", null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId" },
                values: new object[] { new Guid("4564c470-a4db-48e3-856b-406015c3e14a"), new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6486), null, 75m, 150.23m, "11312272", null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId" },
                values: new object[] { new Guid("e4251985-cd56-4bee-9fb1-b4b2e5144121"), new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6477), null, 0m, 0m, "2022ES7023", null });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("2c7f0583-2f23-4ba2-94a8-5a2d26bdc4bb"), "MF", "ONION BAGS", 0.0, 45.0, 39232990.0, null, 4.0, "LB", 40.0, 528m, 40.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("3ee5a0f5-ad95-465f-80bb-b469a2e5ead9"), "MS", "AUTO PARTS", 60.0, 0.0, 87071010.0, null, 49.0, "EA", 49.0, 691.78m, 100.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("ab2e8122-873c-4915-8338-c83da2148774"), "MS", "TIRES, CAR", 25.0, 0.0, 40111000.0, null, 1.0, "EA", 1.0, 168.25m, 150.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("cebd7bd1-ac68-41f0-a9bc-dc133f7d7136"), "MS", "AUTO PARTS", 60.0, 0.0, 87071010.0, null, 5.0, "EA", 5.0, 55.89m, 90.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("e1a87118-4d25-46a9-b90e-ac91c0710316"), "MS", "INNER TUBES", 45.0, 0.0, 40131000.0, null, 1.0, "EA", 1.0, 54.85m, 50.0 });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("30751ca9-40ab-4795-a58d-f54ca1a8af6e"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("464c2657-1240-41b7-b8b1-2588e7aa9617"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("701b17c1-80bb-46d2-9a49-acaf1adda5dc"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("870faad4-7943-4252-ab99-bf60a3081a5f"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("bdcac9c8-4c6d-425b-93a4-f0a0fa1b064c"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_DeclarationId",
                table: "Invoice",
                column: "DeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_VendorId",
                table: "Invoice",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_InvoiceId",
                table: "Item",
                column: "InvoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Declaration");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
