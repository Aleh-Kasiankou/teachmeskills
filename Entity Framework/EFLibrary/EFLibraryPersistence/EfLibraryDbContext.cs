using System;
using EFLibraryPersistence.Models;
using Microsoft.EntityFrameworkCore;

namespace EFLibraryPersistence
{
    public class EfLibraryDbContext : DbContext
    {
        public EfLibraryDbContext(DbContextOptions<EfLibraryDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region AuthorConfiguration

            modelBuilder.Entity<Author>()
                .HasMany<Book>()
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.AuthorId);
            
            modelBuilder.Entity<Author>().Property(x => x.Country).HasColumnType("nvarchar(256)");
            modelBuilder.Entity<Author>().Property(x => x.FirstName).HasColumnType("nvarchar(256)");
            modelBuilder.Entity<Author>().Property(x => x.LastName).HasColumnType("nvarchar(256)");

            #endregion

            #region BookConfiguration

            modelBuilder.Entity<Book>()
                .HasOne(x => x.Author)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.AuthorId);
            
            modelBuilder.Entity<Book>().Property(x => x.Name).HasColumnType("nvarchar(255)");

            #endregion

            #region UserBookConfiguration

            modelBuilder.Entity<UserBook>()
                .HasOne<User>()
                .WithMany(x => x.UserBooks).HasForeignKey(x => x.UserId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            modelBuilder.Entity<UserBook>()
                .HasOne<Book>()
                .WithMany(x => x.UserBooks).HasForeignKey(x => x.BookId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            #endregion

            #region UserConfiguration

            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            
            modelBuilder.Entity<User>().Property(x => x.FirstName).HasColumnType("nvarchar(256)");
            modelBuilder.Entity<User>().Property(x => x.LastName).HasColumnType("nvarchar(256)");
            modelBuilder.Entity<User>().Property(x => x.Address).HasColumnType("nvarchar(256)");
            modelBuilder.Entity<User>().Property(x => x.Email).HasColumnType("nvarchar(100)");


            #endregion
        }
    }
}