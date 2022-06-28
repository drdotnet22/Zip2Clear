using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class ChangedInvoiceclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("7ab485e6-c9ab-4034-928b-9cbffb3b55c0"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "Id",
                keyValue: new Guid("c7c3d1ce-08bb-4868-8667-df5a08ea9f3d"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("1005a639-0642-4900-8c4e-393469b0fc89"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("1673f280-3349-4d7f-9b34-b5ade2d82e65"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("5a94f2ec-0162-4021-8623-f6a4b4b9ebe0"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("eeefd359-e822-4087-a463-29e8d375ab45"));

            migrationBuilder.DeleteData(
                table: "Tarriff",
                keyColumn: "Id",
                keyValue: new Guid("02fea001-96e2-42cf-84a2-2d322b43bfc2"));

            migrationBuilder.DeleteData(
                table: "Tarriff",
                keyColumn: "Id",
                keyValue: new Guid("0a113110-72da-44f0-afff-12459976dfed"));

            migrationBuilder.DeleteData(
                table: "Tarriff",
                keyColumn: "Id",
                keyValue: new Guid("4d93a435-4e0c-4600-af25-6409b6bbbd90"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("071b939c-de4a-454e-bebc-ccab1dce8fe4"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("24b12be4-a2ac-434d-8d15-5c237556a33f"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("90d7c762-c880-4fc5-9eb8-eee4ee67ce1f"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("a0fd6bbd-dab5-4596-829b-8b74f10a35ef"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("f4b38c6f-f696-4889-83e9-08e8525eab88"));

            migrationBuilder.RenameColumn(
                name: "InsuranceValue",
                table: "Invoice",
                newName: "Shipping");

            migrationBuilder.RenameColumn(
                name: "FreightValue",
                table: "Invoice",
                newName: "Insurance");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Tarriff",
                keyColumn: "Id",
                keyValue: new Guid("6cba619c-f555-421a-bbb2-5794844abdb2"));

            migrationBuilder.DeleteData(
                table: "Tarriff",
                keyColumn: "Id",
                keyValue: new Guid("75f37593-ef69-4bea-be0f-bb5bede0c20f"));

            migrationBuilder.DeleteData(
                table: "Tarriff",
                keyColumn: "Id",
                keyValue: new Guid("7eaf8d29-1fc7-45c0-bedf-06a186f6a785"));

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
                name: "Shipping",
                table: "Invoice",
                newName: "InsuranceValue");

            migrationBuilder.RenameColumn(
                name: "Insurance",
                table: "Invoice",
                newName: "FreightValue");

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
        }
    }
}
