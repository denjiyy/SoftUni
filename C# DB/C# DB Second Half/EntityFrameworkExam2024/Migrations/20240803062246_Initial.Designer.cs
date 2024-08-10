﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAgency.Data;

#nullable disable

namespace TravelAgency.Migrations
{
    [DbContext(typeof(TravelAgencyContext))]
    [Migration("20240803062246_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TravelAgency.Data.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("TourPackageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TourPackageId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TravelAgency.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TravelAgency.Data.Models.Guide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Language")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Guides");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "John Doe",
                            Language = 4
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Jane Smith",
                            Language = 0
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Alex Johnson",
                            Language = 3
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Emily Davis",
                            Language = 2
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Michael Brown",
                            Language = 1
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Sarah Wilson",
                            Language = 4
                        },
                        new
                        {
                            Id = 7,
                            FullName = "David Lee",
                            Language = 0
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Laura Garcia",
                            Language = 1
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Chris Martin",
                            Language = 3
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Anna Thompson",
                            Language = 2
                        });
                });

            modelBuilder.Entity("TravelAgency.Data.Models.TourPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TourPackages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Experience the thrill of a guided horse riding tour through picturesque landscapes. Suitable for all skill levels. Enjoy nature and create unforgettable memories. Duration: 3 hours.",
                            PackageName = "Horse Riding Tour",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Explore the city's top attractions with a guided sightseeing tour. Visit historical landmarks, iconic buildings, and scenic spots. Perfect for all ages. Duration: 4 hours.",
                            PackageName = "Sightseeing Tour",
                            Price = 149.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dive into the crystal-clear waters and explore vibrant coral reefs and marine life. Suitable for beginners and experienced divers. Equipment provided. Duration: 2 hours.",
                            PackageName = "Diving Tour",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Embark on an exhilarating mountain hiking tour. Enjoy breathtaking views, fresh air, and challenging trails. Suitable for all fitness levels. Duration: 5 hours.",
                            PackageName = "Mountain Hiking",
                            Price = 179.99m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Discover the charm of the city with a guided tour. Visit famous landmarks, bustling markets, and hidden gems. Perfect for all ages. Duration: 3 hours.",
                            PackageName = "City Tour",
                            Price = 129.99m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Savor the local flavors on a guided food tour. Taste a variety of dishes, visit top eateries, and learn about the culinary culture. Suitable for all food lovers. Duration: 3 hours.",
                            PackageName = "Food Tour",
                            Price = 99.99m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Embark on an exciting wildlife safari. Spot exotic animals in their natural habitat, guided by experts. Perfect for nature enthusiasts. Duration: 4 hours.",
                            PackageName = "Wildlife Safari",
                            Price = 249.99m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Explore ancient ruins, museums, and landmarks on a guided tour. Learn about the rich history and culture of the area. Ideal for history buffs. Duration: 4 hours.",
                            PackageName = "Historical Sites",
                            Price = 159.99m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Experience a breathtaking sunset on a luxury cruise. Enjoy stunning views, delicious refreshments, and a relaxing atmosphere. Perfect for couples and families. Duration: 2 hours.",
                            PackageName = "Sunset Cruise",
                            Price = 399.99m
                        });
                });

            modelBuilder.Entity("TravelAgency.Data.Models.TourPackageGuide", b =>
                {
                    b.Property<int>("TourPackageId")
                        .HasColumnType("int");

                    b.Property<int>("GuideId")
                        .HasColumnType("int");

                    b.HasKey("TourPackageId", "GuideId");

                    b.HasIndex("GuideId");

                    b.ToTable("TourPackagesGuides");

                    b.HasData(
                        new
                        {
                            TourPackageId = 1,
                            GuideId = 1
                        },
                        new
                        {
                            TourPackageId = 1,
                            GuideId = 2
                        },
                        new
                        {
                            TourPackageId = 1,
                            GuideId = 3
                        },
                        new
                        {
                            TourPackageId = 2,
                            GuideId = 4
                        },
                        new
                        {
                            TourPackageId = 2,
                            GuideId = 5
                        },
                        new
                        {
                            TourPackageId = 2,
                            GuideId = 6
                        },
                        new
                        {
                            TourPackageId = 3,
                            GuideId = 7
                        },
                        new
                        {
                            TourPackageId = 3,
                            GuideId = 8
                        },
                        new
                        {
                            TourPackageId = 3,
                            GuideId = 9
                        },
                        new
                        {
                            TourPackageId = 4,
                            GuideId = 10
                        },
                        new
                        {
                            TourPackageId = 4,
                            GuideId = 1
                        },
                        new
                        {
                            TourPackageId = 4,
                            GuideId = 2
                        },
                        new
                        {
                            TourPackageId = 5,
                            GuideId = 3
                        },
                        new
                        {
                            TourPackageId = 5,
                            GuideId = 4
                        },
                        new
                        {
                            TourPackageId = 5,
                            GuideId = 5
                        },
                        new
                        {
                            TourPackageId = 6,
                            GuideId = 6
                        },
                        new
                        {
                            TourPackageId = 6,
                            GuideId = 7
                        },
                        new
                        {
                            TourPackageId = 6,
                            GuideId = 8
                        },
                        new
                        {
                            TourPackageId = 7,
                            GuideId = 9
                        },
                        new
                        {
                            TourPackageId = 7,
                            GuideId = 10
                        },
                        new
                        {
                            TourPackageId = 7,
                            GuideId = 1
                        },
                        new
                        {
                            TourPackageId = 8,
                            GuideId = 2
                        },
                        new
                        {
                            TourPackageId = 8,
                            GuideId = 3
                        },
                        new
                        {
                            TourPackageId = 8,
                            GuideId = 4
                        },
                        new
                        {
                            TourPackageId = 9,
                            GuideId = 5
                        },
                        new
                        {
                            TourPackageId = 9,
                            GuideId = 6
                        },
                        new
                        {
                            TourPackageId = 9,
                            GuideId = 7
                        });
                });

            modelBuilder.Entity("TravelAgency.Data.Models.Booking", b =>
                {
                    b.HasOne("TravelAgency.Data.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAgency.Data.Models.TourPackage", "TourPackage")
                        .WithMany("Bookings")
                        .HasForeignKey("TourPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("TourPackage");
                });

            modelBuilder.Entity("TravelAgency.Data.Models.TourPackageGuide", b =>
                {
                    b.HasOne("TravelAgency.Data.Models.Guide", "Guide")
                        .WithMany("TourPackagesGuides")
                        .HasForeignKey("GuideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAgency.Data.Models.TourPackage", "TourPackage")
                        .WithMany("TourPackagesGuides")
                        .HasForeignKey("TourPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guide");

                    b.Navigation("TourPackage");
                });

            modelBuilder.Entity("TravelAgency.Data.Models.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("TravelAgency.Data.Models.Guide", b =>
                {
                    b.Navigation("TourPackagesGuides");
                });

            modelBuilder.Entity("TravelAgency.Data.Models.TourPackage", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("TourPackagesGuides");
                });
#pragma warning restore 612, 618
        }
    }
}
