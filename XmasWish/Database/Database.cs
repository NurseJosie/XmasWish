using Microsoft.EntityFrameworkCore;
using XmasWish.Models;

namespace XmasWish
{
    public class Database : DbContext
    {
        private const string DatabaseName = "JPXmasWish"; 
        private const string ConnString = "server=(localdb)\\mssqllocaldb;integrated security=true;database = JPXmasWish";

        public DbSet<Person> People { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
