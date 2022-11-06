using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API.Helpers
{
    public class DataBase : DbContext
    {
        private readonly string _dbConnString;
        
        public DataBase(IOptions<ConnectionStrings> credentials)
        {
            _dbConnString = credentials.Value.Default;
        }
        
        public DbSet<AttributeEntity> Attribute { get; set; }
        public DbSet<PossibleValueEntity>PossibleValue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnString);
        }
    }

    
    
    
}