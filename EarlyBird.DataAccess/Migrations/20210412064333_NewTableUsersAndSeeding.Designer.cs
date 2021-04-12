﻿// <auto-generated />
using System;
using EarlyBird.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EarlyBird.DataAccess.Migrations
{
    [DbContext(typeof(EarlyBirdContext))]
    [Migration("20210412064333_NewTableUsersAndSeeding")]
    partial class NewTableUsersAndSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pet Sitting"
                        },
                        new
                        {
                            Id = 2,
                            Name = "House Sitting"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Food Delivery"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Car Renting"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Babysitting"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Housecleaning"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Tutoring"
                        });
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.LocationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Rawa Mazowiecka",
                            StreetName = "Sutherland",
                            StreetNumber = "5694"
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Mojo",
                            StreetName = "Vernon",
                            StreetNumber = "1029"
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Lubei",
                            StreetName = "Grover",
                            StreetNumber = "755"
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Presidente Epit�cio",
                            StreetName = "Fulton",
                            StreetNumber = "3"
                        });
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.OfferCategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OfferId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OfferId");

                    b.ToTable("OfferCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            OfferId = 4
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            OfferId = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 7,
                            OfferId = 19
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 7,
                            OfferId = 15
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            OfferId = 8
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            OfferId = 6
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 6,
                            OfferId = 11
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            OfferId = 12
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            OfferId = 10
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 6,
                            OfferId = 9
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            OfferId = 5
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 7,
                            OfferId = 1
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            OfferId = 16
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 1,
                            OfferId = 10
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 6,
                            OfferId = 16
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            OfferId = 18
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            OfferId = 8
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 6,
                            OfferId = 12
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 6,
                            OfferId = 4
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 7,
                            OfferId = 15
                        });
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.OfferEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("AccepterId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Cost")
                        .HasMaxLength(100)
                        .HasColumnType("REAL");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Prerequisites")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccepterId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Offers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 13.6,
                            Description = "turpis a pede posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum",
                            LocationId = 1,
                            Prerequisites = "extranet",
                            PublisherId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            Status = 1,
                            Title = " Job Title96"
                        },
                        new
                        {
                            Id = 2,
                            Cost = 86.200000000000003,
                            Description = "cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor lacus at turpis donec posuere metus vitae ipsum aliquam non",
                            LocationId = 3,
                            Prerequisites = "initiative",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 1,
                            Title = " Job Title5"
                        },
                        new
                        {
                            Id = 3,
                            AccepterId = new Guid("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                            Cost = 30.699999999999999,
                            Description = "lacinia eget tincidunt eget tempus vel pede morbi porttitor lorem id ligula suspendisse ornare consequat",
                            LocationId = 2,
                            Notes = "dapibus at diam nam tristique tortor eu pede",
                            Prerequisites = "User-friendly",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title77"
                        },
                        new
                        {
                            Id = 4,
                            Cost = 64.900000000000006,
                            Description = "duis mattis egestas metus aenean fermentum donec ut mauris eget massa tempor convallis nulla neque libero convallis eget eleifend luctus ultricies eu nibh quisque id justo sit",
                            LocationId = 2,
                            Prerequisites = "upward-trending",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 1,
                            Title = " Job Title80"
                        },
                        new
                        {
                            Id = 5,
                            AccepterId = new Guid("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                            Cost = 35.899999999999999,
                            Description = "magna bibendum imperdiet nullam orci pede venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem",
                            LocationId = 4,
                            Notes = "in libero ut massa volutpat convallis morbi odio odio elementum eu interdum eu tincidunt",
                            Prerequisites = "Progressive",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title29"
                        },
                        new
                        {
                            Id = 6,
                            AccepterId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Cost = 41.299999999999997,
                            Description = "in faucibus orci luctus et ultrices posuere cubilia curae duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel",
                            LocationId = 3,
                            Notes = "tempus semper est quam pharetra magna ac consequat",
                            Prerequisites = "synergy",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title30"
                        },
                        new
                        {
                            Id = 7,
                            Cost = 26.600000000000001,
                            Description = "sapien in sapien iaculis congue vivamus metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc",
                            LocationId = 4,
                            Prerequisites = "Automated",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 1,
                            Title = " Job Title35"
                        },
                        new
                        {
                            Id = 8,
                            AccepterId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Cost = 6.2000000000000002,
                            Description = "condimentum neque sapien placerat ante nulla justo aliquam quis turpis eget elit sodales scelerisque mauris sit amet eros suspendisse accumsan tortor quis turpis sed ante vivamus tortor duis mattis",
                            LocationId = 1,
                            Notes = "nam nulla integer pede justo lacinia eget tincidunt eget tempus vel pede morbi porttitor lorem id ligula suspendisse ornare consequat",
                            Prerequisites = "optimal",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title39"
                        },
                        new
                        {
                            Id = 9,
                            AccepterId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Cost = 84.099999999999994,
                            Description = "augue vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum",
                            LocationId = 2,
                            Notes = "aliquet at feugiat non pretium quis",
                            Prerequisites = "intranet",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title28"
                        },
                        new
                        {
                            Id = 10,
                            Cost = 75.400000000000006,
                            Description = "lacus at turpis donec posuere metus vitae ipsum aliquam non mauris morbi non lectus aliquam sit amet diam in magna bibendum imperdiet nullam orci pede venenatis non",
                            LocationId = 3,
                            Prerequisites = "asymmetric",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 1,
                            Title = " Job Title92"
                        },
                        new
                        {
                            Id = 11,
                            AccepterId = new Guid("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                            Cost = 76.799999999999997,
                            Description = "adipiscing elit proin risus praesent lectus vestibulum quam sapien varius ut blandit non interdum in",
                            LocationId = 4,
                            Notes = "vestibulum sed magna at nunc commodo placerat praesent blandit nam",
                            Prerequisites = "upward-trending",
                            PublisherId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            Status = 2,
                            Title = " Job Title61"
                        },
                        new
                        {
                            Id = 12,
                            Cost = 49.399999999999999,
                            Description = "quam nec dui luctus rutrum nulla tellus in sagittis dui vel nisl duis ac nibh fusce lacus purus aliquet at feugiat non",
                            LocationId = 2,
                            Prerequisites = "superstructure",
                            PublisherId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            Status = 1,
                            Title = " Job Title38"
                        },
                        new
                        {
                            Id = 13,
                            AccepterId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Cost = 94.099999999999994,
                            Description = "eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna pretium nisl ut volutpat sapien arcu sed augue aliquam erat volutpat in",
                            LocationId = 3,
                            Notes = "ridiculus mus vivamus vestibulum sagittis sapien cum sociis",
                            Prerequisites = "Synergized",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title32"
                        },
                        new
                        {
                            Id = 14,
                            Cost = 45.399999999999999,
                            Description = "adipiscing elit proin risus praesent lectus vestibulum quam sapien varius ut blandit non interdum in ante vestibulum ante ipsum primis in faucibus orci luctus",
                            LocationId = 3,
                            Prerequisites = "extranet",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 1,
                            Title = " Job Title44"
                        },
                        new
                        {
                            Id = 15,
                            AccepterId = new Guid("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                            Cost = 62.200000000000003,
                            Description = "ut blandit non interdum in ante vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae duis faucibus accumsan",
                            LocationId = 3,
                            Notes = "enim sit amet nunc viverra dapibus nulla suscipit ligula in lacus curabitur at ipsum ac",
                            Prerequisites = "knowledge user",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title79"
                        },
                        new
                        {
                            Id = 16,
                            AccepterId = new Guid("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                            Cost = 44.399999999999999,
                            Description = "magna bibendum imperdiet nullam orci pede venenatis non sodales sed tincidunt eu felis fusce posuere felis sed",
                            LocationId = 3,
                            Notes = "sit amet sapien dignissim vestibulum vestibulum ante",
                            Prerequisites = "project",
                            PublisherId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            Status = 2,
                            Title = " Job Title44"
                        },
                        new
                        {
                            Id = 17,
                            Cost = 2.3999999999999999,
                            Description = "molestie lorem quisque ut erat curabitur gravida nisi at nibh in hac habitasse platea dictumst aliquam augue quam sollicitudin vitae consectetuer",
                            LocationId = 3,
                            Prerequisites = "Triple-buffered",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 1,
                            Title = " Job Title33"
                        },
                        new
                        {
                            Id = 18,
                            Cost = 95.900000000000006,
                            Description = "leo maecenas pulvinar lobortis est phasellus sit amet erat nulla tempus vivamus in felis eu sapien cursus vestibulum proin eu mi nulla",
                            LocationId = 3,
                            Prerequisites = "even-keeled",
                            PublisherId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            Status = 1,
                            Title = " Job Title72"
                        },
                        new
                        {
                            Id = 19,
                            AccepterId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Cost = 46.700000000000003,
                            Description = "libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh in quis justo",
                            LocationId = 1,
                            Notes = "nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse potenti",
                            Prerequisites = "transitional",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title65"
                        },
                        new
                        {
                            Id = 20,
                            AccepterId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Cost = 34.100000000000001,
                            Description = "vestibulum vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat",
                            LocationId = 2,
                            Notes = "laoreet ut rhoncus aliquet pulvinar sed",
                            Prerequisites = "24 hour",
                            PublisherId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Status = 2,
                            Title = " Job Title82"
                        });
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.ReviewEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "dui maecenas tristique est et tempus semper est quam pharetra magna ac consequat metus sapien ut nunc vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam",
                            Rating = 5,
                            ReceiverId = new Guid("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                            SenderId = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Title = "Review title79"
                        },
                        new
                        {
                            Id = 2,
                            Description = "luctus cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean",
                            Rating = 1,
                            ReceiverId = new Guid("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                            SenderId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            Title = "Review title90"
                        },
                        new
                        {
                            Id = 3,
                            Description = "sit amet lobortis sapien sapien non mi integer ac neque duis bibendum morbi non quam nec dui luctus rutrum nulla tellus in sagittis dui vel nisl duis ac nibh",
                            Rating = 2,
                            ReceiverId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            SenderId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Title = "Review title41"
                        },
                        new
                        {
                            Id = 4,
                            Description = "felis fusce posuere felis sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis nam congue risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero",
                            Rating = 2,
                            ReceiverId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            SenderId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Title = "Review title18"
                        },
                        new
                        {
                            Id = 5,
                            Description = "ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer",
                            Rating = 2,
                            ReceiverId = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            SenderId = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            Title = "Review title29"
                        });
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("07d94746-c113-4de6-a0bf-8c4789b51c67"),
                            Firstname = "Cristian",
                            Lastname = "Nicolae",
                            PasswordHash = "$2a$11$1DDhMkGdHKzRpZD58VrBkeyAVzyOwy/6U.477iRPKa0nqrshG5Uai",
                            Role = 1,
                            Salt = "$2a$11$sXaoXQUj6BI42tEqXOn1Le",
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                            Firstname = "Andrei",
                            Lastname = "Varga",
                            PasswordHash = "$2a$11$YURVMRGs3QDhVZgpFWQpXOHUUOp49/LymzWGXFTLy8kVJrOER4ycy",
                            Role = 2,
                            Salt = "$2a$11$E.61pvDXr2CQL27VO3ImB.",
                            Username = "worker"
                        },
                        new
                        {
                            Id = new Guid("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                            Firstname = "Andrei-Vlad",
                            Lastname = "Popica",
                            PasswordHash = "$2a$11$.0eYZPNhxxrxf61btEY0KOAcjxQVv.Il/qT0uaZAp..iz2RF8kjzW",
                            Role = 3,
                            Salt = "$2a$11$H4r.INnHWvEHJCL9Hce7..",
                            Username = "publisher"
                        },
                        new
                        {
                            Id = new Guid("1545516d-abe8-4597-96a4-7998e8c51c79"),
                            Firstname = "Marius-Cristian",
                            Lastname = "Socaci",
                            PasswordHash = "$2a$11$SKp590yIMqR2UZlHGw71EeleTKpqctbTirYX8UgL6DxkLn.xQB4YC",
                            Role = 3,
                            Salt = "$2a$11$2uYukkue1wmvWBfNqHLfYO",
                            Username = "publisher2"
                        },
                        new
                        {
                            Id = new Guid("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                            Firstname = "Flaviu",
                            Lastname = "Raita",
                            PasswordHash = "$2a$11$zO7pPer/sSlNFKOT7autYOQWVwe.lhiBXqUv8spAlzonZXKNABPSi",
                            Role = 2,
                            Salt = "$2a$11$2O5ChQH25x5s2wEMeGN/G.",
                            Username = "worker2"
                        });
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.OfferCategoryEntity", b =>
                {
                    b.HasOne("EarlyBird.DataAccess.Entities.CategoryEntity", "Category")
                        .WithMany("Offers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EarlyBird.DataAccess.Entities.OfferEntity", "Offer")
                        .WithMany("Categories")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.OfferEntity", b =>
                {
                    b.HasOne("EarlyBird.DataAccess.Entities.UserEntity", "Accepter")
                        .WithMany("OffersAccepted")
                        .HasForeignKey("AccepterId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EarlyBird.DataAccess.Entities.LocationEntity", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EarlyBird.DataAccess.Entities.UserEntity", "Publisher")
                        .WithMany("OffersPublished")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Accepter");

                    b.Navigation("Location");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.ReviewEntity", b =>
                {
                    b.HasOne("EarlyBird.DataAccess.Entities.UserEntity", "Receiver")
                        .WithMany("ReviewsReceived")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EarlyBird.DataAccess.Entities.UserEntity", "Sender")
                        .WithMany("ReviewsSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.OfferEntity", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("EarlyBird.DataAccess.Entities.UserEntity", b =>
                {
                    b.Navigation("OffersAccepted");

                    b.Navigation("OffersPublished");

                    b.Navigation("ReviewsReceived");

                    b.Navigation("ReviewsSent");
                });
#pragma warning restore 612, 618
        }
    }
}
