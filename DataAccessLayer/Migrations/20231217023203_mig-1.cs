using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alicilar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MailAdresi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TelefonNo = table.Column<string>(name: "TelefonNo.", type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arsa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Metrekare = table.Column<int>(type: "int", nullable: false),
                    Imardurumu = table.Column<bool>(name: "Imar durumu", type: "bit", nullable: false),
                    MetrekareFiyat = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    AdaNo = table.Column<int>(name: "AdaNo.", type: "int", nullable: false),
                    ParselNo = table.Column<int>(name: "ParselNo.", type: "int", nullable: false),
                    PaftaNo = table.Column<int>(name: "PaftaNo.", type: "int", nullable: false),
                    KatKarsiliginaUygun = table.Column<bool>(type: "bit", nullable: false),
                    KrediyeUygun = table.Column<bool>(type: "bit", nullable: false),
                    Kimden = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SatilikKiralik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arsa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Daire",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MetrekareBrut = table.Column<int>(type: "int", nullable: true),
                    MetrekareNet = table.Column<int>(type: "int", nullable: false),
                    OdaSayisi = table.Column<int>(type: "int", nullable: false),
                    BinaYasi = table.Column<int>(type: "int", nullable: true),
                    BulunduguKat = table.Column<int>(type: "int", nullable: true),
                    KatSayisi = table.Column<int>(type: "int", nullable: true),
                    Isıtma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BanyoSayisi = table.Column<int>(type: "int", nullable: true),
                    BalkonSayisi = table.Column<int>(type: "int", nullable: true),
                    Asansor = table.Column<bool>(type: "bit", nullable: true),
                    Otopark = table.Column<bool>(type: "bit", nullable: true),
                    EsyaliMi = table.Column<bool>(type: "bit", nullable: false),
                    KullanimDurumu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SiteMi = table.Column<bool>(type: "bit", nullable: true),
                    KrediyeUygun = table.Column<bool>(type: "bit", nullable: true),
                    Aidat = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    SatilikKiralik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daire", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Metrekare = table.Column<int>(type: "int", nullable: false),
                    MetrekareFiyat = table.Column<int>(type: "int", nullable: false),
                    AdaNo = table.Column<int>(name: "AdaNo.", type: "int", nullable: false),
                    ParselNo = table.Column<int>(name: "ParselNo.", type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    SatilikKiralik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dukkan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MetrekareBrut = table.Column<int>(type: "int", nullable: false),
                    MetrekareNet = table.Column<int>(type: "int", nullable: true),
                    OdaSayisi = table.Column<int>(type: "int", nullable: false),
                    BinaYasi = table.Column<int>(type: "int", nullable: false),
                    BulunduguKat = table.Column<int>(type: "int", nullable: true),
                    KatSayisi = table.Column<int>(type: "int", nullable: true),
                    Isıtma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BanyoSayisi = table.Column<int>(type: "int", nullable: true),
                    BalkonSayisi = table.Column<int>(type: "int", nullable: true),
                    Asansor = table.Column<bool>(type: "bit", nullable: true),
                    Otopark = table.Column<bool>(type: "bit", nullable: true),
                    EsyaliMi = table.Column<bool>(type: "bit", nullable: false),
                    KullanimDurumu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SiteMi = table.Column<bool>(type: "bit", nullable: true),
                    KrediyeUygun = table.Column<bool>(type: "bit", nullable: true),
                    Aidat = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    SatilikKiralik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dukkan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilanlar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IlanTipi = table.Column<int>(type: "int", nullable: false),
                    Satici = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IlanTalepTipleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TipAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipNo = table.Column<int>(name: "TipNo.", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlanTalepTipleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saticilar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TelefonNo = table.Column<string>(name: "TelefonNo.", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MailAdresi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saticilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Talepler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TalepTipi = table.Column<int>(type: "int", nullable: false),
                    Alici = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talepler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarla",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MetrekareFiyat = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ImarDurumu = table.Column<bool>(type: "bit", nullable: false),
                    Metrekare = table.Column<int>(type: "int", nullable: false),
                    AdaNo = table.Column<int>(name: "AdaNo.", type: "int", nullable: false),
                    ParselNo = table.Column<int>(name: "ParselNo.", type: "int", nullable: false),
                    PafaNo = table.Column<int>(name: "PafaNo.", type: "int", nullable: false),
                    TapuDurumu = table.Column<bool>(type: "bit", nullable: false),
                    KrediyeUygun = table.Column<bool>(type: "bit", nullable: false),
                    SatilikKiralik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarla", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alicilar");

            migrationBuilder.DropTable(
                name: "Arsa");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Daire");

            migrationBuilder.DropTable(
                name: "Depo");

            migrationBuilder.DropTable(
                name: "Dukkan");

            migrationBuilder.DropTable(
                name: "Ilanlar");

            migrationBuilder.DropTable(
                name: "IlanTalepTipleri");

            migrationBuilder.DropTable(
                name: "Saticilar");

            migrationBuilder.DropTable(
                name: "Talepler");

            migrationBuilder.DropTable(
                name: "Tarla");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
