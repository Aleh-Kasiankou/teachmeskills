using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp11
{
    public partial class SqlPracticeDBContext : DbContext
    {
        public SqlPracticeDBContext()
        {
        }

        public SqlPracticeDBContext(DbContextOptions<SqlPracticeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<PersonsStudySubjects> PersonsStudySubjects { get; set; }
        public virtual DbSet<Professors> Professors { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<StudySubjects> StudySubjects { get; set; }
        public virtual DbSet<Universities> Universities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=SqlPracticeDB; Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasIndex(e => e.Street)
                    .HasName("ID_Adress_street");

                entity.HasIndex(e => new { e.Street, e.City })
                    .HasName("ID_Adress_street_city");

                entity.HasIndex(e => new { e.City, e.Country, e.Street })
                    .HasName("ID_Adress_street_include");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Street).HasMaxLength(255);
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.Age)
                    .HasName("ID_Persons_Age")
                    .HasFilter("([Age]>(40))");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<PersonsStudySubjects>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.SubjectId });

                entity.HasIndex(e => e.SubjectId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PersonsStudySubjects)
                    .HasForeignKey(d => d.StudentId);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.PersonsStudySubjects)
                    .HasForeignKey(d => d.SubjectId);
            });

            modelBuilder.Entity<Professors>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Professors");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Students");
            });

            modelBuilder.Entity<StudySubjects>(entity =>
            {
                entity.HasIndex(e => e.ProfessorId);

                entity.HasIndex(e => e.UniversityId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.StudySubjects)
                    .HasForeignKey(d => d.ProfessorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.University)
                    .WithMany(p => p.StudySubjects)
                    .HasForeignKey(d => d.UniversityId);
            });

            modelBuilder.Entity<Universities>(entity =>
            {
                entity.HasIndex(e => e.AddressId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Universities)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
