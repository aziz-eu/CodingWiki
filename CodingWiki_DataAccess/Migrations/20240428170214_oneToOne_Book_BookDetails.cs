using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    public partial class oneToOne_Book_BookDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "book_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_book_Details_Book_Id",
                table: "book_Details",
                column: "Book_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_book_Details_Books_Book_Id",
                table: "book_Details",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_Details_Books_Book_Id",
                table: "book_Details");

            migrationBuilder.DropIndex(
                name: "IX_book_Details_Book_Id",
                table: "book_Details");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "book_Details");
        }
    }
}
