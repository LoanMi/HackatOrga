using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HackatOrga.Models
{
    public partial class HackatonContext : DbContext
    {
        public HackatonContext()
        {
        }

        public HackatonContext(DbContextOptions<HackatonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; } = null!;
        public virtual DbSet<Equipe> Equipes { get; set; } = null!;
        public virtual DbSet<Evenement> Evenements { get; set; } = null!;
        public virtual DbSet<Hackaton> Hackatons { get; set; } = null!;
        public virtual DbSet<Intervenant> Intervenants { get; set; } = null!;
        public virtual DbSet<MessengerMessage> MessengerMessages { get; set; } = null!;
        public virtual DbSet<Participant> Participants { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;
        public virtual DbSet<Ville> Villes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.61.150;database=Hackaton;user=phpmyadmin;password=password;charset=utf8", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.4-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Equipe>(entity =>
            {
                entity.HasOne(d => d.IdHackatonNavigation)
                    .WithMany(p => p.Equipes)
                    .HasForeignKey(d => d.IdHackaton)
                    .HasConstraintName("FK_2449BA15E0C15918");
            });

            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.HasOne(d => d.IdHackatonNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdHackaton)
                    .HasConstraintName("FK_B26681EE0C15918");

                entity.HasOne(d => d.IdIntervenantNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdIntervenant)
                    .HasConstraintName("FK_B26681E338DEB24");
            });

            modelBuilder.Entity<Hackaton>(entity =>
            {
                entity.HasOne(d => d.IdVilleNavigation)
                    .WithMany(p => p.Hackatons)
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK_B362734354079ADE");
            });

            modelBuilder.Entity<MessengerMessage>(entity =>
            {
                entity.Property(e => e.AvailableAt).HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.CreatedAt).HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.DeliveredAt).HasComment("(DC2Type:datetime_immutable)");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasOne(d => d.IdAtelierNavigation)
                    .WithMany(p => p.Participants)
                    .HasForeignKey(d => d.IdAtelier)
                    .HasConstraintName("FK_D79F6B11F10273D1");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasMany(d => d.Equipes)
                    .WithMany(p => p.Utilisateurs)
                    .UsingEntity<Dictionary<string, object>>(
                        "UtilisateurEquipe",
                        l => l.HasOne<Equipe>().WithMany().HasForeignKey("EquipeId").HasConstraintName("FK_45E4809E6D861B89"),
                        r => r.HasOne<Utilisateur>().WithMany().HasForeignKey("UtilisateurId").HasConstraintName("FK_45E4809EFB88E14F"),
                        j =>
                        {
                            j.HasKey("UtilisateurId", "EquipeId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("utilisateur_equipe").UseCollation("utf8mb4_unicode_ci");

                            j.HasIndex(new[] { "EquipeId" }, "IDX_45E4809E6D861B89");

                            j.HasIndex(new[] { "UtilisateurId" }, "IDX_45E4809EFB88E14F");

                            j.IndexerProperty<int>("UtilisateurId").HasColumnType("int(11)").HasColumnName("utilisateur_id");

                            j.IndexerProperty<int>("EquipeId").HasColumnType("int(11)").HasColumnName("equipe_id");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
