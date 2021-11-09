using Microsoft.EntityFrameworkCore;
using PloomesPraticalTest.Src.Models;

namespace PloomesPraticalTest.Data
{
    public class DrugContext : DbContext
    {
        public DrugContext(DbContextOptions<DrugContext> options) : base(options) {}      

        public DbSet<Drug> Drugs { get; set; }

    } 
}
