using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class Correctedspellingoftariff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Tarriff_TarriffId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Tarriff");

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("1ed9e6fe-d401-43d2-8667-a88088a6fa17"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("5bf0fe48-b859-4316-b58d-d0ccf2737ecb"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("a2f7691c-4af5-4067-9f65-c4b0bbc6a046"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("bceaebaa-21f8-4770-b695-143946c6ebd6"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("c9563ad0-becf-4119-9f5e-7e2651094fce"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("dfb7b0a7-f79c-44bc-b282-9cdb05e0797f"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("452d9c1a-c07c-4ed3-9bcd-1e68e225ee4d"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("46637b43-42a7-4897-af32-89b916c10418"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("621929c9-cafd-4612-8f16-8f25cbcf0f74"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("77654d09-c6c1-4ed7-8790-4aff0383e7ab"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("9124659f-ac6a-497f-a4f2-e637eec498dc"));

            migrationBuilder.RenameColumn(
                name: "TarriffId",
                table: "Item",
                newName: "TariffId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_TarriffId",
                table: "Item",
                newName: "IX_Item_TariffId");

            migrationBuilder.RenameColumn(
                name: "InvoiceNumber",
                table: "Invoice",
                newName: "Number");

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

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("3983d3c3-99e1-47a3-9fb7-54c774419fa1"), "PEVMOB005095", "BS", "US", new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2140), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2142), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("ea677e3d-83f1-40be-ad3d-3cc74fbe9661"), "PEVMOB005096", "BS", "US", new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2149), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2151), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "Insurance", "Number", "Shipping", "VendorId" },
                values: new object[] { new Guid("33f61c5d-1253-4b99-9164-0e6818009de8"), new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2112), null, 0m, "2022ES8200", 0m, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "Insurance", "Number", "Shipping", "VendorId" },
                values: new object[] { new Guid("b283daf1-25b8-4228-aa30-93a799d07197"), new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2109), null, 0m, "2022ES7023", 0m, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "Insurance", "Number", "Shipping", "VendorId" },
                values: new object[] { new Guid("e7c2b6d3-d1f8-42b0-9235-5b1c0e1065d1"), new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2115), null, 150.23m, "11312272", 75m, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "Insurance", "Number", "Shipping", "VendorId" },
                values: new object[] { new Guid("f2d2e766-8352-4a23-9876-e71eaa1f2229"), new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2072), null, 150m, "814184793", 0m, null });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("19a15921-7cc5-4546-b968-a261cea146ba"), 0.0, 0.0, "APPLES", 8081000.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("786a9bfb-5ef4-4179-9354-6e6fe7b2d393"), 0.0, 60.0, "CANDY", 17049010.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("bf1451f3-3eb1-4da3-8729-efa7ad26f3de"), 0.0, 45.0, "BATTERIES", 85073000.0, "EA" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("9f8eef22-69ea-4ff6-8cc1-593a6d0cdcf8"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("a30c6807-4b99-49f8-89e3-725a0c9f9584"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("ae6f22f8-8f1e-43bc-8244-181101960c12"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("b694db7d-a142-44ac-b6e9-bfdc8bbed0f4"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("e392b12b-8c64-40c3-8dc8-7ff8e7ddcf64"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Tariff_TariffId",
                table: "Item",
                column: "TariffId",
                principalTable: "Tariff",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Tariff_TariffId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Tariff");

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("3983d3c3-99e1-47a3-9fb7-54c774419fa1"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("ea677e3d-83f1-40be-ad3d-3cc74fbe9661"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("33f61c5d-1253-4b99-9164-0e6818009de8"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("b283daf1-25b8-4228-aa30-93a799d07197"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("e7c2b6d3-d1f8-42b0-9235-5b1c0e1065d1"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("f2d2e766-8352-4a23-9876-e71eaa1f2229"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("9f8eef22-69ea-4ff6-8cc1-593a6d0cdcf8"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("a30c6807-4b99-49f8-89e3-725a0c9f9584"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("ae6f22f8-8f1e-43bc-8244-181101960c12"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("b694db7d-a142-44ac-b6e9-bfdc8bbed0f4"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("e392b12b-8c64-40c3-8dc8-7ff8e7ddcf64"));

            migrationBuilder.RenameColumn(
                name: "TariffId",
                table: "Item",
                newName: "TarriffId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_TariffId",
                table: "Item",
                newName: "IX_Item_TarriffId");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Invoice",
                newName: "InvoiceNumber");

            migrationBuilder.CreateTable(
                name: "Tarriff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExciseRate = table.Column<double>(type: "REAL", nullable: false),
                    GeneralRate = table.Column<double>(type: "REAL", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Number = table.Column<double>(type: "REAL", nullable: false),
                    UomId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarriff", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("1ed9e6fe-d401-43d2-8667-a88088a6fa17"), "PEVMOB005096", "BS", "US", new DateTime(2022, 6, 25, 18, 17, 29, 337, DateTimeKind.Local).AddTicks(407), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 6, 25, 18, 17, 29, 337, DateTimeKind.Local).AddTicks(409), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("5bf0fe48-b859-4316-b58d-d0ccf2737ecb"), "PEVMOB005095", "BS", "US", new DateTime(2022, 6, 25, 18, 17, 29, 337, DateTimeKind.Local).AddTicks(368), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 6, 25, 18, 17, 29, 337, DateTimeKind.Local).AddTicks(370), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "Insurance", "InvoiceNumber", "Shipping", "VendorId" },
                values: new object[] { new Guid("a2f7691c-4af5-4067-9f65-c4b0bbc6a046"), new DateTime(2022, 6, 25, 18, 17, 29, 337, DateTimeKind.Local).AddTicks(331), null, 0m, "2022ES7023", 0m, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "Insurance", "InvoiceNumber", "Shipping", "VendorId" },
                values: new object[] { new Guid("bceaebaa-21f8-4770-b695-143946c6ebd6"), new DateTime(2022, 6, 25, 18, 17, 29, 337, DateTimeKind.Local).AddTicks(292), null, 150m, "814184793", 0m, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "Insurance", "InvoiceNumber", "Shipping", "VendorId" },
                values: new object[] { new Guid("c9563ad0-becf-4119-9f5e-7e2651094fce"), new DateTime(2022, 6, 25, 18, 17, 29, 337, DateTimeKind.Local).AddTicks(334), null, 0m, "2022ES8200", 0m, null });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Date", "DeclarationId", "Insurance", "InvoiceNumber", "Shipping", "VendorId" },
                values: new object[] { new Guid("dfb7b0a7-f79c-44bc-b282-9cdb05e0797f"), new DateTime(2022, 6, 25, 18, 17, 29, 337, DateTimeKind.Local).AddTicks(341), null, 150.23m, "11312272", 75m, null });

            migrationBuilder.InsertData(
                table: "Tarriff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("6cba619c-f555-421a-bbb2-5794844abdb2"), 0.0, 60.0, "CANDY", 17049010.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tarriff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("75f37593-ef69-4bea-be0f-bb5bede0c20f"), 0.0, 45.0, "BATTERIES", 85073000.0, "EA" });

            migrationBuilder.InsertData(
                table: "Tarriff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("7eaf8d29-1fc7-45c0-bedf-06a186f6a785"), 0.0, 0.0, "APPLES", 8081000.0, "LB" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("452d9c1a-c07c-4ed3-9bcd-1e68e225ee4d"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("46637b43-42a7-4897-af32-89b916c10418"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("621929c9-cafd-4612-8f16-8f25cbcf0f74"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("77654d09-c6c1-4ed7-8790-4aff0383e7ab"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("9124659f-ac6a-497f-a4f2-e637eec498dc"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Tarriff_TarriffId",
                table: "Item",
                column: "TarriffId",
                principalTable: "Tarriff",
                principalColumn: "Id");
        }
    }
}
