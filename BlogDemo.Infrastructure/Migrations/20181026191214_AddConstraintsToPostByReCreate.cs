using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BlogDemo.Infrastructure.Migrations
{
    public partial class AddConstraintsToPostByReCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    nvarcharmax = table.Column<string>(name: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(maxLength: 50, nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}