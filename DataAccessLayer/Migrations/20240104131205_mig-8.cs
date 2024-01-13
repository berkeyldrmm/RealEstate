using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arsa_Ilanlar_IlanId",
                table: "Arsa");

            migrationBuilder.DropForeignKey(
                name: "FK_Arsa_Talepler_TalepId",
                table: "Arsa");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Ilanlar_IlanId",
                table: "Daire");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Talepler_TalepId",
                table: "Daire");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Ilanlar_IlanId",
                table: "Depo");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Talepler_TalepId",
                table: "Depo");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Ilanlar_IlanId",
                table: "Dukkan");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Talepler_TalepId",
                table: "Dukkan");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Ilanlar_IlanId",
                table: "Tarla");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Talepler_TalepId",
                table: "Tarla");

            migrationBuilder.DropIndex(
                name: "IX_Tarla_IlanId",
                table: "Tarla");

            migrationBuilder.DropIndex(
                name: "IX_Tarla_TalepId",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "SatilikKiralik",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "SatilikKiralik",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "SatilikKiralik",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "SatilikKiralik",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "SatilikKiralik",
                table: "Arsa");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Tarla",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Tarla",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.CreateIndex(
                name: "IX_Tarla_IlanId",
                table: "Tarla",
                column: "IlanId",
                unique: true,
                filter: "[IlanId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tarla_TalepId",
                table: "Tarla",
                column: "TalepId",
                unique: true,
                filter: "[TalepId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Arsa_Ilanlar_IlanId",
                table: "Arsa",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arsa_Talepler_TalepId",
                table: "Arsa",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Daire_Ilanlar_IlanId",
                table: "Daire",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Daire_Talepler_TalepId",
                table: "Daire",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Depo_Ilanlar_IlanId",
                table: "Depo",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Depo_Talepler_TalepId",
                table: "Depo",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dukkan_Ilanlar_IlanId",
                table: "Dukkan",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dukkan_Talepler_TalepId",
                table: "Dukkan",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Ilanlar_IlanId",
                table: "Tarla",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Talepler_TalepId",
                table: "Tarla",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arsa_Ilanlar_IlanId",
                table: "Arsa");

            migrationBuilder.DropForeignKey(
                name: "FK_Arsa_Talepler_TalepId",
                table: "Arsa");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Ilanlar_IlanId",
                table: "Daire");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Talepler_TalepId",
                table: "Daire");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Ilanlar_IlanId",
                table: "Depo");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Talepler_TalepId",
                table: "Depo");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Ilanlar_IlanId",
                table: "Dukkan");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Talepler_TalepId",
                table: "Dukkan");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Ilanlar_IlanId",
                table: "Tarla");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Talepler_TalepId",
                table: "Tarla");

            migrationBuilder.DropIndex(
                name: "IX_Tarla_IlanId",
                table: "Tarla");

            migrationBuilder.DropIndex(
                name: "IX_Tarla_TalepId",
                table: "Tarla");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Tarla",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Tarla",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Tarla",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SatilikKiralik",
                table: "Tarla",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Dukkan",
                type: "decimal(18,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SatilikKiralik",
                table: "Dukkan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Depo",
                type: "decimal(18,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SatilikKiralik",
                table: "Depo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Daire",
                type: "decimal(18,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SatilikKiralik",
                table: "Daire",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TalepId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IlanId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Arsa",
                type: "decimal(18,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SatilikKiralik",
                table: "Arsa",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tarla_IlanId",
                table: "Tarla",
                column: "IlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarla_TalepId",
                table: "Tarla",
                column: "TalepId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Arsa_Ilanlar_IlanId",
                table: "Arsa",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arsa_Talepler_TalepId",
                table: "Arsa",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Daire_Ilanlar_IlanId",
                table: "Daire",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Daire_Talepler_TalepId",
                table: "Daire",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depo_Ilanlar_IlanId",
                table: "Depo",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depo_Talepler_TalepId",
                table: "Depo",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dukkan_Ilanlar_IlanId",
                table: "Dukkan",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dukkan_Talepler_TalepId",
                table: "Dukkan",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Ilanlar_IlanId",
                table: "Tarla",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Talepler_TalepId",
                table: "Tarla",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
