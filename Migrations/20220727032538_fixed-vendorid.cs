using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zip2Clear.Migrations
{
    public partial class fixedvendorid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "DeclarationId",
                keyValue: new Guid("00002a06-f731-4e07-b3e1-d861dc50c1a3"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "DeclarationId",
                keyValue: new Guid("3235faef-c77f-44c2-be06-de6e118f15a2"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("280cc0e9-1a04-4e17-b0ff-8c0323130ac8"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("5be5061a-f276-4b56-9092-87b9926a48c6"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("0fb26ff2-3493-41b5-bf5d-461f663c4dc6"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("1258df26-234d-4074-8f5d-3da2e5f21035"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("167247cf-24f4-4a53-8ba3-dfad500207aa"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("65ead5dc-18d2-45fe-ae24-841fc7527784"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("ddffb366-2e8a-43ef-8cc0-4f9d4fadc95d"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendor",
                newName: "VendorId");

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "DeclarationId", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("ac5f4277-4c1b-4e99-a653-4c467e5dc05a"), "PEVMOB005096", "BS", "US", new DateTime(2022, 7, 26, 23, 25, 37, 928, DateTimeKind.Local).AddTicks(1464), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 26, 23, 25, 37, 928, DateTimeKind.Local).AddTicks(1465), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "DeclarationId", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("d2a2c905-3d4b-4bbe-baa8-8371380acd0a"), "PEVMOB005095", "BS", "US", new DateTime(2022, 7, 26, 23, 25, 37, 928, DateTimeKind.Local).AddTicks(1422), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 26, 23, 25, 37, 928, DateTimeKind.Local).AddTicks(1455), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Code", "Email" },
                values: new object[] { new Guid("47d37454-523e-4baf-9acc-abd43fac3759"), "MM", "mmf.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Code", "Email" },
                values: new object[] { new Guid("75b276e5-6f9a-4e49-a537-ad9206be41f4"), "MS", "mms.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("65215e92-bc7a-4b1d-a831-a240c8e4f69b"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("80c88eb0-a210-49b7-839e-42432d449d4a"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("b351ffd8-b9c6-4f94-ac17-e320cfca44b7"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("b5eb1715-7eff-4f10-a22e-f4994a413903"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("ecdbf9f6-b687-425c-a450-8bba748a9005"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "DeclarationId",
                keyValue: new Guid("ac5f4277-4c1b-4e99-a653-4c467e5dc05a"));

            migrationBuilder.DeleteData(
                table: "Declaration",
                keyColumn: "DeclarationId",
                keyValue: new Guid("d2a2c905-3d4b-4bbe-baa8-8371380acd0a"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("47d37454-523e-4baf-9acc-abd43fac3759"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("75b276e5-6f9a-4e49-a537-ad9206be41f4"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("65215e92-bc7a-4b1d-a831-a240c8e4f69b"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("80c88eb0-a210-49b7-839e-42432d449d4a"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("b351ffd8-b9c6-4f94-ac17-e320cfca44b7"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("b5eb1715-7eff-4f10-a22e-f4994a413903"));

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: new Guid("ecdbf9f6-b687-425c-a450-8bba748a9005"));

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "Vendor",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "DeclarationId", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("00002a06-f731-4e07-b3e1-d861dc50c1a3"), "PEVMOB005096", "BS", "US", new DateTime(2022, 7, 26, 8, 23, 45, 543, DateTimeKind.Local).AddTicks(2507), "2022DEC0000845474", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 26, 8, 23, 45, 543, DateTimeKind.Local).AddTicks(2509), 40.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Declaration",
                columns: new[] { "DeclarationId", "BOLnumber", "CountryOfDestination", "CountryOfOrigin", "CreatedDate", "DeclarationNumber", "DeclarationOffice", "Exporter", "Importer", "ManifestNumber", "ModeOfTransport", "PortOfEntry", "PortOfExit", "Regime", "Status", "Submitted", "SubmittedDate", "TotalGrossMassMeasureQnty", "TotalGrossMassMeasureUOM", "TotalPackageQnty", "TotalPackageQntyUOM", "Type" },
                values: new object[] { new Guid("3235faef-c77f-44c2-be06-de6e118f15a2"), "PEVMOB005095", "BS", "US", new DateTime(2022, 7, 26, 8, 23, 45, 543, DateTimeKind.Local).AddTicks(2468), "2022DEC0000845484", "SAQPDK", "Mennonite Messianic Mission", "Mennonite Messianic Mission", "MSTRNO30613", "1", "SAQ", "USPVS", "4", "Compliance", true, new DateTime(2022, 7, 26, 8, 23, 45, 543, DateTimeKind.Local).AddTicks(2500), 390.0, "LB", 1.0, "EA", "400" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Code", "Email" },
                values: new object[] { new Guid("280cc0e9-1a04-4e17-b0ff-8c0323130ac8"), "MM", "mmf.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Code", "Email" },
                values: new object[] { new Guid("5be5061a-f276-4b56-9092-87b9926a48c6"), "MS", "mms.lr@emypeople.net" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("0fb26ff2-3493-41b5-bf5d-461f663c4dc6"), "1301 SW 2ND ST", "POMPANO BEACH", "US", "ROADWAY TIRES", "33069", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("1258df26-234d-4074-8f5d-3da2e5f21035"), "12029 W DOPHIN CT", "HOMOSASSA", "US", "AGRIVET", "34448", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("167247cf-24f4-4a53-8ba3-dfad500207aa"), "4300 STEWART ROAD", "LAKELAND", "US", "MONTE PACKAGE", "33815", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("65ead5dc-18d2-45fe-ae24-841fc7527784"), "2968 RAVENSWOOD ROAD", "FORT LAUDERDALE", "US", "TPH", "33312", "FL" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "AddressLine", "CityName", "CountryCode", "Name", "PostalCode", "State" },
                values: new object[] { new Guid("ddffb366-2e8a-43ef-8cc0-4f9d4fadc95d"), "PO BOX 1723", "OKEECHOBEE", "US", "WALPOLE FEED", "34973", "FL" });
        }
    }
}
