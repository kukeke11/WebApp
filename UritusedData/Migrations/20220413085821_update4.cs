using Microsoft.EntityFrameworkCore.Migrations;

namespace UritusedData.Migrations
{
    public partial class update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ettevotted",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EttevõtteNimi = table.Column<string>(nullable: false),
                    EttevõtteRegistrikood = table.Column<long>(nullable: false),
                    OsalejateArv = table.Column<int>(nullable: false),
                    Makseviis = table.Column<int>(nullable: false),
                    Lisainfo = table.Column<string>(nullable: true),
                    UritusedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ettevotted", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ettevotted_Uritused_UritusedId",
                        column: x => x.UritusedId,
                        principalTable: "Uritused",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ettevotted_UritusedId",
                table: "Ettevotted",
                column: "UritusedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ettevotted");
        }
    }
}
