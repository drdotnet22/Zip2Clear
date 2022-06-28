using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class Initial : Migration
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
                name: "Tarriff",
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
                    table.PrimaryKey("PK_Tarriff", x => x.Id);
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
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: true),
                    UomValue = table.Column<double>(type: "REAL", nullable: true),
                    TarriffId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Tarriff_TarriffId",
                        column: x => x.TarriffId,
                        principalTable: "Tarriff",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("7ab485e6-c9ab-4034-928b-9cbffb3b55c0"), "PEVMOB005096", "BS", "US", new DateTime(2022, 6, 25, 16, 39, 14, 797, DateTimeKind.Local).AddTicks(5680), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 6, 25, 16, 39, 14, 797, DateTimeKind.Local).AddTicks(5682), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("c7c3d1ce-08bb-4868-8667-df5a08ea9f3d"), "PEVMOB005095", "BS", "US", new DateTime(2022, 6, 25, 16, 39, 14, 797, DateTimeKind.Local).AddTicks(5670), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 6, 25, 16, 39, 14, 797, DateTimeKind.Local).AddTicks(5673), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId" },
                values: new object[] { new Guid("1005a639-0642-4900-8c4e-393469b0fc89"), new DateTime(2022, 6, 25, 16, 39, 14, 797, DateTimeKind.Local).AddTicks(5640), null, 0m, 0m, "2022ES7023", null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId" },
                values: new object[] { new Guid("1673f280-3349-4d7f-9b34-b5ade2d82e65"), new DateTime(2022, 6, 25, 16, 39, 14, 797, DateTimeKind.Local).AddTicks(5646), null, 75m, 150.23m, "11312272", null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId" },
                values: new object[] { new Guid("5a94f2ec-0162-4021-8623-f6a4b4b9ebe0"), new DateTime(2022, 6, 25, 16, 39, 14, 797, DateTimeKind.Local).AddTicks(5602), null, 0m, 150m, "814184793", null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "FreightValue", "InsuranceValue", "InvoiceNumber", "VendorId" },
                values: new object[] { new Guid("eeefd359-e822-4087-a463-29e8d375ab45"), new DateTime(2022, 6, 25, 16, 39, 14, 797, DateTimeKind.Local).AddTicks(5643), null, 0m, 0m, "2022ES8200", null });

            migrationBuilder.InsertData(
                table: "Tarriff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("02fea001-96e2-42cf-84a2-2d322b43bfc2"), 0.0, 0.0, "APPLES", 8081000.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tarriff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("0a113110-72da-44f0-afff-12459976dfed"), 0.0, 60.0, "CANDY", 17049010.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tarriff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("4d93a435-4e0c-4600-af25-6409b6bbbd90"), 0.0, 45.0, "BATTERIES", 85073000.0, "EA" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("071b939c-de4a-454e-bebc-ccab1dce8fe4"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("24b12be4-a2ac-434d-8d15-5c237556a33f"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("90d7c762-c880-4fc5-9eb8-eee4ee67ce1f"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("a0fd6bbd-dab5-4596-829b-8b74f10a35ef"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("f4b38c6f-f696-4889-83e9-08e8525eab88"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

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
                name: "IX_Item_TarriffId",
                table: "Item",
                column: "TarriffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Tarriff");

            migrationBuilder.DropTable(
                name: "Declaration");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
