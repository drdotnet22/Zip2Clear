﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zip2Clear.Data;

#nullable disable

namespace Zip2Clear.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220723215748_added-uom-reference-in-tariff")]
    partial class addeduomreferenceintariff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("Zip2Clear.Data.Declaration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BOLnumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryOfDestination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeclarationNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DeclarationOffice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Exporter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Importer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ManifestNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModeOfTransport")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PortOfEntry")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PortOfExit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Regime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Submitted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SubmittedDate")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalGrossMassMeasureQnty")
                        .HasColumnType("REAL");

                    b.Property<string>("TotalGrossMassMeasureUOM")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalPackageQnty")
                        .HasColumnType("REAL");

                    b.Property<string>("TotalPackageQntyUOM")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Declaration");

                    b.HasData(
                        new
                        {
                            Id = new Guid("67685d53-8a52-400e-8753-5c260ec4ee77"),
                            BOLnumber = "PEVMOB005095",
                            CountryOfDestination = "BS",
                            CountryOfOrigin = "US",
                            CreatedDate = new DateTime(2022, 7, 23, 17, 57, 48, 58, DateTimeKind.Local).AddTicks(1540),
                            DeclarationNumber = "2022DEC0000845484",
                            DeclarationOffice = "SAQPDK",
                            Exporter = "Mennonite Messianic Mission",
                            Importer = "Mennonite Messianic Mission",
                            ManifestNumber = "MSTRNO30613",
                            ModeOfTransport = "1",
                            PortOfEntry = "SAQ",
                            PortOfExit = "USPVS",
                            Regime = "4",
                            Status = "Compliance",
                            Submitted = true,
                            SubmittedDate = new DateTime(2022, 7, 23, 17, 57, 48, 58, DateTimeKind.Local).AddTicks(1569),
                            TotalGrossMassMeasureQnty = 390.0,
                            TotalGrossMassMeasureUOM = "LB",
                            TotalPackageQnty = 1.0,
                            TotalPackageQntyUOM = "EA",
                            Type = "400"
                        },
                        new
                        {
                            Id = new Guid("31958655-f36f-4139-bc5a-5e5bd41a83c7"),
                            BOLnumber = "PEVMOB005096",
                            CountryOfDestination = "BS",
                            CountryOfOrigin = "US",
                            CreatedDate = new DateTime(2022, 7, 23, 17, 57, 48, 58, DateTimeKind.Local).AddTicks(1576),
                            DeclarationNumber = "2022DEC0000845474",
                            DeclarationOffice = "SAQPDK",
                            Exporter = "Mennonite Messianic Mission",
                            Importer = "Mennonite Messianic Mission",
                            ManifestNumber = "MSTRNO30613",
                            ModeOfTransport = "1",
                            PortOfEntry = "SAQ",
                            PortOfExit = "USPVS",
                            Regime = "4",
                            Status = "Compliance",
                            Submitted = true,
                            SubmittedDate = new DateTime(2022, 7, 23, 17, 57, 48, 58, DateTimeKind.Local).AddTicks(1578),
                            TotalGrossMassMeasureQnty = 40.0,
                            TotalGrossMassMeasureUOM = "LB",
                            TotalPackageQnty = 1.0,
                            TotalPackageQntyUOM = "EA",
                            Type = "400"
                        });
                });

            modelBuilder.Entity("Zip2Clear.Data.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = new Guid("40f705a2-2ab6-4da3-a493-6db983a9d682"),
                            Code = "MM",
                            Email = "mmf.lr@emypeople.net"
                        },
                        new
                        {
                            Id = new Guid("b55d8f04-095e-4b77-b10b-a81a941b6d66"),
                            Code = "MS",
                            Email = "mms.lr@emypeople.net"
                        });
                });

            modelBuilder.Entity("Zip2Clear.Data.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DeclarationId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Insurance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Shipping")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VendorId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeclarationId");

                    b.HasIndex("VendorId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Zip2Clear.Data.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("InvoiceId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<Guid>("TariffId")
                        .HasColumnType("TEXT");

                    b.Property<double?>("UomValue")
                        .HasColumnType("REAL");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("TariffId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Zip2Clear.Data.Tariff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("ExciseRate")
                        .HasColumnType("REAL");

                    b.Property<double>("GeneralRate")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Number")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("UomId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UomId");

                    b.ToTable("Tariff");
                });

            modelBuilder.Entity("Zip2Clear.Data.UOM", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UOM");
                });

            modelBuilder.Entity("Zip2Clear.Data.Vendor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vendor");

                    b.HasData(
                        new
                        {
                            Id = new Guid("991d13aa-26ab-47c6-b83f-6e466647cce7"),
                            AddressLine = "PO BOX 1723",
                            CityName = "OKEECHOBEE",
                            CountryCode = "US",
                            Name = "WALPOLE FEED",
                            PostalCode = "34973",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("0069d576-fd87-47ae-9dfa-95611bff878f"),
                            AddressLine = "12029 W DOPHIN CT",
                            CityName = "HOMOSASSA",
                            CountryCode = "US",
                            Name = "AGRIVET",
                            PostalCode = "34448",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("abac31c0-f9f6-4449-98ac-3521e9ab8b4e"),
                            AddressLine = "1301 SW 2ND ST",
                            CityName = "POMPANO BEACH",
                            CountryCode = "US",
                            Name = "ROADWAY TIRES",
                            PostalCode = "33069",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("cd2c3e61-2052-4cc0-84a0-0c4c7e0312ab"),
                            AddressLine = "2968 RAVENSWOOD ROAD",
                            CityName = "FORT LAUDERDALE",
                            CountryCode = "US",
                            Name = "TPH",
                            PostalCode = "33312",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("1bb4e6bb-a23c-46c4-932c-8a9d48239db3"),
                            AddressLine = "4300 STEWART ROAD",
                            CityName = "LAKELAND",
                            CountryCode = "US",
                            Name = "MONTE PACKAGE",
                            PostalCode = "33815",
                            State = "FL"
                        });
                });

            modelBuilder.Entity("Zip2Clear.Data.Invoice", b =>
                {
                    b.HasOne("Zip2Clear.Data.Declaration", "Declaration")
                        .WithMany()
                        .HasForeignKey("DeclarationId");

                    b.HasOne("Zip2Clear.Data.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Declaration");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("Zip2Clear.Data.Item", b =>
                {
                    b.HasOne("Zip2Clear.Data.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Zip2Clear.Data.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zip2Clear.Data.Tariff", "Tariff")
                        .WithMany()
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Invoice");

                    b.Navigation("Tariff");
                });

            modelBuilder.Entity("Zip2Clear.Data.Tariff", b =>
                {
                    b.HasOne("Zip2Clear.Data.UOM", "UOM")
                        .WithMany()
                        .HasForeignKey("UomId");

                    b.Navigation("UOM");
                });
#pragma warning restore 612, 618
        }
    }
}
