using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class init1016_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tytle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Cars" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Sport" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Food" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "Tytle", "time" },
                values: new object[,]
                {
                    { 1, "author1", "Sport cars are fast", 1, "Sport Cars", new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "author3", "Offroad cars can go anyware", 1, "Offroad Cars", new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "author3", "It is important for helthy life", 2, "Sport activities", new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "author2", "To do sport proffesionaly is hard and take a lots of time", 2, "Profesional Sport", new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "author2", "Healthy food is important part of healty life", 3, "Healty food", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "author1", "Is cheap and fast way to have a meal but  unhealty", 3, "fast food", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
