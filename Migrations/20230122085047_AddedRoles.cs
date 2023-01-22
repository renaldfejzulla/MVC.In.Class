using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.In.Class.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("ed7c982b-ab62-45ae-8225-9ad11b2b6df7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cc4def90-0ba4-4f47-bdbc-e259de499135"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9d923315-ba71-4f3c-a201-585474a909a3"));

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("812e4f0f-946d-4020-b042-8d1883c12400"));

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
                values: new object[] { new Guid("cc4def90-0ba4-4f47-bdbc-e259de499135"), new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 12, 30, 28, 24, DateTimeKind.Local).AddTicks(2132), null, false, "JJR Tolkien" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title" },
                values: new object[] { new Guid("9d923315-ba71-4f3c-a201-585474a909a3"), new DateTime(2023, 1, 21, 12, 30, 28, 24, DateTimeKind.Local).AddTicks(2523), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit" });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId", "DateCreated", "DateUpdated", "IsDeleted" },
                values: new object[] { new Guid("ed7c982b-ab62-45ae-8225-9ad11b2b6df7"), new Guid("cc4def90-0ba4-4f47-bdbc-e259de499135"), new Guid("9d923315-ba71-4f3c-a201-585474a909a3"), new DateTime(2023, 1, 21, 12, 30, 28, 24, DateTimeKind.Local).AddTicks(2583), null, false });
        }
    }
}
