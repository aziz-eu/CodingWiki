using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    public partial class setOneToOneRelation_FluentBook_FluentBookDetailTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Fluent_Publisher_Fluent_Fluent_PublisherPublisher_Id",
                table: "Book_Fluent");

            migrationBuilder.DropIndex(
                name: "IX_Book_Fluent_Fluent_PublisherPublisher_Id",
                table: "Book_Fluent");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherPublisher_Id",
                table: "Book_Fluent");

            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "Fluent_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Details_Book_Id",
                table: "Fluent_Details",
                column: "Book_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Details_Book_Fluent_Book_Id",
                table: "Fluent_Details",
                column: "Book_Id",
                principalTable: "Book_Fluent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Details_Book_Fluent_Book_Id",
                table: "Fluent_Details");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Details_Book_Id",
                table: "Fluent_Details");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "Fluent_Details");

            migrationBuilder.AddColumn<int>(
                name: "Fluent_PublisherPublisher_Id",
                table: "Book_Fluent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_Fluent_Fluent_PublisherPublisher_Id",
                table: "Book_Fluent",
                column: "Fluent_PublisherPublisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Fluent_Publisher_Fluent_Fluent_PublisherPublisher_Id",
                table: "Book_Fluent",
                column: "Fluent_PublisherPublisher_Id",
                principalTable: "Publisher_Fluent",
                principalColumn: "Publisher_Id");
        }
    }
}
