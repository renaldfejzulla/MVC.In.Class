using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.In.Class.Migrations
{
    public partial class addedUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "UserLoginId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "BookDTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PublishedYear = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDTO", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthYear", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { new Guid("bc07b660-f6ac-4430-b2d5-420e7fa97a20"), new DateTime(1913, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2822), null, false, "JJR Tolkien" });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Password", "Roles", "UserName" },
                values: new object[] { new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d"), new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2765), null, false, "1234", "admin", "user" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("02a9bf31-5d40-40d1-b909-9d94d92bd15c"), new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2977), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kronik ne Gur", new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d") });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("798f4066-6bc5-4214-907e-bc4b67c08101"), new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2970), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit", new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d") });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Price", "PublishedYear", "Title", "UserLoginId" },
                values: new object[] { new Guid("c0764d67-204a-4ab8-a795-804c158aeece"), new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(2980), null, false, 1500.0, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter", new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d") });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId", "DateCreated", "DateUpdated", "IsDeleted" },
                values: new object[] { new Guid("53c0612c-8cb0-4a5a-9c6d-3bc2c263e82f"), new Guid("bc07b660-f6ac-4430-b2d5-420e7fa97a20"), new Guid("798f4066-6bc5-4214-907e-bc4b67c08101"), new DateTime(2023, 2, 12, 12, 5, 53, 591, DateTimeKind.Local).AddTicks(3023), null, false });

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserLoginId",
                table: "Books",
                column: "UserLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_UserLogins_UserLoginId",
                table: "Books",
                column: "UserLoginId",
                principalTable: "UserLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_UserLogins_UserLoginId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookDTO");

            migrationBuilder.DropIndex(
                name: "IX_Books_UserLoginId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: new Guid("53c0612c-8cb0-4a5a-9c6d-3bc2c263e82f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("02a9bf31-5d40-40d1-b909-9d94d92bd15c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c0764d67-204a-4ab8-a795-804c158aeece"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bc07b660-f6ac-4430-b2d5-420e7fa97a20"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("798f4066-6bc5-4214-907e-bc4b67c08101"));

            migrationBuilder.DeleteData(
                table: "UserLogins",
                keyColumn: "Id",
                keyValue: new Guid("a39947b1-f1b4-45db-b4e5-20ad1b1fb11d"));

            migrationBuilder.DropColumn(
                name: "UserLoginId",
                table: "Books");

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
    }
}
