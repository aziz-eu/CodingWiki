using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    public partial class setManyToManyManuallyBetween_FluentAuthor_FluentBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_AuthorFluent_Book",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_AuthorFluent_Book", x => new { x.Author_Id, x.BooksId });
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorFluent_Book_Book_Fluent_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Book_Fluent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorFluent_Book_Publisher_Author_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Publisher_Author",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_BookAuthorMap",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "int", nullable: false),
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_BookAuthorMap", x => new { x.Book_Id, x.Author_Id });
                    table.ForeignKey(
                        name: "FK_Fluent_BookAuthorMap_Book_Fluent_Book_Id",
                        column: x => x.Book_Id,
                        principalTable: "Book_Fluent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fluent_BookAuthorMap_Publisher_Author_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Publisher_Author",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_AuthorFluent_Book_BooksId",
                table: "Fluent_AuthorFluent_Book",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookAuthorMap_Author_Id",
                table: "Fluent_BookAuthorMap",
                column: "Author_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_AuthorFluent_Book");

            migrationBuilder.DropTable(
                name: "Fluent_BookAuthorMap");
        }
    }
}
