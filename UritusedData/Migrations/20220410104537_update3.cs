using Microsoft.EntityFrameworkCore.Migrations;

namespace UritusedData.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Isikukood",
                table: "Osalejad",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Isikukood",
                table: "Osalejad",
                type: "real",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
