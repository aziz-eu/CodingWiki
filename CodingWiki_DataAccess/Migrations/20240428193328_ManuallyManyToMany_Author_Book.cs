using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    public partial class ManuallyManyToMany_Author_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.CreateTable(
                name: "BookAuthorMap",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "int", nullable: false),
                    Book_Id = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    Author_Id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthorMap", x => new { x.Book_Id, x.Author_Id });
                    table.ForeignKey(
                        name: "FK_BookAuthorMap_Authors_Author_Id1",
                        column: x => x.Author_Id1,
                        principalTable: "Authors",
                        principalColumn: "Author_Id");
                    table.ForeignKey(
                        name: "FK_BookAuthorMap_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthorMap_Author_Id1",
                table: "BookAuthorMap",
                column: "Author_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthorMap_BookId",
                table: "BookAuthorMap",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthorMap");

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.Author_Id, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Authors",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");
        }
    }
}
