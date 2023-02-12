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
    [Migration("20230212110554_addedUserId")]
    partial class addedUserId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.DTO.BookDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("PublishedYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookDTO");
                });

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
                            Id = new Guid("bc07b660-f6ac-4430-b2d5-420e7fa97a20"),
                            BirthYear = new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2822),
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
                            Id = new Guid("53c0612c-8cb0-4a5a-9c6d-3bc2c263e82f"),
                            AuthorId = new Guid("bc07b660-f6ac-4430-b2d5-420e7fa97a20"),
                            BookId = new Guid("798f4066-6bc5-4214-907e-bc4b67c08101"),
                            DateCreated = new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(3023),
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

                    b.Property<Guid>("UserLoginId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserLoginId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("798f4066-6bc5-4214-907e-bc4b67c08101"),
                            DateCreated = new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2970),
                            IsDeleted = false,
                            Price = 1500.0,
                            PublishedYear = new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hobbit",
                            UserLoginId = new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d")
                        },
                        new
                        {
                            Id = new Guid("02a9bf31-5d40-40d1-b909-9d94d92bd15c"),
                            DateCreated = new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2977),
                            IsDeleted = false,
                            Price = 1500.0,
                            PublishedYear = new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Kronik ne Gur",
                            UserLoginId = new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d")
                        },
                        new
                        {
                            Id = new Guid("c0764d67-204a-4ab8-a795-804c158aeece"),
                            DateCreated = new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2980),
                            IsDeleted = false,
                            Price = 1500.0,
                            PublishedYear = new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Harry Potter",
                            UserLoginId = new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d")
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
                            Id = new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d"),
                            DateCreated = new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2765),
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

            modelBuilder.Entity("MVC.In.Class.DataAcessLayer.Entities.Book", b =>
                {
                    b.HasOne("MVC.In.Class.DataAcessLayer.Entities.UserLogin", "UserLogin")
                        .WithMany()
                        .HasForeignKey("UserLoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserLogin");
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