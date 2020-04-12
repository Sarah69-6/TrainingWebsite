using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingWebsite.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Products",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Products",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Personalised Clothing", "Personalise Any Item of clothing for any occasion" },
                    { 2, "Personalised Soft Toys", "Personalise Any Soft Toy for any occasion" },
                    { 3, "Personalised Storage", "Personalise Any Item of storage for any item" },
                    { 4, "Personalised Ornaments", "Personalise Any Ornament for any occasion" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductsOfTheWeek", "LongDescription", "Price", "ProductName", "ShortDescription", "categoryId" },
                values: new object[,]
                {
                    { 1, "~/Images/pic-5.jpg","~/Images/pic-5.jpg", true, true, " Choose your color, choose your style and your message and we will create it for your perfect gift", 10m, "Personalised Baby Vest", "Create your own personalised baby vest", 1 },
                    { 2, "~/Images/pic-2.jpg", "~/Images/pic-2.jpg", true, true, " Choose your color, choose your style and your message and we will create it for your perfect gift", 10m, "Personalised Make-up Bag", "Create your own personalised Make-up bag", 2 },
                    { 3, "~/Images/pic-3.jpg", "~/Images/pic-3.jpg", true, true, " Choose your color, choose your style and your message and we will create it for your perfect gift", 10m, "Personalised Water Bottle", "Create your own personalised Water Bottle", 2 },
                    { 4, "~/Images/pic-1.jpg", "~/Images/pic-1.jpg", true, true, " Choose your color, choose your style and your message and we will create it for your perfect gift", 10m, "Personalised Container", "Create your own personalised Containers", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
