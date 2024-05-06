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
        public virtual DbSet<Statistique> Statistiques { get; set; } = null!;
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

                entity.ToTable("doctrine_migration_versions");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_unicode_ci");

                entity.Property(e => e.Version)
                    .HasMaxLength(191)
                    .HasColumnName("version");

                entity.Property(e => e.ExecutedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("executed_at");

                entity.Property(e => e.ExecutionTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("execution_time");
            });

            modelBuilder.Entity<Equipe>(entity =>
            {
                entity.ToTable("equipe");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IdHackaton, "IDX_2449BA15E0C15918");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateInsc).HasColumnName("dateInsc");

                entity.Property(e => e.IdHackaton)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackaton");

                entity.Property(e => e.NomEquipe)
                    .HasMaxLength(255)
                    .HasColumnName("nomEquipe");

                entity.HasOne(d => d.IdHackatonNavigation)
                    .WithMany(p => p.Equipes)
                    .HasForeignKey(d => d.IdHackaton)
                    .HasConstraintName("FK_2449BA15E0C15918");
            });

            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.ToTable("evenement");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IdIntervenant, "IDX_B26681E338DEB24");

                entity.HasIndex(e => e.IdHackaton, "IDX_B26681EE0C15918");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateDeb).HasColumnName("dateDeb");

                entity.Property(e => e.DateFin).HasColumnName("dateFin");

                entity.Property(e => e.IdHackaton)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackaton");

                entity.Property(e => e.IdIntervenant)
                    .HasColumnType("int(11)")
                    .HasColumnName("idIntervenant");

                entity.Property(e => e.NbPlace)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbPlace");

                entity.Property(e => e.Salle)
                    .HasMaxLength(255)
                    .HasColumnName("salle");

                entity.Property(e => e.Theme)
                    .HasMaxLength(255)
                    .HasColumnName("theme");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

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
                entity.ToTable("hackaton");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IdVille, "IDX_B362734354079ADE");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Addresse)
                    .HasMaxLength(255)
                    .HasColumnName("addresse");

                entity.Property(e => e.DateDeb).HasColumnName("dateDeb");

                entity.Property(e => e.DateFin).HasColumnName("dateFin");

                entity.Property(e => e.IdVille)
                    .HasColumnType("int(11)")
                    .HasColumnName("idVille");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.NbPlace)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbPlace");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Theme)
                    .HasMaxLength(255)
                    .HasColumnName("theme");

                entity.HasOne(d => d.IdVilleNavigation)
                    .WithMany(p => p.Hackatons)
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK_B362734354079ADE");
            });

            modelBuilder.Entity<Intervenant>(entity =>
            {
                entity.ToTable("intervenant");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");
            });

            modelBuilder.Entity<MessengerMessage>(entity =>
            {
                entity.ToTable("messenger_messages");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DeliveredAt, "IDX_75EA56E016BA31DB");

                entity.HasIndex(e => e.AvailableAt, "IDX_75EA56E0E3BD61CE");

                entity.HasIndex(e => e.QueueName, "IDX_75EA56E0FB7336F0");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AvailableAt)
                    .HasColumnType("datetime")
                    .HasColumnName("available_at")
                    .HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.DeliveredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("delivered_at")
                    .HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.Headers).HasColumnName("headers");

                entity.Property(e => e.QueueName)
                    .HasMaxLength(190)
                    .HasColumnName("queue_name");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.ToTable("participant");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IdAtelier, "IDX_D79F6B11F10273D1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdAtelier)
                    .HasColumnType("int(11)")
                    .HasColumnName("idAtelier");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .HasColumnName("mail");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");

                entity.HasOne(d => d.IdAtelierNavigation)
                    .WithMany(p => p.Participants)
                    .HasForeignKey(d => d.IdAtelier)
                    .HasConstraintName("FK_D79F6B11F10273D1");
            });

            modelBuilder.Entity<Statistique>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Statistiques");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.ToTable("utilisateur");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "UNIQ_1D1C63B3E7927C74")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateNaiss).HasColumnName("dateNaiss");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Mdp)
                    .HasMaxLength(255)
                    .HasColumnName("mdp");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");

                entity.Property(e => e.Roles)
                    .HasColumnType("json")
                    .HasColumnName("roles")
                    .HasComment("(DC2Type:json)");

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .HasColumnName("tel");

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

                entity.HasMany(d => d.Hackatons)
                    .WithMany(p => p.Utilisateurs)
                    .UsingEntity<Dictionary<string, object>>(
                        "UtilisateurHackatonFavori",
                        l => l.HasOne<Hackaton>().WithMany().HasForeignKey("HackatonId").HasConstraintName("FK_2CC1FBD4B333DC5B"),
                        r => r.HasOne<Utilisateur>().WithMany().HasForeignKey("UtilisateurId").HasConstraintName("FK_2CC1FBD4FB88E14F"),
                        j =>
                        {
                            j.HasKey("UtilisateurId", "HackatonId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("utilisateur_hackaton_favoris").UseCollation("utf8mb4_unicode_ci");

                            j.HasIndex(new[] { "HackatonId" }, "IDX_2CC1FBD4B333DC5B");

                            j.HasIndex(new[] { "UtilisateurId" }, "IDX_2CC1FBD4FB88E14F");

                            j.IndexerProperty<int>("UtilisateurId").HasColumnType("int(11)").HasColumnName("utilisateur_id");

                            j.IndexerProperty<int>("HackatonId").HasColumnType("int(11)").HasColumnName("hackaton_id");
                        });
            });

            modelBuilder.Entity<Ville>(entity =>
            {
                entity.ToTable("ville");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Cp)
                    .HasMaxLength(255)
                    .HasColumnName("cp");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
