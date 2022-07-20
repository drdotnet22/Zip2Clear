﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zip2Clear.Data;

#nullable disable

namespace Zip2Clear.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

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
                            Id = new Guid("3983d3c3-99e1-47a3-9fb7-54c774419fa1"),
                            BOLnumber = "PEVMOB005095",
                            CountryOfDestination = "BS",
                            CountryOfOrigin = "US",
                            CreatedDate = new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2140),
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
                            SubmittedDate = new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2142),
                            TotalGrossMassMeasureQnty = 390.0,
                            TotalGrossMassMeasureUOM = "LB",
                            TotalPackageQnty = 1.0,
                            TotalPackageQntyUOM = "EA",
                            Type = "400"
                        },
                        new
                        {
                            Id = new Guid("ea677e3d-83f1-40be-ad3d-3cc74fbe9661"),
                            BOLnumber = "PEVMOB005096",
                            CountryOfDestination = "BS",
                            CountryOfOrigin = "US",
                            CreatedDate = new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2149),
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
                            SubmittedDate = new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2151),
                            TotalGrossMassMeasureQnty = 40.0,
                            TotalGrossMassMeasureUOM = "LB",
                            TotalPackageQnty = 1.0,
                            TotalPackageQntyUOM = "EA",
                            Type = "400"
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

                    b.Property<Guid?>("VendorId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeclarationId");

                    b.HasIndex("VendorId");

                    b.ToTable("Invoice");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f2d2e766-8352-4a23-9876-e71eaa1f2229"),
                            Date = new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2072),
                            Insurance = 150m,
                            Number = "814184793",
                            Shipping = 0m
                        },
                        new
                        {
                            Id = new Guid("b283daf1-25b8-4228-aa30-93a799d07197"),
                            Date = new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2109),
                            Insurance = 0m,
                            Number = "2022ES7023",
                            Shipping = 0m
                        },
                        new
                        {
                            Id = new Guid("33f61c5d-1253-4b99-9164-0e6818009de8"),
                            Date = new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2112),
                            Insurance = 0m,
                            Number = "2022ES8200",
                            Shipping = 0m
                        },
                        new
                        {
                            Id = new Guid("e7c2b6d3-d1f8-42b0-9235-5b1c0e1065d1"),
                            Date = new DateTime(2022, 7, 19, 22, 29, 48, 989, DateTimeKind.Local).AddTicks(2115),
                            Insurance = 150.23m,
                            Number = "11312272",
                            Shipping = 75m
                        });
                });

            modelBuilder.Entity("Zip2Clear.Data.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("InvoiceId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("TariffId")
                        .HasColumnType("TEXT");

                    b.Property<double?>("UomValue")
                        .HasColumnType("REAL");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

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

                    b.Property<string>("UomId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tariff");

                    b.HasData(
                        new
                        {
                            Id = new Guid("19a15921-7cc5-4546-b968-a261cea146ba"),
                            ExciseRate = 0.0,
                            GeneralRate = 0.0,
                            Name = "APPLES",
                            Number = 8081000.0,
                            UomId = "LB"
                        },
                        new
                        {
                            Id = new Guid("bf1451f3-3eb1-4da3-8729-efa7ad26f3de"),
                            ExciseRate = 0.0,
                            GeneralRate = 45.0,
                            Name = "BATTERIES",
                            Number = 85073000.0,
                            UomId = "EA"
                        },
                        new
                        {
                            Id = new Guid("786a9bfb-5ef4-4179-9354-6e6fe7b2d393"),
                            ExciseRate = 0.0,
                            GeneralRate = 60.0,
                            Name = "CANDY",
                            Number = 17049010.0,
                            UomId = "LB"
                        });
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
                            Id = new Guid("e392b12b-8c64-40c3-8dc8-7ff8e7ddcf64"),
                            AddressLine = "PO BOX 1723",
                            CityName = "OKEECHOBEE",
                            CountryCode = "US",
                            Name = "WALPOLE FEED",
                            PostalCode = "34973",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("b694db7d-a142-44ac-b6e9-bfdc8bbed0f4"),
                            AddressLine = "12029 W DOPHIN CT",
                            CityName = "HOMOSASSA",
                            CountryCode = "US",
                            Name = "AGRIVET",
                            PostalCode = "34448",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("ae6f22f8-8f1e-43bc-8244-181101960c12"),
                            AddressLine = "1301 SW 2ND ST",
                            CityName = "POMPANO BEACH",
                            CountryCode = "US",
                            Name = "ROADWAY TIRES",
                            PostalCode = "33069",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("a30c6807-4b99-49f8-89e3-725a0c9f9584"),
                            AddressLine = "2968 RAVENSWOOD ROAD",
                            CityName = "FORT LAUDERDALE",
                            CountryCode = "US",
                            Name = "TPH",
                            PostalCode = "33312",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("9f8eef22-69ea-4ff6-8cc1-593a6d0cdcf8"),
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
                        .HasForeignKey("VendorId");

                    b.Navigation("Declaration");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("Zip2Clear.Data.Item", b =>
                {
                    b.HasOne("Zip2Clear.Data.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId");

                    b.HasOne("Zip2Clear.Data.Tariff", "Tariff")
                        .WithMany()
                        .HasForeignKey("TariffId");

                    b.Navigation("Invoice");

                    b.Navigation("Tariff");
                });
#pragma warning restore 612, 618
        }
    }
}
