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
                name: "FK_Arsa_Ilanlar",
                table: "Arsa");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Ilanlar",
                table: "Depo");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Ilanlar",
                table: "Dukkan");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Ilanlar",
                table: "Daire");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Ilanlar",
                table: "Tarla");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Dukkan_Ilanlar",
                table: "Dukkan",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arsa_Ilanlar",
                table: "Arsa",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Ilanlar",
                table: "Tarla",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depo_Ilanlar",
                table: "Depo",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Daire_Ilanlar",
                table: "Daire",
                column: "IlanId",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
