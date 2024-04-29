using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    public partial class setOneToManyRelation_Booktbl_PublisherTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "Book_Fluent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_Fluent_Publisher_Id",
                table: "Book_Fluent",
                column: "Publisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Fluent_Publisher_Fluent_Publisher_Id",
                table: "Book_Fluent",
                column: "Publisher_Id",
                principalTable: "Publisher_Fluent",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Fluent_Publisher_Fluent_Publisher_Id",
                table: "Book_Fluent");

            migrationBuilder.DropIndex(
                name: "IX_Book_Fluent_Publisher_Id",
                table: "Book_Fluent");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "Book_Fluent");
        }
    }
}
