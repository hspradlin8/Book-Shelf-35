using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf35.Migrations
{
    public partial class author_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a7578e2-d726-4c15-9c9c-24114fe3d274", "AQAAAAEAACcQAAAAEBoN+viAgKBSB0ys8oaeMs20w9TyVWP7039PxVmgtPDQAlASfRGt+ifk9QPfHNpxTA==" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuthorId",
                value: -3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3a66e74-b279-4856-b994-194ec1567888", "AQAAAAEAACcQAAAAEGp4rrcP5N8oBMrCE/w6ew7s+4WWLknLIZwWtrcbh2+e0iYTQtNsxEfpDnFKShsUbA==" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuthorId",
                value: 1);
        }
    }
}
