using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasWish.Database
{
    public class Database : DbContext
    {
        private const string DatabaseName = "JPXmasWish";
        private const string ConnString = $"server=(localdb)\\mssqllocaldb;integrated security=true;database={DatabaseName}";

        public DbSet<Person> People { get; set; }
        public DbSet<Gift> Gifts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
