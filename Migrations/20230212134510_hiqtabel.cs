using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.In.Class.Migrations
{
    public partial class hiqtabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksDto");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("e95759b0-fdbd-4e15-95d0-405ef19b4fb0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5400ffd5-c85b-4591-8200-534a6f6044be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e6f65354-67d5-4346-a549-859f5ee7a7a6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4d37d2b5-706f-4138-ad8d-3883dc05b458"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fe9c11e7-937a-47fd-b25f-24a19e7008d7"));

            migrationBuilder.DeleteData(
                table: "UserLogins",
                keyColumn: "Id",
                keyValue: new Guid("887ae534-6e47-4019-8be4-4e0954ec3e4a"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthYear", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { new Guid("c9021b75-2caa-4fc8-a27b-e91155cd585a"), new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 14, 45, 10, 59, DateTimeKind.Local).AddTicks(3295), null, false, "JJR Tolkien" });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Password", "Roles", "UserName" },
                values: new object[] { new Guid("d1465d0c-2d00-44aa-a0d0-634efd18b4a7"), new DateTime(2023, 2, 12, 14, 45, 10, 59, DateTimeKind.Local).AddTicks(2977), null, false, "123", "admin", "edi" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("12f5c24b-a701-4147-839f-27aa503e2215"), new DateTime(2023, 2, 12, 14, 45, 10, 59, DateTimeKind.Local).AddTicks(3354), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter", new Guid("d1465d0c-2d00-44aa-a0d0-634efd18b4a7") });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("4ef518aa-1cb9-4ca1-9585-e66d5049dd3c"), new DateTime(2023, 2, 12, 14, 45, 10, 59, DateTimeKind.Local).AddTicks(3341), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kronik ne gur", new Guid("d1465d0c-2d00-44aa-a0d0-634efd18b4a7") });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("8669aa2f-649c-47ca-ace5-a78ff2b788df"), new DateTime(2023, 2, 12, 14, 45, 10, 59, DateTimeKind.Local).AddTicks(3321), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit", new Guid("d1465d0c-2d00-44aa-a0d0-634efd18b4a7") });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId", "DateCreated", "DateUpdated", "IsDeleted" },
                values: new object[] { new Guid("f476b87a-8c95-4565-bdc2-d0fb96c11b12"), new Guid("c9021b75-2caa-4fc8-a27b-e91155cd585a"), new Guid("8669aa2f-649c-47ca-ace5-a78ff2b788df"), new DateTime(2023, 2, 12, 14, 45, 10, 59, DateTimeKind.Local).AddTicks(3376), null, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("f476b87a-8c95-4565-bdc2-d0fb96c11b12"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12f5c24b-a701-4147-839f-27aa503e2215"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4ef518aa-1cb9-4ca1-9585-e66d5049dd3c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c9021b75-2caa-4fc8-a27b-e91155cd585a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8669aa2f-649c-47ca-ace5-a78ff2b788df"));

            migrationBuilder.DeleteData(
                table: "UserLogins",
                keyColumn: "Id",
                keyValue: new Guid("d1465d0c-2d00-44aa-a0d0-634efd18b4a7"));

            migrationBuilder.CreateTable(
                name: "BooksDto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PublishedYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksDto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthYear", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { new Guid("4d37d2b5-706f-4138-ad8d-3883dc05b458"), new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 11, 57, 29, 87, DateTimeKind.Local).AddTicks(7448), null, false, "JJR Tolkien" });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Password", "Roles", "UserName" },
                values: new object[] { new Guid("887ae534-6e47-4019-8be4-4e0954ec3e4a"), new DateTime(2023, 2, 12, 11, 57, 29, 87, DateTimeKind.Local).AddTicks(6992), null, false, "123", "admin", "edi" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("5400ffd5-c85b-4591-8200-534a6f6044be"), new DateTime(2023, 2, 12, 11, 57, 29, 87, DateTimeKind.Local).AddTicks(7535), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kronik ne gur", new Guid("887ae534-6e47-4019-8be4-4e0954ec3e4a") });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("e6f65354-67d5-4346-a549-859f5ee7a7a6"), new DateTime(2023, 2, 12, 11, 57, 29, 87, DateTimeKind.Local).AddTicks(7549), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter", new Guid("887ae534-6e47-4019-8be4-4e0954ec3e4a") });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("fe9c11e7-937a-47fd-b25f-24a19e7008d7"), new DateTime(2023, 2, 12, 11, 57, 29, 87, DateTimeKind.Local).AddTicks(7494), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit", new Guid("887ae534-6e47-4019-8be4-4e0954ec3e4a") });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId", "DateCreated", "DateUpdated", "IsDeleted" },
                values: new object[] { new Guid("e95759b0-fdbd-4e15-95d0-405ef19b4fb0"), new Guid("4d37d2b5-706f-4138-ad8d-3883dc05b458"), new Guid("fe9c11e7-937a-47fd-b25f-24a19e7008d7"), new DateTime(2023, 2, 12, 11, 57, 29, 87, DateTimeKind.Local).AddTicks(7573), null, false });
        }
    }
}
