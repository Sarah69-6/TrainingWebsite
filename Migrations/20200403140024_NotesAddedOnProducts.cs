using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingWebsite.Migrations
{
    public partial class NotesAddedOnProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Products",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "pic-5.jpg", "pic-5.jpg" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.notonthehighstreet.com%2Ffs%2F73%2F50%2Fe3c2-0e7b-4454-aaaa-a17f90d515c0%2Foriginal_baby-s-thoughts-personalised-baby-vest.jpg&imgrefurl=https%3A%2F%2Fwww.notonthehighstreet.com%2Flovetreedesign%2Fproduct%2Fbaby-s-thoughts-personalised-baby-vest&tbnid=ENo7oXMThUbcLM&vet=12ahUKEwjO14LTrMzoAhVJ44UKHdXKCSMQMygQegUIARCXBA..i&docid=VlZsgm5gDBhZrM&w=900&h=900&itg=1&q=personalised%20baby%20vest&ved=2ahUKEwjO14LTrMzoAhVJ44UKHdXKCSMQMygQegUIARCXBA", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.notonthehighstreet.com%2Ffs%2F73%2F50%2Fe3c2-0e7b-4454-aaaa-a17f90d515c0%2Foriginal_baby-s-thoughts-personalised-baby-vest.jpg&imgrefurl=https%3A%2F%2Fwww.notonthehighstreet.com%2Flovetreedesign%2Fproduct%2Fbaby-s-thoughts-personalised-baby-vest&tbnid=ENo7oXMThUbcLM&vet=12ahUKEwjO14LTrMzoAhVJ44UKHdXKCSMQMygQegUIARCXBA..i&docid=VlZsgm5gDBhZrM&w=900&h=900&itg=1&q=personalised%20baby%20vest&ved=2ahUKEwjO14LTrMzoAhVJ44UKHdXKCSMQMygQegUIARCXBA" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.notonthehighstreet.com%2Ffs%2F71%2Fb6%2F8b74-40e3-4423-a3d3-6f4c3b310c98%2Foriginal_black-make-up-case-with-gold-name.jpg&imgrefurl=https%3A%2F%2Fwww.notonthehighstreet.com%2Ftillyanna%2Fproduct%2Fblack-make-up-case-with-gold-name&tbnid=CWHGdp54qIn45M&vet=12ahUKEwjWqcKirczoAhUL8hoKHeLCB-gQMygEegUIARDnAw..i&docid=dsLIPlLBu5NWrM&w=900&h=900&q=personalised%20makeupbag&ved=2ahUKEwjWqcKirczoAhUL8hoKHeLCB-gQMygEegUIARDnAw", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.notonthehighstreet.com%2Ffs%2F71%2Fb6%2F8b74-40e3-4423-a3d3-6f4c3b310c98%2Foriginal_black-make-up-case-with-gold-name.jpg&imgrefurl=https%3A%2F%2Fwww.notonthehighstreet.com%2Ftillyanna%2Fproduct%2Fblack-make-up-case-with-gold-name&tbnid=CWHGdp54qIn45M&vet=12ahUKEwjWqcKirczoAhUL8hoKHeLCB-gQMygEegUIARDnAw..i&docid=dsLIPlLBu5NWrM&w=900&h=900&q=personalised%20makeupbag&ved=2ahUKEwjWqcKirczoAhUL8hoKHeLCB-gQMygEegUIARDnAw" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fi.etsystatic.com%2F9610540%2Fr%2Fil%2Fad6b60%2F1491677050%2Fil_570xN.1491677050_929h.jpg&imgrefurl=https%3A%2F%2Fwww.etsy.com%2Fno-en%2Flisting%2F611151275%2Fpersonalised-water-bottle-personalised&tbnid=sWX5ppmIcTmhcM&vet=12ahUKEwjq1uLVrczoAhUj-YUKHbT4Co8QMygHegUIARCUBA..i&docid=kplrE0Di_whHYM&w=570&h=428&itg=1&q=personalised%20water%20bottle&ved=2ahUKEwjq1uLVrczoAhUj-YUKHbT4Co8QMygHegUIARCUBA", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fi.etsystatic.com%2F9610540%2Fr%2Fil%2Fad6b60%2F1491677050%2Fil_570xN.1491677050_929h.jpg&imgrefurl=https%3A%2F%2Fwww.etsy.com%2Fno-en%2Flisting%2F611151275%2Fpersonalised-water-bottle-personalised&tbnid=sWX5ppmIcTmhcM&vet=12ahUKEwjq1uLVrczoAhUj-YUKHbT4Co8QMygHegUIARCUBA..i&docid=kplrE0Di_whHYM&w=570&h=428&itg=1&q=personalised%20water%20bottle&ved=2ahUKEwjq1uLVrczoAhUj-YUKHbT4Co8QMygHegUIARCUBA" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.etsy.com%2Fuk%2Fmarket%2Fpersonalised_storage&psig=AOvVaw1_wolBKZ7U14S2brSuegNE&ust=1586006847088000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIjX0YmuzOgCFQAAAAAdAAAAABAI", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.etsy.com%2Fuk%2Fmarket%2Fpersonalised_storage&psig=AOvVaw1_wolBKZ7U14S2brSuegNE&ust=1586006847088000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIjX0YmuzOgCFQAAAAAdAAAAABAI" });
        }
    }
}
