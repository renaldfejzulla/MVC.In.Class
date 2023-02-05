using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.In.Class.Migrations
{
    public partial class updateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("84d125d6-91dd-4a80-8d85-741f0ea7ae79"));

            migrationBuilder.DeleteData(
                table: "UserLogins",
                keyColumn: "Id",
                keyValue: new Guid("04d0c79c-8857-41f0-91a7-768e3ffa4cfc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("059c294e-a47b-4bbd-81db-a1b4a312e8fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e0e4cfc-2205-4e9b-a9ec-4418cba94f2c"));

            migrationBuilder.CreateTable(
                name: "BooksDto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PublishedYear = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksDto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthYear", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { new Guid("b1900894-b59f-4e09-a229-c9299d2b179b"), new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 14, 36, 41, 481, DateTimeKind.Local).AddTicks(1766), null, false, "JJR Tolkien" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title" },
                values: new object[,]
                {
                    { new Guid("3ae5f3cf-ac36-4764-9559-4bfc1314edc8"), new DateTime(2023, 2, 5, 14, 36, 41, 481, DateTimeKind.Local).AddTicks(1909), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit" },
                    { new Guid("a8cc4612-2500-4c1e-9547-a1b89d3b3991"), new DateTime(2023, 2, 5, 14, 36, 41, 481, DateTimeKind.Local).AddTicks(1988), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter" },
                    { new Guid("dead9b37-0c2f-41f5-b593-deaf04ae7350"), new DateTime(2023, 2, 5, 14, 36, 41, 481, DateTimeKind.Local).AddTicks(1968), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kronik ne gur" }
                });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Password", "Roles", "UserName" },
                values: new object[] { new Guid("a7e7c675-325c-43ee-ac71-4624d78a1243"), new DateTime(2023, 2, 5, 14, 36, 41, 481, DateTimeKind.Local).AddTicks(1029), null, false, "123", "admin", "edi" });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId", "DateCreated", "DateUpdated", "IsDeleted" },
                values: new object[] { new Guid("c2a6dde2-8608-43cb-95bf-641b17dd4050"), new Guid("b1900894-b59f-4e09-a229-c9299d2b179b"), new Guid("3ae5f3cf-ac36-4764-9559-4bfc1314edc8"), new DateTime(2023, 2, 5, 14, 36, 41, 481, DateTimeKind.Local).AddTicks(2036), null, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksDto");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("c2a6dde2-8608-43cb-95bf-641b17dd4050"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a8cc4612-2500-4c1e-9547-a1b89d3b3991"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dead9b37-0c2f-41f5-b593-deaf04ae7350"));

            migrationBuilder.DeleteData(
                table: "UserLogins",
                keyColumn: "Id",
                keyValue: new Guid("a7e7c675-325c-43ee-ac71-4624d78a1243"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b1900894-b59f-4e09-a229-c9299d2b179b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3ae5f3cf-ac36-4764-9559-4bfc1314edc8"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthYear", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { new Guid("059c294e-a47b-4bbd-81db-a1b4a312e8fc"), new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 20, 18, 11, 66, DateTimeKind.Local).AddTicks(2018), null, false, "JJR Tolkien" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title" },
                values: new object[] { new Guid("8e0e4cfc-2205-4e9b-a9ec-4418cba94f2c"), new DateTime(2023, 1, 21, 20, 18, 11, 66, DateTimeKind.Local).AddTicks(2073), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit" });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Password", "Roles", "UserName" },
                values: new object[] { new Guid("04d0c79c-8857-41f0-91a7-768e3ffa4cfc"), new DateTime(2023, 1, 21, 20, 18, 11, 66, DateTimeKind.Local).AddTicks(1593), null, false, "123", "admin", "edi" });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId", "DateCreated", "DateUpdated", "IsDeleted" },
                values: new object[] { new Guid("84d125d6-91dd-4a80-8d85-741f0ea7ae79"), new Guid("059c294e-a47b-4bbd-81db-a1b4a312e8fc"), new Guid("8e0e4cfc-2205-4e9b-a9ec-4418cba94f2c"), new DateTime(2023, 1, 21, 20, 18, 11, 66, DateTimeKind.Local).AddTicks(2129), null, false });
        }
    }
}
