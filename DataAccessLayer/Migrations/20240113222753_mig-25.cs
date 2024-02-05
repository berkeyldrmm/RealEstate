using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arsa_Ilanlar_IlanId",
                table: "Arsa");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Ilanlar_IlanId",
                table: "Daire");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Ilanlar_IlanId",
                table: "Depo");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Ilanlar_IlanId",
                table: "Dukkan");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Ilanlar_IlanId",
                table: "Tarla");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
