using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BalkonSayisi",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "BanyoSayisi",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "SiteMi",
                table: "Dukkan");

            migrationBuilder.RenameColumn(
                name: "Metrekare",
                table: "Tarla",
                newName: "MetrekareNet");

            migrationBuilder.RenameColumn(
                name: "TalepTipi",
                table: "Talepler",
                newName: "PortfoyId");

            migrationBuilder.RenameColumn(
                name: "Alici",
                table: "Talepler",
                newName: "IlanTalepTipiId");

            migrationBuilder.RenameColumn(
                name: "Satici",
                table: "Ilanlar",
                newName: "PortfoyId");

            migrationBuilder.RenameColumn(
                name: "IlanTipi",
                table: "Ilanlar",
                newName: "IlanTalepTipiId");

            migrationBuilder.RenameColumn(
                name: "Metrekare",
                table: "Depo",
                newName: "MetrekareNet");

            migrationBuilder.RenameColumn(
                name: "Metrekare",
                table: "Arsa",
                newName: "MetrekareNet");

            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Tarla",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Tarla",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Tarla",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AliciId",
                table: "Talepler",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "KayitTarihi",
                table: "Talepler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Talepler",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Saticilar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "KayitTarihi",
                table: "Ilanlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SaticiId",
                table: "Ilanlar",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Ilanlar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "MetrekareNet",
                table: "Dukkan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Alicilar",
                type: "nvarchar(450)",
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

            migrationBuilder.CreateIndex(
                name: "IX_Talepler_AliciId",
                table: "Talepler",
                column: "AliciId");

            migrationBuilder.CreateIndex(
                name: "IX_Talepler_IlanTalepTipiId",
                table: "Talepler",
                column: "IlanTalepTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Talepler_UserId",
                table: "Talepler",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Saticilar_UserId",
                table: "Saticilar",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_IlanTalepTipiId",
                table: "Ilanlar",
                column: "IlanTalepTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_SaticiId",
                table: "Ilanlar",
                column: "SaticiId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_UserId",
                table: "Ilanlar",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Dukkan_IlanId",
                table: "Dukkan",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Dukkan_TalepId",
                table: "Dukkan",
                column: "TalepId");

            migrationBuilder.CreateIndex(
                name: "IX_Depo_IlanId",
                table: "Depo",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Depo_TalepId",
                table: "Depo",
                column: "TalepId");

            migrationBuilder.CreateIndex(
                name: "IX_Daire_IlanId",
                table: "Daire",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Daire_TalepId",
                table: "Daire",
                column: "TalepId");

            migrationBuilder.CreateIndex(
                name: "IX_Arsa_IlanId",
                table: "Arsa",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Arsa_TalepId",
                table: "Arsa",
                column: "TalepId");

            migrationBuilder.CreateIndex(
                name: "IX_Alicilar_UserId",
                table: "Alicilar",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alicilar_AspNetUsers_UserId",
                table: "Alicilar",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Ilanlar_AspNetUsers_UserId",
                table: "Ilanlar",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilanlar_IlanTalepTipleri_IlanTalepTipiId",
                table: "Ilanlar",
                column: "IlanTalepTipiId",
                principalTable: "IlanTalepTipleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilanlar_Saticilar_SaticiId",
                table: "Ilanlar",
                column: "SaticiId",
                principalTable: "Saticilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saticilar_AspNetUsers_UserId",
                table: "Saticilar",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Talepler_Alicilar_AliciId",
                table: "Talepler",
                column: "AliciId",
                principalTable: "Alicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Talepler_AspNetUsers_UserId",
                table: "Talepler",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Talepler_IlanTalepTipleri_IlanTalepTipiId",
                table: "Talepler",
                column: "IlanTalepTipiId",
                principalTable: "IlanTalepTipleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alicilar_AspNetUsers_UserId",
                table: "Alicilar");

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
                name: "FK_Ilanlar_AspNetUsers_UserId",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilanlar_IlanTalepTipleri_IlanTalepTipiId",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilanlar_Saticilar_SaticiId",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Saticilar_AspNetUsers_UserId",
                table: "Saticilar");

            migrationBuilder.DropForeignKey(
                name: "FK_Talepler_Alicilar_AliciId",
                table: "Talepler");

            migrationBuilder.DropForeignKey(
                name: "FK_Talepler_AspNetUsers_UserId",
                table: "Talepler");

            migrationBuilder.DropForeignKey(
                name: "FK_Talepler_IlanTalepTipleri_IlanTalepTipiId",
                table: "Talepler");

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

            migrationBuilder.DropIndex(
                name: "IX_Talepler_AliciId",
                table: "Talepler");

            migrationBuilder.DropIndex(
                name: "IX_Talepler_IlanTalepTipiId",
                table: "Talepler");

            migrationBuilder.DropIndex(
                name: "IX_Talepler_UserId",
                table: "Talepler");

            migrationBuilder.DropIndex(
                name: "IX_Saticilar_UserId",
                table: "Saticilar");

            migrationBuilder.DropIndex(
                name: "IX_Ilanlar_IlanTalepTipiId",
                table: "Ilanlar");

            migrationBuilder.DropIndex(
                name: "IX_Ilanlar_SaticiId",
                table: "Ilanlar");

            migrationBuilder.DropIndex(
                name: "IX_Ilanlar_UserId",
                table: "Ilanlar");

            migrationBuilder.DropIndex(
                name: "IX_Dukkan_IlanId",
                table: "Dukkan");

            migrationBuilder.DropIndex(
                name: "IX_Dukkan_TalepId",
                table: "Dukkan");

            migrationBuilder.DropIndex(
                name: "IX_Depo_IlanId",
                table: "Depo");

            migrationBuilder.DropIndex(
                name: "IX_Depo_TalepId",
                table: "Depo");

            migrationBuilder.DropIndex(
                name: "IX_Daire_IlanId",
                table: "Daire");

            migrationBuilder.DropIndex(
                name: "IX_Daire_TalepId",
                table: "Daire");

            migrationBuilder.DropIndex(
                name: "IX_Arsa_IlanId",
                table: "Arsa");

            migrationBuilder.DropIndex(
                name: "IX_Arsa_TalepId",
                table: "Arsa");

            migrationBuilder.DropIndex(
                name: "IX_Alicilar_UserId",
                table: "Alicilar");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "AliciId",
                table: "Talepler");

            migrationBuilder.DropColumn(
                name: "KayitTarihi",
                table: "Talepler");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Talepler");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Saticilar");

            migrationBuilder.DropColumn(
                name: "KayitTarihi",
                table: "Ilanlar");

            migrationBuilder.DropColumn(
                name: "SaticiId",
                table: "Ilanlar");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ilanlar");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Alicilar");

            migrationBuilder.RenameColumn(
                name: "MetrekareNet",
                table: "Tarla",
                newName: "Metrekare");

            migrationBuilder.RenameColumn(
                name: "PortfoyId",
                table: "Talepler",
                newName: "TalepTipi");

            migrationBuilder.RenameColumn(
                name: "IlanTalepTipiId",
                table: "Talepler",
                newName: "Alici");

            migrationBuilder.RenameColumn(
                name: "PortfoyId",
                table: "Ilanlar",
                newName: "Satici");

            migrationBuilder.RenameColumn(
                name: "IlanTalepTipiId",
                table: "Ilanlar",
                newName: "IlanTipi");

            migrationBuilder.RenameColumn(
                name: "MetrekareNet",
                table: "Depo",
                newName: "Metrekare");

            migrationBuilder.RenameColumn(
                name: "MetrekareNet",
                table: "Arsa",
                newName: "Metrekare");

            migrationBuilder.AlterColumn<int>(
                name: "MetrekareNet",
                table: "Dukkan",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BalkonSayisi",
                table: "Dukkan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanyoSayisi",
                table: "Dukkan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SiteMi",
                table: "Dukkan",
                type: "bit",
                nullable: true);
        }
    }
}
