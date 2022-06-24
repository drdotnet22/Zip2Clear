using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class SecondInitialCommit : Migration
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
                    VendorName = table.Column<string>(type: "TEXT", nullable: true),
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
                values: new object[] { new Guid("e1f04f61-2e77-4af5-8e93-58648bbdf948"), "PEVMOB005095", "BS", "US", new DateTime(2022, 6, 23, 21, 26, 53, 801, DateTimeKind.Local).AddTicks(7329), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 6, 23, 21, 26, 53, 801, DateTimeKind.Local).AddTicks(7331), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("ea0b2207-1f04-471f-8820-f85c8fb84f21"), "PEVMOB005096", "BS", "US", new DateTime(2022, 6, 23, 21, 26, 53, 801, DateTimeKind.Local).AddTicks(7339), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 6, 23, 21, 26, 53, 801, DateTimeKind.Local).AddTicks(7341), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId", "VendorName" },
                values: new object[] { new Guid("4cd50d48-c4cc-4186-9953-635cba807ce1"), new DateTime(2022, 6, 23, 21, 26, 53, 801, DateTimeKind.Local).AddTicks(7301), null, 75m, 150.23m, "11312272", null, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId", "VendorName" },
                values: new object[] { new Guid("7dd22063-0369-4d1d-8a2b-dbf4f3caebf9"), new DateTime(2022, 6, 23, 21, 26, 53, 801, DateTimeKind.Local).AddTicks(7298), null, 0m, 0m, "2022ES8200", null, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId", "VendorName" },
                values: new object[] { new Guid("885230a2-c169-441c-befa-60b745b60a98"), new DateTime(2022, 6, 23, 21, 26, 53, 801, DateTimeKind.Local).AddTicks(7295), null, 0m, 0m, "2022ES7023", null, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId", "VendorName" },
                values: new object[] { new Guid("d49d206d-0ea7-458f-a4c8-9e7d16150631"), new DateTime(2022, 6, 23, 21, 26, 53, 801, DateTimeKind.Local).AddTicks(7253), null, 0m, 150m, "814184793", null, null });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("9bbad374-0c6e-4799-a67d-c86d1ad38c2e"), "MS", "INNER TUBES", 45.0, 0.0, 40131000.0, null, 1.0, "EA", 1.0, 54.85m, 50.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("b2e3427a-1408-4614-accf-4fc2ff318ce2"), "MS", "TIRES, CAR", 25.0, 0.0, 40111000.0, null, 1.0, "EA", 1.0, 168.25m, 150.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("d8fab7dd-1ea9-4614-8928-65e317d55ef3"), "MS", "AUTO PARTS", 60.0, 0.0, 87071010.0, null, 49.0, "EA", 49.0, 691.78m, 100.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("df5ed718-6357-4397-bc98-bd4c6e800c52"), "MS", "AUTO PARTS", 60.0, 0.0, 87071010.0, null, 5.0, "EA", 5.0, 55.89m, 90.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Department", "Description", "DutyExciseRate", "DutyGeneralRate", "HsCode", "InvoiceId", "Quantity", "UomId", "UomValue", "Value", "Weight" },
                values: new object[] { new Guid("f85203d5-f3b4-49cf-b40f-ba23147c524f"), "MF", "ONION BAGS", 0.0, 45.0, 39232990.0, null, 4.0, "LB", 40.0, 528m, 40.0 });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("0d6684d1-ce66-4420-9407-7788037836b9"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("6f526cd3-7059-422d-b742-0acb482f29b2"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("7e85c15f-fc51-44e3-ab40-6b2572fa1774"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("b0fdc745-b051-4131-b4d3-7fcd0abc6721"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("ed8e436c-19f0-4dc6-9413-a4149b876ba4"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

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
