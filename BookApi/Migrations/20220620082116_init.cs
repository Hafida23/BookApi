using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsRead = table.Column<bool>(nullable: false),
                    DateRead = table.Column<DateTime>(nullable: true),
                    Rate = table.Column<int>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "Rate", "Title" },
                values: new object[] { 1, "Author 1", new DateTime(2022, 6, 20, 10, 21, 16, 115, DateTimeKind.Local).AddTicks(5977), null, "Book with Id 1", "Kids", false, null, "Book nr 1" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "Rate", "Title" },
                values: new object[] { 2, "Author 2", new DateTime(2022, 6, 20, 10, 21, 16, 117, DateTimeKind.Local).AddTicks(9062), null, "Book with Id 2", "Kids", false, null, "Book nr 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
