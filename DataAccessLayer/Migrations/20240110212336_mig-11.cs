using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KrediyeUygun",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "GorselUrl",
                table: "Ilanlar");

            migrationBuilder.RenameColumn(
                name: "KrediyeUygun",
                table: "Arsa",
                newName: "TapuDurumu");

            migrationBuilder.AddColumn<string>(
                name: "Kimden",
                table: "Tarla",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "OdaSayisi",
                table: "Dukkan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AdaNo",
                table: "Dukkan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kimden",
                table: "Dukkan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "MetrekareFiyat",
                table: "Dukkan",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParselNo",
                table: "Dukkan",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MetrekareFiyat",
                table: "Depo",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Kimden",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "OdaSayisi",
                table: "Daire",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AdaNo",
                table: "Daire",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kimden",
                table: "Daire",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "MetrekareFiyat",
                table: "Daire",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParselNo",
                table: "Daire",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParselNo.",
                table: "Arsa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PaftaNo.",
                table: "Arsa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdaNo.",
                table: "Arsa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kimden",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "AdaNo",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "Kimden",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "MetrekareFiyat",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "ParselNo",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "Kimden",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "AdaNo",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "Kimden",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "MetrekareFiyat",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "ParselNo",
                table: "Daire");

            migrationBuilder.RenameColumn(
                name: "TapuDurumu",
                table: "Arsa",
                newName: "KrediyeUygun");

            migrationBuilder.AddColumn<bool>(
                name: "KrediyeUygun",
                table: "Tarla",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GorselUrl",
                table: "Ilanlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "OdaSayisi",
                table: "Dukkan",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MetrekareFiyat",
                table: "Depo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OdaSayisi",
                table: "Daire",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ParselNo.",
                table: "Arsa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaftaNo.",
                table: "Arsa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdaNo.",
                table: "Arsa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
