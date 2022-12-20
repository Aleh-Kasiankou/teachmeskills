using System;
using HelpDesk.Persistence.Models;
using HelpDesk.Persistence.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Persistence
{
    public class HelpDeskDbContext : DbContext
    {
        public HelpDeskDbContext(DbContextOptions<HelpDeskDbContext> options) : base(options)
        {
        }

        public DbSet<SupportDepartment> SupportDepartments { get; set; }
        public DbSet<SupportSpecialist> SupportSpecialists { get; set; }
        public DbSet<SupportRequest> SupportRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupportDepartment>().HasData(
                new SupportDepartment
                    { SupportDepartmentId = Guid.Parse("1d5b9219-9b8c-4996-8a35-51a27feaa74b"), Name = "Backend" },
                new SupportDepartment
                    { SupportDepartmentId = Guid.Parse("dee22e09-d91c-4037-8ad5-dd4213efe33f"), Name = "Catalog" },
                new SupportDepartment
                    { SupportDepartmentId = Guid.Parse("122a1127-6afb-4cc6-976e-148eed423dcd"), Name = "Checkout" }
            );

            modelBuilder.Entity<SupportDepartment>()
                .HasKey(x => x.SupportDepartmentId);

            modelBuilder.Entity<SupportDepartment>().Property(x => x.Name).HasColumnType("nvarchar(256)");

            
            modelBuilder.Entity<SupportSpecialist>().HasData(
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("0389124d-f199-4856-b965-2d38184cc0e8"),
                    Name = "Adam",
                    SupportDepartmentId = Guid.Parse("1d5b9219-9b8c-4996-8a35-51a27feaa74b")
                },
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("61a01264-0d20-46f0-bcd1-36cd20a41123"),
                    Name = "Rayan",
                    SupportDepartmentId = Guid.Parse("1d5b9219-9b8c-4996-8a35-51a27feaa74b")
                },
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("18f522b6-697d-4c96-ae91-018d3374ed14"),
                    Name = "Yurena",
                    SupportDepartmentId = Guid.Parse("1d5b9219-9b8c-4996-8a35-51a27feaa74b")
                },
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("c95501a5-b529-4caa-a199-98da01e3ccfd"),
                    Name = "Antía",
                    SupportDepartmentId = Guid.Parse("dee22e09-d91c-4037-8ad5-dd4213efe33f")
                },
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("fd782f05-2e58-4367-bd4c-e734fdcdedc3"),
                    Name = "Irati",
                    SupportDepartmentId = Guid.Parse("dee22e09-d91c-4037-8ad5-dd4213efe33f")
                },
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("7fd58309-c943-42f6-9355-1c6c0be87d90"),
                    Name = "Xosé",
                    SupportDepartmentId = Guid.Parse("dee22e09-d91c-4037-8ad5-dd4213efe33f")
                },
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("aacb0189-d28c-40f9-97c5-dd5073961771"),
                    Name = "Martina",
                    SupportDepartmentId = Guid.Parse("122a1127-6afb-4cc6-976e-148eed423dcd")
                },
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("c6fdf17d-a495-4685-8eff-1d95d97fdf59"),
                    Name = "Hugo",
                    SupportDepartmentId = Guid.Parse("122a1127-6afb-4cc6-976e-148eed423dcd")
                },
                new SupportSpecialist
                {
                    SupportSpecialistId = Guid.Parse("93575465-e1ba-4d73-a085-3d100001cfe7"),
                    Name = "Amira",
                    SupportDepartmentId = Guid.Parse("122a1127-6afb-4cc6-976e-148eed423dcd")
                }
            );

            modelBuilder.Entity<SupportSpecialist>()
                .HasKey(x => x.SupportSpecialistId);

            modelBuilder.Entity<SupportSpecialist>()
                .HasOne( x => x.SupportDepartment)
                .WithMany(x => x.SupportSpecialists)
                .HasForeignKey(x => x.SupportDepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SupportSpecialist>().Property(x => x.Name).HasColumnType("nvarchar(256)");
            
            
            modelBuilder.Entity<SupportRequest>()
                .HasKey(x => x.SupportRequestId);

            modelBuilder.Entity<SupportRequest>()
                .HasOne(x => x.SupportDepartment)
                .WithMany(x => x.SupportRequests)
                .HasForeignKey(x => x.SupportDepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SupportRequest>()
                .HasOne(x => x.SupportSpecialist)
                .WithMany(x => x.SupportRequests)
                .HasForeignKey(x => x.SupportSpecialistId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<SupportRequest>().Property(x => x.Subject).HasColumnType("nvarchar(256)");
            modelBuilder.Entity<SupportRequest>().Property(x => x.Description).HasColumnType("ntext");
            
        }
    }
}