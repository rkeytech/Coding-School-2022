using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.EF.Migrations
{
    public partial class AddRelashionshipsByConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Engineers_ManagerID",
                table: "Engineers");

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_ManagerID",
                table: "Engineers",
                column: "ManagerID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Engineers_ManagerID",
                table: "Engineers");

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_ManagerID",
                table: "Engineers",
                column: "ManagerID");
        }
    }
}
