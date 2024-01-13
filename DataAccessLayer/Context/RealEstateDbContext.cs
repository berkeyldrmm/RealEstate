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

    //public RealEstateDBContext(DbContextOptions options) : base(options)
    //{

    //}

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

            //entity.HasKey(t => t.Id);
            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.ImarDurumu).HasColumnName("Imar durumu");
            entity.Property(e => e.MetrekareFiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaftaNo).HasColumnName("PaftaNo.");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");

            entity.HasOne(a => a.Ilan)
            .WithOne(i => i.Portfoy as Arsa)
            .HasForeignKey<Arsa>(a => a.Id);

            entity.HasOne(a => a.Talep)
            .WithOne(t => t.Portfoy as Arsa);

        });

        modelBuilder.Entity<Daire>(entity =>
        {
            entity.ToTable("Daire");

            //entity.HasKey(t => t.Id);
            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Isıtma).HasMaxLength(50);
            entity.Property(e => e.KullanimDurumu).HasMaxLength(50);

            entity.HasOne(d => d.Ilan)
            .WithOne(i => i.Portfoy as Daire)
            .HasForeignKey<Daire>(a => a.Id);

            entity.HasOne(d => d.Talep)
            .WithOne(t => t.Portfoy as Daire);
        });

        modelBuilder.Entity<Depo>(entity =>
        {
            entity.ToTable("Depo");

            //entity.HasKey(t => t.Id);
            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");

            entity.HasOne(d => d.Ilan)
            .WithOne(i => i.Portfoy as Depo)
            .HasForeignKey<Depo>(a => a.Id);

            entity.HasOne(d => d.Talep)
            .WithOne(t => t.Portfoy as Depo);
        });

        modelBuilder.Entity<Dukkan>(entity =>
        {
            entity.ToTable("Dukkan");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Isıtma).HasMaxLength(50);
            entity.Property(e => e.KullanimDurumu).HasMaxLength(50);

            //entity.HasKey(t => t.Id);
            entity.HasOne(d => d.Ilan)
            .WithOne(i => i.Portfoy as Dukkan)
            .HasForeignKey<Dukkan>(a => a.Id);

            entity.HasOne(d => d.Talep)
            .WithOne(t => t.Portfoy as Dukkan);
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

            entity.HasOne(i => i.Satici)
            .WithMany(s => s.Ilanlar)
            .HasForeignKey(i => i.SaticiId);

            entity.HasKey(t => t.Id);
            entity.HasOne(i=>i.IlanTalepTipi)
            .WithMany(itt=>itt.Ilanlar)
            .HasForeignKey(i=>i.IlanTalepTipiId);

            //entity.HasOne(i => i.Portfoy)
            //.WithOne(p => p.Ilan)
            //.HasForeignKey<Arsa>(a => a.Id)
            //.HasForeignKey<Tarla>(t => t.Id)
            //.HasForeignKey<Dukkan>(d => d.Id)
            //.HasForeignKey<Daire>(d => d.Id)
            //.HasForeignKey<Depo>(d => d.Id);

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

            entity.HasOne(t => t.Alici)
            .WithMany(a => a.Talepler)
            .HasForeignKey(t => t.AliciId);

            entity.HasOne(t => t.IlanTalepTipi)
            .WithMany(itt=>itt.Talepler)
            .HasForeignKey(t => t.IlanTalepTipiId);
        });

        modelBuilder.Entity<Tarla>(entity =>
        {
            entity.ToTable("Tarla");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.MetrekareFiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaftaNo).HasColumnName("PaftaNo.");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");

            //entity.HasKey(t => t.Id);
            entity.HasOne(t => t.Ilan)
            .WithOne(i => i.Portfoy as Tarla)
            .HasForeignKey<Tarla>(t => t.Id);

            entity.HasOne(t => t.Talep)
            .WithOne(t => t.Portfoy as Tarla);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasMany(u => u.Saticilar)
            .WithOne(s => s.User)
            .HasForeignKey(s => s.UserId);

            entity.HasMany(u => u.Alicilar)
            .WithOne(a => a.User)
            .HasForeignKey(s => s.UserId);

            entity.HasMany(u => u.Ilanlar)
            .WithOne(i => i.User)
            .HasForeignKey(s => s.UserId);

            entity.HasMany(u => u.Talepler)
            .WithOne(t => t.User)
            .HasForeignKey(s => s.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
