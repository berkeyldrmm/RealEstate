using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Daire");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Daire",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Dukkan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Arsa",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
