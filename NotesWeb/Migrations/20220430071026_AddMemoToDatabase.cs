using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesWeb.Migrations
{
    public partial class AddMemoToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Memos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemoCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemoContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemoCreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memos");
        }
    }
}
