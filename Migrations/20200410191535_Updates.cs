using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingWebsite.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimages-na.ssl-images-amazon.com%2Fimages%2FI%2F61zpI2doUxL._AC_UL1200_.jpg&imgrefurl=https%3A%2F%2Fwww.amazon.co.uk%2FShopagift-Happy-Birthday-Daddy-Bodysuit%2Fdp%2FB075V38KC3&tbnid=BCPVLap64oCY9M&vet=12ahUKEwjGu_6SktPoAhUw1eAKHQVKBysQMyhOegUIARDfAw..i&docid=Sab7IpAO82DQ6M&w=974&h=1200&q=baby%20vest&ved=2ahUKEwjGu_6SktPoAhUw1eAKHQVKBysQMyhOegUIARDfAw", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimages-na.ssl-images-amazon.com%2Fimages%2FI%2F61zpI2doUxL._AC_UL1200_.jpg&imgrefurl=https%3A%2F%2Fwww.amazon.co.uk%2FShopagift-Happy-Birthday-Daddy-Bodysuit%2Fdp%2FB075V38KC3&tbnid=BCPVLap64oCY9M&vet=12ahUKEwjGu_6SktPoAhUw1eAKHQVKBysQMyhOegUIARDfAw..i&docid=Sab7IpAO82DQ6M&w=974&h=1200&q=baby%20vest&ved=2ahUKEwjGu_6SktPoAhUw1eAKHQVKBysQMyhOegUIARDfAw" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "pic-5.jpg", "pic-5.jpg" });
        }
    }
}
