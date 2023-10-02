using M3S9_jogos.webApi.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace M3S9_jogos.webApi.Infra
{
    public class JogoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-BG5E4QK\\SQLEXPRESS;Database=M3S9-WebApi;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EstudioConfiguration());
            modelBuilder.ApplyConfiguration(new JogoConfiguration());
        }

    }
}
