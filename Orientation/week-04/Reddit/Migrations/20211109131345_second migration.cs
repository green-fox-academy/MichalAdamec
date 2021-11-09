using Microsoft.EntityFrameworkCore.Migrations;

namespace Reddit.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "PostDatabase",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PostDatabase",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "PostDatabase");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "PostDatabase",
                newName: "Text");
        }
    }
}
