using M3S9_jogos.webApi.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace M3S9_jogos.webApi.Infra
{
    public class JogoDbContext : DbContext
    {
        public JogoDbContext(DbContextOptions options) : base(options)
        {
        }
               protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EstudioConfiguration());
            modelBuilder.ApplyConfiguration(new JogoConfiguration());
        }

    }
}
