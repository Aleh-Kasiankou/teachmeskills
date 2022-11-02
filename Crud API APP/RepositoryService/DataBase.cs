using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RepositoryService.Entities;

namespace RepositoryService
{
    public class DataBase : DbContext
    {
        private readonly string _dbConnString;
        
        public DataBase(IOptions<ConnectionStrings> credentials)
        {
            _dbConnString = credentials.Value.Default;
        }
        
        public DbSet<AttributeEntity> AttributeList { get; set; }
        public DbSet<AttributeTypeEntity>AttributeType { get; set; }
        public DbSet<PossibleValueEntity>PossibleValue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnString);
        }
    }

    
    
    
}