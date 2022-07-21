using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class RestructureDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Departments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("055ecea5-d0eb-467e-a18b-96e525eb743b"), "PEVMOB005096", "BS", "US", new DateTime(2022, 7, 20, 19, 31, 11, 650, DateTimeKind.Local).AddTicks(1216), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 20, 19, 31, 11, 650, DateTimeKind.Local).AddTicks(1218), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("c2589d0b-936a-419b-b5df-26843ead2c93"), "PEVMOB005095", "BS", "US", new DateTime(2022, 7, 20, 19, 31, 11, 650, DateTimeKind.Local).AddTicks(1169), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 20, 19, 31, 11, 650, DateTimeKind.Local).AddTicks(1198), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Code", "Email" },
                values: new object[] { new Guid("1da4542c-3573-47d5-b956-a11272226ded"), "MS", "mms.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Code", "Email" },
                values: new object[] { new Guid("ec3c0bb0-5660-4c1a-8581-3e81fb087040"), "MM", "mmf.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("2943c7f9-29f4-4cec-af8f-e7690b2f59b5"), 0.0, 0.0, "APPLES", 8081000.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("519a3492-24c5-4618-94a3-34ab3c5dcb41"), 0.0, 45.0, "BATTERIES", 85073000.0, "EA" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("638041d3-27a5-4ed5-bfc3-8481adb40b2a"), 0.0, 60.0, "CANDY", 17049010.0, "LB" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("2d15bd39-4b22-4e33-8274-936c98f36ad1"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("42a0df5c-8f1c-4ce4-8e55-56c2df4784c9"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("66995f32-8351-4566-91d7-e8f611d1eaae"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("869eb138-2241-444d-8785-a6ddcb8316ec"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("e1178c03-6f0c-4cde-ab9e-79e4ea0176c7"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("055ecea5-d0eb-467e-a18b-96e525eb743b"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("c2589d0b-936a-419b-b5df-26843ead2c93"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1da4542c-3573-47d5-b956-a11272226ded"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ec3c0bb0-5660-4c1a-8581-3e81fb087040"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("2943c7f9-29f4-4cec-af8f-e7690b2f59b5"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("519a3492-24c5-4618-94a3-34ab3c5dcb41"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("638041d3-27a5-4ed5-bfc3-8481adb40b2a"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("2d15bd39-4b22-4e33-8274-936c98f36ad1"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("42a0df5c-8f1c-4ce4-8e55-56c2df4784c9"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("66995f32-8351-4566-91d7-e8f611d1eaae"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("869eb138-2241-444d-8785-a6ddcb8316ec"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("e1178c03-6f0c-4cde-ab9e-79e4ea0176c7"));

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Departments");

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
        }
    }
}
