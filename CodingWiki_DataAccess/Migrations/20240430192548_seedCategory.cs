using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    public partial class seedCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Categories VALUES ('cat 1')");
            migrationBuilder.Sql("Insert Into Categories VALUES ('cat 2')");
            migrationBuilder.Sql("Insert Into Categories VALUES ('cat 3')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
