using Microsoft.EntityFrameworkCore.Migrations;

namespace UritusedData.Migrations
{
    public partial class Addentitymodels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kohat",
                table: "Uritused");

            migrationBuilder.AddColumn<string>(
                name: "Koht",
                table: "Uritused",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Koht",
                table: "Uritused");

            migrationBuilder.AddColumn<string>(
                name: "Kohat",
                table: "Uritused",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
