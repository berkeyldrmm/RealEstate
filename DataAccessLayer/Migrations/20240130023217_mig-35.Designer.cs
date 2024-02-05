﻿// <auto-generated />
using System;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(RealEstateDBContext))]
    [Migration("20240130023217_mig-35")]
    partial class mig35
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Entities.Arsa", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdaNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AdaNo.");

                    b.Property<bool>("ImarDurumu")
                        .HasColumnType("bit")
                        .HasColumnName("Imar durumu");

                    b.Property<bool>("KatKarsiliginaUygun")
                        .HasColumnType("bit");

                    b.Property<decimal?>("MetrekareFiyat")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("MetrekareNet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaftaNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PaftaNo.");

                    b.Property<string>("ParselNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ParselNo.");

                    b.Property<bool>("TapuDurumu")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Arsa", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Daire", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdaNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Aidat")
                        .HasColumnType("int");

                    b.Property<bool?>("Asansor")
                        .HasColumnType("bit");

                    b.Property<int?>("BalkonSayisi")
                        .HasColumnType("int");

                    b.Property<int?>("BanyoSayisi")
                        .HasColumnType("int");

                    b.Property<string>("BinaYasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BulunduguKat")
                        .HasColumnType("int");

                    b.Property<bool>("EsyaliMi")
                        .HasColumnType("bit");

                    b.Property<string>("Isıtma")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("KatSayisi")
                        .HasColumnType("int");

                    b.Property<bool?>("KrediyeUygun")
                        .HasColumnType("bit");

                    b.Property<string>("KullanimDurumu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MetrekareBrut")
                        .HasColumnType("int");

                    b.Property<decimal?>("MetrekareFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MetrekareNet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OdaSayisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Otopark")
                        .HasColumnType("bit");

                    b.Property<string>("ParselNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SiteMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Daire", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Danisan", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MailAdresi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelefonNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TelefonNo.");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Danisanlar", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Depo", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdaNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AdaNo.");

                    b.Property<decimal?>("MetrekareFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MetrekareNet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParselNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ParselNo.");

                    b.HasKey("Id");

                    b.ToTable("Depo", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Dukkan", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdaNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Aidat")
                        .HasColumnType("int");

                    b.Property<bool?>("Asansor")
                        .HasColumnType("bit");

                    b.Property<string>("BinaYasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BulunduguKat")
                        .HasColumnType("int");

                    b.Property<bool>("EsyaliMi")
                        .HasColumnType("bit");

                    b.Property<string>("Isıtma")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("KatSayisi")
                        .HasColumnType("int");

                    b.Property<bool?>("KrediyeUygun")
                        .HasColumnType("bit");

                    b.Property<string>("KullanimDurumu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MetrekareBrut")
                        .HasColumnType("int");

                    b.Property<decimal?>("MetrekareFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MetrekareNet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OdaSayisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Otopark")
                        .HasColumnType("bit");

                    b.Property<string>("ParselNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dukkan", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Ilan", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Detaylar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlanTalepTipiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Kazanc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Komisyon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Mahalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PortfoyFiyati")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SaticiId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SatilikMiKiralikMi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SatisDurumu")
                        .HasColumnType("bit");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IlanTalepTipiId");

                    b.HasIndex("SaticiId");

                    b.HasIndex("UserId");

                    b.ToTable("Ilanlar", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.IlanTalepTipi", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("TipAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("IlanTalepTipleri", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Talep", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AliciId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Detaylar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlanTalepTipiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaxFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OdaSayisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatilikMiKiralikMi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semtler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AliciId");

                    b.HasIndex("IlanTalepTipiId");

                    b.HasIndex("UserId");

                    b.ToTable("Talepler", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Tarla", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdaNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AdaNo.");

                    b.Property<bool>("ImarDurumu")
                        .HasColumnType("bit");

                    b.Property<decimal?>("MetrekareFiyat")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("MetrekareNet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaftaNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PaftaNo.");

                    b.Property<string>("ParselNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ParselNo.");

                    b.Property<bool>("TapuDurumu")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tarla", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Arsa", b =>
                {
                    b.HasOne("EntityLayer.Entities.Ilan", "Ilan")
                        .WithOne("Arsa")
                        .HasForeignKey("EntityLayer.Entities.Arsa", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("EntityLayer.Entities.Daire", b =>
                {
                    b.HasOne("EntityLayer.Entities.Ilan", "Ilan")
                        .WithOne("Daire")
                        .HasForeignKey("EntityLayer.Entities.Daire", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("EntityLayer.Entities.Danisan", b =>
                {
                    b.HasOne("EntityLayer.Entities.User", "User")
                        .WithMany("Danisanlar")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Entities.Depo", b =>
                {
                    b.HasOne("EntityLayer.Entities.Ilan", "Ilan")
                        .WithOne("Depo")
                        .HasForeignKey("EntityLayer.Entities.Depo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("EntityLayer.Entities.Dukkan", b =>
                {
                    b.HasOne("EntityLayer.Entities.Ilan", "Ilan")
                        .WithOne("Dukkan")
                        .HasForeignKey("EntityLayer.Entities.Dukkan", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("EntityLayer.Entities.Ilan", b =>
                {
                    b.HasOne("EntityLayer.Entities.IlanTalepTipi", "IlanTalepTipi")
                        .WithMany("Ilanlar")
                        .HasForeignKey("IlanTalepTipiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.Danisan", "Satici")
                        .WithMany("Ilanlar")
                        .HasForeignKey("SaticiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.User", "User")
                        .WithMany("Ilanlar")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IlanTalepTipi");

                    b.Navigation("Satici");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Entities.Talep", b =>
                {
                    b.HasOne("EntityLayer.Entities.Danisan", "Alici")
                        .WithMany()
                        .HasForeignKey("AliciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.IlanTalepTipi", "IlanTalepTipi")
                        .WithMany("Talepler")
                        .HasForeignKey("IlanTalepTipiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.User", "User")
                        .WithMany("Talepler")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alici");

                    b.Navigation("IlanTalepTipi");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Entities.Tarla", b =>
                {
                    b.HasOne("EntityLayer.Entities.Ilan", "Ilan")
                        .WithOne("Tarla")
                        .HasForeignKey("EntityLayer.Entities.Tarla", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("EntityLayer.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EntityLayer.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EntityLayer.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("EntityLayer.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EntityLayer.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Entities.Danisan", b =>
                {
                    b.Navigation("Ilanlar");
                });

            modelBuilder.Entity("EntityLayer.Entities.Ilan", b =>
                {
                    b.Navigation("Arsa");

                    b.Navigation("Daire");

                    b.Navigation("Depo");

                    b.Navigation("Dukkan");

                    b.Navigation("Tarla");
                });

            modelBuilder.Entity("EntityLayer.Entities.IlanTalepTipi", b =>
                {
                    b.Navigation("Ilanlar");

                    b.Navigation("Talepler");
                });

            modelBuilder.Entity("EntityLayer.Entities.User", b =>
                {
                    b.Navigation("Danisanlar");

                    b.Navigation("Ilanlar");

                    b.Navigation("Talepler");
                });
#pragma warning restore 612, 618
        }
    }
}
