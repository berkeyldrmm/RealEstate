using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GorselUrl",
                table: "Ilanlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Kazanc",
                table: "Ilanlar",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Komisyon",
                table: "Ilanlar",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "SatisDurumu",
                table: "Ilanlar",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GorselUrl",
                table: "Ilanlar");

            migrationBuilder.DropColumn(
                name: "Kazanc",
                table: "Ilanlar");

            migrationBuilder.DropColumn(
                name: "Komisyon",
                table: "Ilanlar");

            migrationBuilder.DropColumn(
                name: "SatisDurumu",
                table: "Ilanlar");
        }
    }
}
