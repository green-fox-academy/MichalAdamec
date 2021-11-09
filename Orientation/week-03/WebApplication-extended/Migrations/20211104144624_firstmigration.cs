using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.RenameTable(
                name: "Todos",
                newName: "ToDoDatabase");

            migrationBuilder.AddColumn<long>(
                name: "AssigneeId",
                table: "ToDoDatabase",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "ToDoDatabase",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoDatabase",
                table: "ToDoDatabase",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AssigneeDatabase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssigneeDatabase", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ToDoDatabase_AssigneeId",
                table: "ToDoDatabase",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoDatabase_AssigneeDatabase_AssigneeId",
                table: "ToDoDatabase",
                column: "AssigneeId",
                principalTable: "AssigneeDatabase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoDatabase_AssigneeDatabase_AssigneeId",
                table: "ToDoDatabase");

            migrationBuilder.DropTable(
                name: "AssigneeDatabase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoDatabase",
                table: "ToDoDatabase");

            migrationBuilder.DropIndex(
                name: "IX_ToDoDatabase_AssigneeId",
                table: "ToDoDatabase");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "ToDoDatabase");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "ToDoDatabase");

            migrationBuilder.RenameTable(
                name: "ToDoDatabase",
                newName: "Todos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "Id");
        }
    }
}
