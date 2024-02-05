using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig26 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Arsa_Ilanlar_Id",
                table: "Arsa",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Daire_Ilanlar_Id",
                table: "Daire",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depo_Ilanlar_Id",
                table: "Depo",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dukkan_Ilanlar_Id",
                table: "Dukkan",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Ilanlar_Id",
                table: "Tarla",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arsa_Ilanlar_Id",
                table: "Arsa");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Ilanlar_Id",
                table: "Daire");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Ilanlar_Id",
                table: "Depo");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Ilanlar_Id",
                table: "Dukkan");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Ilanlar_Id",
                table: "Tarla");
        }
    }
}
