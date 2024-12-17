using Microsoft.EntityFrameworkCore;

namespace Nepremicnine__
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Placilo> Placila { get; set; }
        public DbSet<Pogodba> Pogodbe { get; set; }
        public DbSet<Nepremicnina> Nepremicnine { get; set; }
        public DbSet<Uporabnik> Uporabniki { get; set; }
        public DbSet<Oglas> Oglas { get; set; }
        public DbSet<Pogodba> Pogodba { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
            
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Placilo>().ToTable("Placila");
            modelBuilder.Entity<Pogodba>().ToTable("Pogodbe");
            modelBuilder.Entity<Nepremicnina>().ToTable("Nepremicnine");
            modelBuilder.Entity<Uporabnik>().ToTable("Uporabniki");
            modelBuilder.Entity<Oglas>().ToTable("Oglasi");
            modelBuilder.Entity<Pogodba>().ToTable("Pogodbe");
        }
    }
}
