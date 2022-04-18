using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UritusedData.Migrations
{
    public partial class Addentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Perenimi",
                table: "Osalejad",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Makseviis",
                table: "Osalejad",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Eesnimi",
                table: "Osalejad",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UritusedId",
                table: "Osalejad",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Uritused",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uritusenimi = table.Column<string>(nullable: false),
                    Toimumisaeg = table.Column<DateTime>(nullable: false),
                    Kohat = table.Column<string>(nullable: false),
                    Lisainfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uritused", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Osalejad_UritusedId",
                table: "Osalejad",
                column: "UritusedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Osalejad_Uritused_UritusedId",
                table: "Osalejad",
                column: "UritusedId",
                principalTable: "Uritused",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Osalejad_Uritused_UritusedId",
                table: "Osalejad");

            migrationBuilder.DropTable(
                name: "Uritused");

            migrationBuilder.DropIndex(
                name: "IX_Osalejad_UritusedId",
                table: "Osalejad");

            migrationBuilder.DropColumn(
                name: "UritusedId",
                table: "Osalejad");

            migrationBuilder.AlterColumn<string>(
                name: "Perenimi",
                table: "Osalejad",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Makseviis",
                table: "Osalejad",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Eesnimi",
                table: "Osalejad",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
