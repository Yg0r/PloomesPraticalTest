using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PloomesPraticalTest.Models;

namespace PloomesPraticalTest.Data
{
    public class DrugContext : DbContext
    {
        public DrugContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private readonly IConfiguration _configuration;
        public DbSet<Drug> Drugs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("dbPloomes"));
        }
    }
}
