using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GenererModelsDeBDDSQLServer.Models
{
    public partial class EmploiContext : DbContext
    {
        public EmploiContext()
        {
        }

        public EmploiContext(DbContextOptions<EmploiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Demandeurdemploi> Demandeurdemplois { get; set; }
        public virtual DbSet<Diplome> Diplomes { get; set; }
        public virtual DbSet<Diplomesdudemandeurdemploi> Diplomesdudemandeurdemplois { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionDbEmploi");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Demandeurdemploi>(entity =>
            {
                entity.HasKey(e => e.NumSecuriteSocial)
                    .HasName("PK__DEMANDEU__827B5103F7C13D86");

                entity.ToTable("DEMANDEURDEMPLOIS");

                entity.Property(e => e.NumSecuriteSocial).ValueGeneratedNever();

                entity.Property(e => e.DateDinscription).HasColumnType("datetime");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diplome>(entity =>
            {
                entity.ToTable("DIPLOMES");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Diplomesdudemandeurdemploi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DIPLOMESDUDEMANDEURDEMPLOI");

                entity.Property(e => e.AnneeDeValidation).HasColumnType("datetime");

                entity.Property(e => e.IdDemandeurDemploi).HasColumnName("IdDemandeurDEmploi");

                entity.HasOne(d => d.IdDemandeurDemploiNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdDemandeurDemploi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DIPLOMESD__IdDem__276EDEB3");

                entity.HasOne(d => d.IdDuDiplomesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdDuDiplomes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DIPLOMESD__IdDuD__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
