using System;
using Microsoft.EntityFrameworkCore;

namespace EFLibraryPersistence
{
    public class EfLibraryDbContext : DbContext
    {
        public EfLibraryDbContext(DbContextOptions<EfLibraryDbContext> dbContextOptions): base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}