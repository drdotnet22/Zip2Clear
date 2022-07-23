using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class addeduomreferenceintariff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Item",
                newName: "DepartmentId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UomId",
                table: "Tariff",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("31958655-f36f-4139-bc5a-5e5bd41a83c7"), "PEVMOB005096", "BS", "US", new DateTime(2022, 7, 23, 17, 57, 48, 58, DateTimeKind.Local).AddTicks(1576), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 23, 17, 57, 48, 58, DateTimeKind.Local).AddTicks(1578), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "Id", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("67685d53-8a52-400e-8753-5c260ec4ee77"), "PEVMOB005095", "BS", "US", new DateTime(2022, 7, 23, 17, 57, 48, 58, DateTimeKind.Local).AddTicks(1540), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 23, 17, 57, 48, 58, DateTimeKind.Local).AddTicks(1569), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "Email" },
                values: new object[] { new Guid("40f705a2-2ab6-4da3-a493-6db983a9d682"), "MM", "mmf.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "Email" },
                values: new object[] { new Guid("b55d8f04-095e-4b77-b10b-a81a941b6d66"), "MS", "mms.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("0069d576-fd87-47ae-9dfa-95611bff878f"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("1bb4e6bb-a23c-46c4-932c-8a9d48239db3"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("991d13aa-26ab-47c6-b83f-6e466647cce7"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("abac31c0-f9f6-4449-98ac-3521e9ab8b4e"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("cd2c3e61-2052-4cc0-84a0-0c4c7e0312ab"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.CreateIndex(
                name: "IX_Tariff_UomId",
                table: "Tariff",
                column: "UomId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_DepartmentId",
                table: "Item",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Department_DepartmentId",
                table: "Item",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tariff_UOM_UomId",
                table: "Tariff",
                column: "UomId",
                principalTable: "UOM",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Department_DepartmentId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Tariff_UOM_UomId",
                table: "Tariff");

            migrationBuilder.DropIndex(
                name: "IX_Tariff_UomId",
                table: "Tariff");

            migrationBuilder.DropIndex(
                name: "IX_Item_DepartmentId",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("31958655-f36f-4139-bc5a-5e5bd41a83c7"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("67685d53-8a52-400e-8753-5c260ec4ee77"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("40f705a2-2ab6-4da3-a493-6db983a9d682"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("b55d8f04-095e-4b77-b10b-a81a941b6d66"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("0069d576-fd87-47ae-9dfa-95611bff878f"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("1bb4e6bb-a23c-46c4-932c-8a9d48239db3"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("991d13aa-26ab-47c6-b83f-6e466647cce7"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("abac31c0-f9f6-4449-98ac-3521e9ab8b4e"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("cd2c3e61-2052-4cc0-84a0-0c4c7e0312ab"));

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Item",
                newName: "Department");

            migrationBuilder.AlterColumn<string>(
                name: "UomId",
                table: "Tariff",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

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
    }
}
