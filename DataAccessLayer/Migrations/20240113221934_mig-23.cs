using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ilanlar_Arsa",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilanlar_Daire",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilanlar_Depo",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilanlar_Dukkan",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilanlar_Tarla",
                table: "Ilanlar");

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Tarla",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarla_IlanId",
                table: "Tarla",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Dukkan_IlanId",
                table: "Dukkan",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Depo_IlanId",
                table: "Depo",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Daire_IlanId",
                table: "Daire",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Arsa_IlanId",
                table: "Arsa",
                column: "IlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arsa_Ilanlar_IlanId",
                table: "Arsa",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Daire_Ilanlar_IlanId",
                table: "Daire",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Depo_Ilanlar_IlanId",
                table: "Depo",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dukkan_Ilanlar_IlanId",
                table: "Dukkan",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Ilanlar_IlanId",
                table: "Tarla",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arsa_Ilanlar_IlanId",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Ilanlar_IlanId",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Ilanlar_IlanId",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Ilanlar_IlanId",
                table: "Ilanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Ilanlar_IlanId",
                table: "Ilanlar");

            migrationBuilder.DropIndex(
                name: "IX_Tarla_IlanId",
                table: "Tarla");

            migrationBuilder.DropIndex(
                name: "IX_Dukkan_IlanId",
                table: "Dukkan");

            migrationBuilder.DropIndex(
                name: "IX_Depo_IlanId",
                table: "Depo");

            migrationBuilder.DropIndex(
                name: "IX_Daire_IlanId",
                table: "Daire");

            migrationBuilder.DropIndex(
                name: "IX_Arsa_IlanId",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Arsa");

            migrationBuilder.AddForeignKey(
                name: "FK_Ilanlar_Arsa",
                table: "Arsa",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilanlar_Daire",
                table: "Daire",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilanlar_Depo",
                table: "Depo",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilanlar_Dukkan",
                table: "Dukkan",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilanlar_Tarla",
                table: "Tarla",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
