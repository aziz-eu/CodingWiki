using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    public partial class UseFluentAPIForFluentAuthorTblAndFluentPublisherTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fluent_PublisherPublisher_Id",
                table: "Book_Fluent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publisher_Author",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher_Author", x => x.Author_Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher_Fluent",
                columns: table => new
                {
                    Publisher_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher_Fluent", x => x.Publisher_Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Fluent_Publisher_Fluent_Fluent_PublisherPublisher_Id",
                table: "Book_Fluent");

            migrationBuilder.DropTable(
                name: "Publisher_Author");

            migrationBuilder.DropTable(
                name: "Publisher_Fluent");

            migrationBuilder.DropIndex(
                name: "IX_Book_Fluent_Fluent_PublisherPublisher_Id",
                table: "Book_Fluent");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherPublisher_Id",
                table: "Book_Fluent");
        }
    }
}
