using Microsoft.EntityFrameworkCore.Migrations;

namespace UritusedData.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Isikukood",
                table: "Osalejad",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Isikukood",
                table: "Osalejad",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
