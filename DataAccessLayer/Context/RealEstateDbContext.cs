using System;
using System.Collections.Generic;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.Context;

public partial class RealEstateDBContext : IdentityDbContext<User, Role, string>
{
    public virtual DbSet<Alici> Alicilar { get; set; }

    public virtual DbSet<Arsa> Arsa { get; set; }

    public virtual DbSet<Daire> Daire { get; set; }

    public virtual DbSet<Depo> Depo { get; set; }

    public virtual DbSet<Dukkan> Dukkan { get; set; }

    public virtual DbSet<IlanTalepTipi> IlanTalepTipleri { get; set; }

    public virtual DbSet<Ilan> Ilanlar { get; set; }

    public virtual DbSet<Satici> Saticilar { get; set; }

    public virtual DbSet<Talep> Talepler { get; set; }

    public virtual DbSet<Tarla> Tarla { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=BERKE;Database=RealEstateDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Alici>(entity =>
        {
            entity.ToTable("Alicilar");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdSoyad).HasMaxLength(50);
            entity.Property(e => e.MailAdresi).HasMaxLength(50);
            entity.Property(e => e.TelefonNo)
                .HasMaxLength(50)
                .HasColumnName("TelefonNo.");
        });

        modelBuilder.Entity<Arsa>(entity =>
        {
            entity.ToTable("Arsa");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ImarDurumu).HasColumnName("Imar durumu");
            entity.Property(e => e.Kimden).HasMaxLength(50);
            entity.Property(e => e.MetrekareFiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaftaNo).HasColumnName("PaftaNo.");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");
            entity.Property(e => e.SatilikKiralik).HasMaxLength(50);
        });

        modelBuilder.Entity<Daire>(entity =>
        {
            entity.ToTable("Daire");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Isıtma).HasMaxLength(50);
            entity.Property(e => e.KullanimDurumu).HasMaxLength(50);
            entity.Property(e => e.SatilikKiralik).HasMaxLength(50);
        });

        modelBuilder.Entity<Depo>(entity =>
        {
            entity.ToTable("Depo");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");
            entity.Property(e => e.SatilikKiralik).HasMaxLength(50);
        });

        modelBuilder.Entity<Dukkan>(entity =>
        {
            entity.ToTable("Dukkan");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Isıtma).HasMaxLength(50);
            entity.Property(e => e.KullanimDurumu).HasMaxLength(50);
            entity.Property(e => e.SatilikKiralik).HasMaxLength(50);
        });

        modelBuilder.Entity<IlanTalepTipi>(entity =>
        {
            entity.ToTable("IlanTalepTipleri");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TipAdi).HasMaxLength(50);
            entity.Property(e => e.TipNo).HasColumnName("TipNo.");
        });

        modelBuilder.Entity<Ilan>(entity =>
        {
            entity.ToTable("Ilanlar");

            entity.Property(e => e.Id).HasMaxLength(50);
        });

        modelBuilder.Entity<Satici>(entity =>
        {
            entity.ToTable("Saticilar");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdSoyad).HasMaxLength(50);
            entity.Property(e => e.MailAdresi).HasMaxLength(50);
            entity.Property(e => e.TelefonNo)
                .HasMaxLength(50)
                .HasColumnName("TelefonNo.");
        });

        modelBuilder.Entity<Talep>(entity =>
        {
            entity.ToTable("Talepler");

            entity.Property(e => e.Id).HasMaxLength(50);
        });

        modelBuilder.Entity<Tarla>(entity =>
        {
            entity.ToTable("Tarla");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.MetrekareFiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PafaNo).HasColumnName("PafaNo.");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");
            entity.Property(e => e.SatilikKiralik).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
