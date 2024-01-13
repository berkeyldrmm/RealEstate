using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig24 : Migration
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
                name: "FK_Tarla_Ilanlar_Id",
                table: "Tarla");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Talepler_TalepId",
                table: "Tarla");

            migrationBuilder.DropIndex(
                name: "IX_Tarla_TalepId",
                table: "Tarla");

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

            migrationBuilder.DropColumn(
                name: "MetrekareNet",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Tarla");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "MetrekareNet",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Dukkan");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "MetrekareNet",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Depo");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "MetrekareNet",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Daire");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "MetrekareNet",
                table: "Arsa");

            migrationBuilder.DropColumn(
                name: "TalepId",
                table: "Arsa");

            migrationBuilder.CreateTable(
                name: "Portfoy",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MetrekareNet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepId = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfoy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portfoy_Ilanlar_Id",
                        column: x => x.Id,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Portfoy_Talepler_TalepId",
                        column: x => x.TalepId,
                        principalTable: "Talepler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Portfoy_TalepId",
                table: "Portfoy",
                column: "TalepId",
                unique: true,
                filter: "[TalepId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Arsa_Portfoy_Id",
                table: "Arsa",
                column: "Id",
                principalTable: "Portfoy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Daire_Portfoy_Id",
                table: "Daire",
                column: "Id",
                principalTable: "Portfoy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depo_Portfoy_Id",
                table: "Depo",
                column: "Id",
                principalTable: "Portfoy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dukkan_Portfoy_Id",
                table: "Dukkan",
                column: "Id",
                principalTable: "Portfoy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Portfoy_Id",
                table: "Tarla",
                column: "Id",
                principalTable: "Portfoy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arsa_Portfoy_Id",
                table: "Arsa");

            migrationBuilder.DropForeignKey(
                name: "FK_Daire_Portfoy_Id",
                table: "Daire");

            migrationBuilder.DropForeignKey(
                name: "FK_Depo_Portfoy_Id",
                table: "Depo");

            migrationBuilder.DropForeignKey(
                name: "FK_Dukkan_Portfoy_Id",
                table: "Dukkan");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarla_Portfoy_Id",
                table: "Tarla");

            migrationBuilder.DropTable(
                name: "Portfoy");

            migrationBuilder.AddColumn<string>(
                name: "MetrekareNet",
                table: "Tarla",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Tarla",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetrekareNet",
                table: "Dukkan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Dukkan",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetrekareNet",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Depo",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetrekareNet",
                table: "Daire",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Daire",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetrekareNet",
                table: "Arsa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TalepId",
                table: "Arsa",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarla_TalepId",
                table: "Tarla",
                column: "TalepId",
                unique: true,
                filter: "[TalepId] IS NOT NULL");

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
                name: "FK_Tarla_Ilanlar_Id",
                table: "Tarla",
                column: "Id",
                principalTable: "Ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarla_Talepler_TalepId",
                table: "Tarla",
                column: "TalepId",
                principalTable: "Talepler",
                principalColumn: "Id");
        }
    }
}
