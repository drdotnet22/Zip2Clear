using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class Setvariousfieldstononnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Vendor_VendorId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Invoice_InvoiceId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Tariff_TariffId",
                table: "Item");

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
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("19a15921-7cc5-4546-b968-a261cea146ba"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("786a9bfb-5ef4-4179-9354-6e6fe7b2d393"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("bf1451f3-3eb1-4da3-8729-efa7ad26f3de"));

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

            migrationBuilder.AlterColumn<Guid>(
                name: "TariffId",
                table: "Item",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "InvoiceId",
                table: "Item",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "VendorId",
                table: "Invoice",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("a3c9a17e-ac66-4f4d-9a80-1743cb2d26fb"), "PEVMOB005095", "BS", "US", new DateTime(2022, 7, 20, 19, 19, 21, 540, DateTimeKind.Local).AddTicks(2620), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 20, 19, 19, 21, 540, DateTimeKind.Local).AddTicks(2652), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("d8d82402-c687-42cf-a86d-bd1ced19d4a0"), "PEVMOB005096", "BS", "US", new DateTime(2022, 7, 20, 19, 19, 21, 540, DateTimeKind.Local).AddTicks(2661), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 20, 19, 19, 21, 540, DateTimeKind.Local).AddTicks(2663), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("0a869e6f-f193-46d6-ad37-c116143c8296"), 0.0, 0.0, "APPLES", 8081000.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("6b28ebad-533a-446d-908b-c25a3c530d4a"), 0.0, 45.0, "BATTERIES", 85073000.0, "EA" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("a4c6cc9f-1308-4764-8135-3480f241a33a"), 0.0, 60.0, "CANDY", 17049010.0, "LB" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("0e06d6a1-74a8-40cb-b28e-b4af353a98bd"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("3cf4fb9c-68b8-459e-afc2-51401e921caf"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("9bf21336-27e3-4afa-ab79-6d9ef7f0c263"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("a49b4499-8cb1-43f9-9b80-69cbcab50665"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("eadf4ef7-fb33-473e-8354-65534f2b0dda"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Vendor_VendorId",
                table: "Invoice",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Invoice_InvoiceId",
                table: "Item",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Tariff_TariffId",
                table: "Item",
                column: "TariffId",
                principalTable: "Tariff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Vendor_VendorId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Invoice_InvoiceId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Tariff_TariffId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("a3c9a17e-ac66-4f4d-9a80-1743cb2d26fb"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("d8d82402-c687-42cf-a86d-bd1ced19d4a0"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("0a869e6f-f193-46d6-ad37-c116143c8296"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("6b28ebad-533a-446d-908b-c25a3c530d4a"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("a4c6cc9f-1308-4764-8135-3480f241a33a"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("0e06d6a1-74a8-40cb-b28e-b4af353a98bd"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("3cf4fb9c-68b8-459e-afc2-51401e921caf"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("9bf21336-27e3-4afa-ab79-6d9ef7f0c263"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("a49b4499-8cb1-43f9-9b80-69cbcab50665"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("eadf4ef7-fb33-473e-8354-65534f2b0dda"));

            migrationBuilder.AlterColumn<Guid>(
                name: "TariffId",
                table: "Item",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "InvoiceId",
                table: "Item",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "VendorId",
                table: "Invoice",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

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
                name: "FK_Invoice_Vendor_VendorId",
                table: "Invoice",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Invoice_InvoiceId",
                table: "Item",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Tariff_TariffId",
                table: "Item",
                column: "TariffId",
                principalTable: "Tariff",
                principalColumn: "Id");
        }
    }
}
