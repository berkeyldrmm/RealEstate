using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fiyat",
                table: "Ilanlar",
                newName: "PortfoyFiyati");

            migrationBuilder.AddColumn<decimal>(
                name: "IlanFiyati",
                table: "Ilanlar",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanFiyati",
                table: "Ilanlar");

            migrationBuilder.RenameColumn(
                name: "PortfoyFiyati",
                table: "Ilanlar",
                newName: "Fiyat");
        }
    }
}
