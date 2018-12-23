using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicBase.EfSqlRepository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    SiteUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Volume = table.Column<int>(nullable: false),
                    IssueNumber = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Issues_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Active", "Created", "Name", "SiteUrl", "Updated" },
                values: new object[] { 1, true, new DateTime(2018, 12, 22, 23, 18, 51, 142, DateTimeKind.Local).AddTicks(5286), "Marvel", "http://www.marvel.com", new DateTime(2018, 12, 22, 23, 18, 51, 142, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Active", "Created", "IssueNumber", "PublisherId", "Title", "Updated", "Volume", "Year" },
                values: new object[] { 1, true, new DateTime(2018, 12, 22, 23, 18, 51, 140, DateTimeKind.Local).AddTicks(606), 1, 1, "X-Men", new DateTime(2018, 12, 22, 23, 18, 51, 142, DateTimeKind.Local).AddTicks(465), 1, 1964 });

            migrationBuilder.CreateIndex(
                name: "IX_Issues_PublisherId",
                table: "Issues",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
