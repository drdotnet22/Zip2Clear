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
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tariff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Number = table.Column<double>(type: "REAL", nullable: false),
                    UomId = table.Column<string>(type: "TEXT", nullable: false),
                    GeneralRate = table.Column<double>(type: "REAL", nullable: false),
                    ExciseRate = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tariff", x => x.Id);
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
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    VendorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Shipping = table.Column<decimal>(type: "TEXT", nullable: false),
                    Insurance = table.Column<decimal>(type: "TEXT", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    InvoiceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<double>(type: "REAL", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: true),
                    UomValue = table.Column<double>(type: "REAL", nullable: true),
                    TariffId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_Tariff_TariffId",
                        column: x => x.TariffId,
                        principalTable: "Tariff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("87b7ddbf-a251-4be1-a5a9-377e146c60eb"), "PEVMOB005096", "BS", "US", new DateTime(2022, 7, 21, 20, 52, 8, 0, DateTimeKind.Local).AddTicks(1237), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 21, 20, 52, 8, 0, DateTimeKind.Local).AddTicks(1239), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("9acf7f32-04c3-4cb7-8962-c29734c635e2"), "PEVMOB005095", "BS", "US", new DateTime(2022, 7, 21, 20, 52, 8, 0, DateTimeKind.Local).AddTicks(1169), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 21, 20, 52, 8, 0, DateTimeKind.Local).AddTicks(1212), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "Email" },
                values: new object[] { new Guid("9a1d53b5-91be-49b0-a044-614dd54d67c4"), "MS", "mms.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "Email" },
                values: new object[] { new Guid("e294b9e5-a0bf-41de-9309-d45800045fa8"), "MM", "mmf.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("c2890cb7-2d7e-49bc-a264-98c9d131d245"), 0.0, 60.0, "CANDY", 17049010.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("e3c9bf8d-ea0b-4989-9c07-7c245c1e7857"), 0.0, 45.0, "BATTERIES", 85073000.0, "EA" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("fe286db0-f6f1-4be2-813d-07bd038229f6"), 0.0, 0.0, "APPLES", 8081000.0, "LB" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("55d539f6-dbc8-4593-85c2-8ff0ca063534"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("8c0fef9a-0245-4c9e-a040-fd6416e0b08f"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("8cc516a1-71a2-4949-9560-77477ef7634a"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("9c217470-65b3-4dc4-8ac5-0d83516b15ad"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("e5be07d3-9a3b-44cd-b91a-56a3aa4eadd5"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Item_TariffId",
                table: "Item",
                column: "TariffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Tariff");

            migrationBuilder.DropTable(
                name: "Declaration");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
