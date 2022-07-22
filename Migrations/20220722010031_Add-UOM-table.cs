using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class AddUOMtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("87b7ddbf-a251-4be1-a5a9-377e146c60eb"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("9acf7f32-04c3-4cb7-8962-c29734c635e2"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("9a1d53b5-91be-49b0-a044-614dd54d67c4"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("e294b9e5-a0bf-41de-9309-d45800045fa8"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("c2890cb7-2d7e-49bc-a264-98c9d131d245"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("e3c9bf8d-ea0b-4989-9c07-7c245c1e7857"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("fe286db0-f6f1-4be2-813d-07bd038229f6"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("55d539f6-dbc8-4593-85c2-8ff0ca063534"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("8c0fef9a-0245-4c9e-a040-fd6416e0b08f"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("8cc516a1-71a2-4949-9560-77477ef7634a"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("9c217470-65b3-4dc4-8ac5-0d83516b15ad"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("e5be07d3-9a3b-44cd-b91a-56a3aa4eadd5"));

            migrationBuilder.CreateTable(
                name: "UOM",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UOM", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("4dd69282-0465-4ee1-b087-fffa756df160"), "PEVMOB005095", "BS", "US", new DateTime(2022, 7, 21, 21, 0, 30, 720, DateTimeKind.Local).AddTicks(1288), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 21, 21, 0, 30, 720, DateTimeKind.Local).AddTicks(1339), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("daed851e-3df7-4c25-a05c-f8582f7bed66"), "PEVMOB005096", "BS", "US", new DateTime(2022, 7, 21, 21, 0, 30, 720, DateTimeKind.Local).AddTicks(1365), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 21, 21, 0, 30, 720, DateTimeKind.Local).AddTicks(1367), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "Email" },
                values: new object[] { new Guid("4ec0a4e0-3508-4ab7-83d0-cb4cf2a73c9e"), "MS", "mms.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "Email" },
                values: new object[] { new Guid("73092860-51f0-440d-b5c3-c499764b155c"), "MM", "mmf.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("20b831c2-0dd1-42e8-add4-ae797a8f6b14"), 0.0, 60.0, "CANDY", 17049010.0, "LB" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("673793ed-193c-499e-8ea3-5ad89b7bc6d2"), 0.0, 45.0, "BATTERIES", 85073000.0, "EA" });

            migrationBuilder.InsertData(
                table: "Tariff",
                columns: new[] { "Id", "ExciseRate", "GeneralRate", "Name", "Number", "UomId" },
                values: new object[] { new Guid("7f60510b-1644-4acf-953e-496903502330"), 0.0, 0.0, "APPLES", 8081000.0, "LB" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("0261a4a5-7c8a-43cc-adc8-e091a32f51d1"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("39f7a08c-afc6-4f3f-81ca-30170c320ad2"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("c9be805a-f03a-4ffe-a9c0-386de035d3a9"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("dde964d3-ab3b-42c1-b8ab-a9ef8c5972f0"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("e929ed53-70df-46cd-8899-d7a8f4135190"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UOM");

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("4dd69282-0465-4ee1-b087-fffa756df160"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("daed851e-3df7-4c25-a05c-f8582f7bed66"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("4ec0a4e0-3508-4ab7-83d0-cb4cf2a73c9e"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("73092860-51f0-440d-b5c3-c499764b155c"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("20b831c2-0dd1-42e8-add4-ae797a8f6b14"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("673793ed-193c-499e-8ea3-5ad89b7bc6d2"));

            migrationBuilder.DeleteData(
                table: "Tariff",
                keyColumn: "Id",
                keyValue: new Guid("7f60510b-1644-4acf-953e-496903502330"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("0261a4a5-7c8a-43cc-adc8-e091a32f51d1"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("39f7a08c-afc6-4f3f-81ca-30170c320ad2"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("c9be805a-f03a-4ffe-a9c0-386de035d3a9"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("dde964d3-ab3b-42c1-b8ab-a9ef8c5972f0"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("e929ed53-70df-46cd-8899-d7a8f4135190"));

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
        }
    }
}
