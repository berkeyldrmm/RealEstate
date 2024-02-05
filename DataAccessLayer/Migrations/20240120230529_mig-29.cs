using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig29 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mahalle",
                table: "Tarla",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Tarla",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Semt",
                table: "Tarla",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "AliciId",
                table: "Talepler",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Mahalle",
                table: "Dukkan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Dukkan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Semt",
                table: "Dukkan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mahalle",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Semt",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mahalle",
                table: "Daire",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Daire",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Semt",
                table: "Daire",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mahalle",
                table: "Arsa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Arsa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Semt",
                table: "Arsa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Talepler_Saticilar_AliciId",
                table: "Talepler",
                column: "AliciId",
                principalTable: "Saticilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talepler_Saticilar_AliciId",
                table: "Talepler");

            migrationBuilder.DropIndex(
                name: "IX_Talepler_AliciId",
                table: "Talepler");

            migrationBuilder.DropColumn(
                name: "Mahalle",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "Semt",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "Mahalle",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "Semt",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "Mahalle",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "Semt",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "Mahalle",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "Semt",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "Mahalle",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "Semt",
                table: "Arsa");

            migrationBuilder.AlterColumn<string>(
                name: "AliciId",
                table: "Talepler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }
    }
}
