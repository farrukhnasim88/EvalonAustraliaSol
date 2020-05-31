using Microsoft.EntityFrameworkCore.Migrations;

namespace EvalonAustralia.Data.Migrations
{
    public partial class AddedCompanyClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "People",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_CompanyId",
                table: "People",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Companies_CompanyId",
                table: "People",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Companies_CompanyId",
                table: "People");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_People_CompanyId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "People");
        }
    }
}
