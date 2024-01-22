using Microsoft.EntityFrameworkCore;

namespace projekt.Models
{
    public class ContextDB : DbContext
    {

        public DbSet<UporabnikModel> Uporabniki { get; set; }
        public DbSet<DokumentiModel> Dokumenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = miki");
        }
    
    }
}
