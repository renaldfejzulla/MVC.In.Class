﻿// <auto-generated />
using System;
using MVC.In.Class.DataAcessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.In.Class.Migrations
{
    [DbContext(typeof(LibraryDBContext))]
    [Migration("20230205130038_UpdatedSeed")]
    partial class UpdatedSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb84bfac-70b3-4896-9833-a8d2a3bfbdff"),
                            BirthYear = new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(7726),
                            IsDeleted = false,
                            Name = "JJR Tolkien"
                        });
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.AuthorBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorBooks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("97e1ebb9-cd7a-4ecb-952e-87e132da430d"),
                            AuthorId = new Guid("fb84bfac-70b3-4896-9833-a8d2a3bfbdff"),
                            BookId = new Guid("869e9cc6-b60a-4ecb-8fe6-0d4887292e04"),
                            DateCreated = new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(8066),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("PublishedYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("869e9cc6-b60a-4ecb-8fe6-0d4887292e04"),
                            DateCreated = new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(7991),
                            IsDeleted = false,
                            Price = 1500.0,
                            PublishedYear = new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = new Guid("d7ca8e00-d754-410d-a056-f6469d5bf1cc"),
                            DateCreated = new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(8007),
                            IsDeleted = false,
                            Price = 1500.0,
                            PublishedYear = new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Kronik ne Gur"
                        },
                        new
                        {
                            Id = new Guid("47c676d5-76e7-40a1-b7d7-1bb6dd1f619d"),
                            DateCreated = new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(8012),
                            IsDeleted = false,
                            Price = 1500.0,
                            PublishedYear = new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Harry Potter"
                        });
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.BookRentals", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndRentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartRentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ClientId");

                    b.ToTable("BookRentals");
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.UserLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserLogins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("288fac2a-70ab-4142-bb58-2e0994b2e0fc"),
                            DateCreated = new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(8079),
                            IsDeleted = false,
                            Password = "1234",
                            Roles = "admin",
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.AuthorBook", b =>
                {
                    b.HasOne("MVC.In.Class.DataAcessLayer.Entities.Author", "Author")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.In.Class.DataAcessLayer.Entities.Book", "Book")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.BookRentals", b =>
                {
                    b.HasOne("MVC.In.Class.DataAcessLayer.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.In.Class.DataAcessLayer.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.Author", b =>
                {
                    b.Navigation("AuthorBooks");
                });

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.Book", b =>
                {
                    b.Navigation("AuthorBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
