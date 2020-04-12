using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingWebsite.Migrations
{
    public partial class SeedDataUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(MAX)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Products",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(MAX)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/Images/pic-2.jpg", "~/Images/pic-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/Images/pic-3.jpg", "~/Images/pic-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/Images/pic-1.jpg", "~/Images/pic-1.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "varchar(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Products",
                type: "varchar(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "pic-2.jpg", "pic-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "pic-3.jpg", "pic-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "pic-1.jpg", "pic-1.jpg" });
        }
    }
}
