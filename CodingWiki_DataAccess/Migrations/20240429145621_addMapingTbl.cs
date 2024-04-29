using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    public partial class addMapingTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMap_Authors_Author_Id1",
                table: "BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMap_Books_BookId",
                table: "BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Book_Fluent_Book_Id",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Publisher_Author_Author_Id",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookAuthorMap",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthorMap",
                table: "BookAuthorMap");

            migrationBuilder.RenameTable(
                name: "Fluent_BookAuthorMap",
                newName: "Fluent_BookAuthorMaps");

            migrationBuilder.RenameTable(
                name: "BookAuthorMap",
                newName: "BookAuthorMaps");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookAuthorMap_Author_Id",
                table: "Fluent_BookAuthorMaps",
                newName: "IX_Fluent_BookAuthorMaps_Author_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMap_BookId",
                table: "BookAuthorMaps",
                newName: "IX_BookAuthorMaps_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMap_Author_Id1",
                table: "BookAuthorMaps",
                newName: "IX_BookAuthorMaps_Author_Id1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookAuthorMaps",
                table: "Fluent_BookAuthorMaps",
                columns: new[] { "Book_Id", "Author_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthorMaps",
                table: "BookAuthorMaps",
                columns: new[] { "Book_Id", "Author_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMaps_Authors_Author_Id1",
                table: "BookAuthorMaps",
                column: "Author_Id1",
                principalTable: "Authors",
                principalColumn: "Author_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMaps_Books_BookId",
                table: "BookAuthorMaps",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMaps_Book_Fluent_Book_Id",
                table: "Fluent_BookAuthorMaps",
                column: "Book_Id",
                principalTable: "Book_Fluent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMaps_Publisher_Author_Author_Id",
                table: "Fluent_BookAuthorMaps",
                column: "Author_Id",
                principalTable: "Publisher_Author",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMaps_Authors_Author_Id1",
                table: "BookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMaps_Books_BookId",
                table: "BookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMaps_Book_Fluent_Book_Id",
                table: "Fluent_BookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMaps_Publisher_Author_Author_Id",
                table: "Fluent_BookAuthorMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookAuthorMaps",
                table: "Fluent_BookAuthorMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthorMaps",
                table: "BookAuthorMaps");

            migrationBuilder.RenameTable(
                name: "Fluent_BookAuthorMaps",
                newName: "Fluent_BookAuthorMap");

            migrationBuilder.RenameTable(
                name: "BookAuthorMaps",
                newName: "BookAuthorMap");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookAuthorMaps_Author_Id",
                table: "Fluent_BookAuthorMap",
                newName: "IX_Fluent_BookAuthorMap_Author_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMaps_BookId",
                table: "BookAuthorMap",
                newName: "IX_BookAuthorMap_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMaps_Author_Id1",
                table: "BookAuthorMap",
                newName: "IX_BookAuthorMap_Author_Id1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookAuthorMap",
                table: "Fluent_BookAuthorMap",
                columns: new[] { "Book_Id", "Author_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthorMap",
                table: "BookAuthorMap",
                columns: new[] { "Book_Id", "Author_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMap_Authors_Author_Id1",
                table: "BookAuthorMap",
                column: "Author_Id1",
                principalTable: "Authors",
                principalColumn: "Author_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMap_Books_BookId",
                table: "BookAuthorMap",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Book_Fluent_Book_Id",
                table: "Fluent_BookAuthorMap",
                column: "Book_Id",
                principalTable: "Book_Fluent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Publisher_Author_Author_Id",
                table: "Fluent_BookAuthorMap",
                column: "Author_Id",
                principalTable: "Publisher_Author",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
