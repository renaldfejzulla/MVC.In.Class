using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.In.Class.Migrations
{
    public partial class UpdatedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("812e4f0f-946d-4020-b042-8d1883c12400"));

            migrationBuilder.DeleteData(
                table: "UserLogins",
                keyColumn: "Id",
                keyValue: new Guid("0ac32865-875d-4a1a-8772-a9fd307c67e3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4ff80455-07ad-4c21-9276-6310d25da30c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df9b1124-2fc9-462e-89c1-1db26fccfe40"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthYear", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { new Guid("fb84bfac-70b3-4896-9833-a8d2a3bfbdff"), new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(7726), null, false, "JJR Tolkien" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title" },
                values: new object[,]
                {
                    { new Guid("47c676d5-76e7-40a1-b7d7-1bb6dd1f619d"), new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(8012), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter" },
                    { new Guid("869e9cc6-b60a-4ecb-8fe6-0d4887292e04"), new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(7991), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit" },
                    { new Guid("d7ca8e00-d754-410d-a056-f6469d5bf1cc"), new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(8007), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kronik ne Gur" }
                });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Password", "Roles", "UserName" },
                values: new object[] { new Guid("288fac2a-70ab-4142-bb58-2e0994b2e0fc"), new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(8079), null, false, "1234", "admin", "user" });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId", "DateCreated", "DateUpdated", "IsDeleted" },
                values: new object[] { new Guid("97e1ebb9-cd7a-4ecb-952e-87e132da430d"), new Guid("fb84bfac-70b3-4896-9833-a8d2a3bfbdff"), new Guid("869e9cc6-b60a-4ecb-8fe6-0d4887292e04"), new DateTime(2023, 2, 5, 14, 0, 38, 274, DateTimeKind.Local).AddTicks(8066), null, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("97e1ebb9-cd7a-4ecb-952e-87e132da430d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("47c676d5-76e7-40a1-b7d7-1bb6dd1f619d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d7ca8e00-d754-410d-a056-f6469d5bf1cc"));

            migrationBuilder.DeleteData(
                table: "UserLogins",
                keyColumn: "Id",
                keyValue: new Guid("288fac2a-70ab-4142-bb58-2e0994b2e0fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fb84bfac-70b3-4896-9833-a8d2a3bfbdff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("869e9cc6-b60a-4ecb-8fe6-0d4887292e04"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthYear", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { new Guid("4ff80455-07ad-4c21-9276-6310d25da30c"), new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 9, 50, 47, 480, DateTimeKind.Local).AddTicks(8432), null, false, "JJR Tolkien" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title" },
                values: new object[] { new Guid("df9b1124-2fc9-462e-89c1-1db26fccfe40"), new DateTime(2023, 1, 22, 9, 50, 47, 480, DateTimeKind.Local).AddTicks(8691), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit" });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Password", "Roles", "UserName" },
                values: new object[] { new Guid("0ac32865-875d-4a1a-8772-a9fd307c67e3"), new DateTime(2023, 1, 22, 9, 50, 47, 480, DateTimeKind.Local).AddTicks(8816), null, false, "1234", "admin", "user" });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId", "DateCreated", "DateUpdated", "IsDeleted" },
                values: new object[] { new Guid("812e4f0f-946d-4020-b042-8d1883c12400"), new Guid("4ff80455-07ad-4c21-9276-6310d25da30c"), new Guid("df9b1124-2fc9-462e-89c1-1db26fccfe40"), new DateTime(2023, 1, 22, 9, 50, 47, 480, DateTimeKind.Local).AddTicks(8783), null, false });
        }
    }
}
