using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Zip2Clear.Migrations
{
    /// <inheritdoc />
    public partial class switchdepartmentfieldfromitemtoinvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Department_DepartmentId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_DepartmentId",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "DeclarationId",
                keyValue: new Guid("41b254a2-b09f-4012-a467-e1b9ad2e3d17"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "DeclarationId",
                keyValue: new Guid("b0db578f-b858-48f6-8b40-de0b26c0baa2"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("19904b65-4819-4254-8878-95cea9b0fe84"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("553ba773-8996-40cb-9df8-e4b4f893a46c"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("6e294201-0187-4aea-bc8b-3f63a7758806"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("7363e105-0bcd-4e89-9fb6-f125f2045479"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("75114055-ec83-4765-aa48-168b7c3d1c70"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("754f58fa-cc4c-4951-897f-f068462a2b2c"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("eed01065-5c18-4691-bea2-c0c31176eef7"));

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Item");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Invoice",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "DeclarationId", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[,]
                {
                    { new Guid("8e36d91b-0dde-4442-ad63-2cae361977bf"), "PEVMOB005095", "BS", "US", new DateTime(2024, 1, 2, 20, 50, 54, 892, DateTimeKind.Local).AddTicks(1143), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2024, 1, 2, 20, 50, 54, 892, DateTimeKind.Local).AddTicks(1194), 390.0, "LB", 1.0, "EA", "400" },
                    { new Guid("dd231c3b-c4f2-410d-b33a-565497d48cc8"), "PEVMOB005096", "BS", "US", new DateTime(2024, 1, 2, 20, 50, 54, 892, DateTimeKind.Local).AddTicks(1204), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2024, 1, 2, 20, 50, 54, 892, DateTimeKind.Local).AddTicks(1206), 40.0, "LB", 1.0, "EA", "400" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Code", "Email", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("6a90fa7f-d9b2-434c-909b-5374db8ce8f2"), "MM", "mmf.lr@emypeople.net", true, "Mennonite Mission" },
                    { new Guid("bbd99f80-e110-48ab-b1f8-dfa038542bbb"), "MS", "mms.lr@emypeople.net", true, "Mechanic Shop" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[,]
                {
                    { new Guid("658cc4ed-8dce-41fe-a031-03f2cc9f585d"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" },
                    { new Guid("97fa5f61-9518-4ede-9f49-2be7e27e12cc"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" },
                    { new Guid("a846ac99-1123-452c-ac7a-d34025db00f8"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" },
                    { new Guid("b8b6fb0c-8bd9-4b8b-9e3e-524ed3207c4e"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" },
                    { new Guid("dae81092-8afe-4295-a26f-425e8780ed77"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_DepartmentId",
                table: "Invoice",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Department_DepartmentId",
                table: "Invoice",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Department_DepartmentId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_DepartmentId",
                table: "Invoice");

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "DeclarationId",
                keyValue: new Guid("8e36d91b-0dde-4442-ad63-2cae361977bf"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "DeclarationId",
                keyValue: new Guid("dd231c3b-c4f2-410d-b33a-565497d48cc8"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("6a90fa7f-d9b2-434c-909b-5374db8ce8f2"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("bbd99f80-e110-48ab-b1f8-dfa038542bbb"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("658cc4ed-8dce-41fe-a031-03f2cc9f585d"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("97fa5f61-9518-4ede-9f49-2be7e27e12cc"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("a846ac99-1123-452c-ac7a-d34025db00f8"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("b8b6fb0c-8bd9-4b8b-9e3e-524ed3207c4e"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("dae81092-8afe-4295-a26f-425e8780ed77"));

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Invoice");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Item",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "DeclarationId", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[,]
                {
                    { new Guid("41b254a2-b09f-4012-a467-e1b9ad2e3d17"), "PEVMOB005095", "BS", "US", new DateTime(2024, 1, 1, 19, 33, 19, 102, DateTimeKind.Local).AddTicks(1941), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2024, 1, 1, 19, 33, 19, 102, DateTimeKind.Local).AddTicks(1990), 390.0, "LB", 1.0, "EA", "400" },
                    { new Guid("b0db578f-b858-48f6-8b40-de0b26c0baa2"), "PEVMOB005096", "BS", "US", new DateTime(2024, 1, 1, 19, 33, 19, 102, DateTimeKind.Local).AddTicks(1998), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2024, 1, 1, 19, 33, 19, 102, DateTimeKind.Local).AddTicks(2000), 40.0, "LB", 1.0, "EA", "400" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Code", "Email", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("19904b65-4819-4254-8878-95cea9b0fe84"), "MM", "mmf.lr@emypeople.net", true, "Mennonite Mission" },
                    { new Guid("553ba773-8996-40cb-9df8-e4b4f893a46c"), "MS", "mms.lr@emypeople.net", true, "Mechanic Shop" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[,]
                {
                    { new Guid("6e294201-0187-4aea-bc8b-3f63a7758806"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" },
                    { new Guid("7363e105-0bcd-4e89-9fb6-f125f2045479"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" },
                    { new Guid("75114055-ec83-4765-aa48-168b7c3d1c70"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" },
                    { new Guid("754f58fa-cc4c-4951-897f-f068462a2b2c"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" },
                    { new Guid("eed01065-5c18-4691-bea2-c0c31176eef7"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_DepartmentId",
                table: "Item",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Department_DepartmentId",
                table: "Item",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId");
        }
    }
}
