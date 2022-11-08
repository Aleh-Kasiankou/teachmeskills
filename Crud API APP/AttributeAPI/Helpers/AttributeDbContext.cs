using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API.Helpers
{
    public class AttributeDbContext : DbContext
    {
        private readonly string _dbConnString;
        
        public AttributeDbContext(IOptions<ConnectionStrings> credentials)
        {
            _dbConnString = credentials.Value.Default;
        }
        
        public DbSet<Attribute> Attribute { get; set; }
        public DbSet<PossibleValue>PossibleValue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnString);
        }
    }

    
    
    
}