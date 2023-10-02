using M3S9_jogos.webApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M3S9_jogos.webApi.Infra.Configurations
{
    public class JogoConfiguration : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.ToTable("Jogosos");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasOne(P => P.Estudio)
                .WithMany(P => P.Jogos)
                .HasForeignKey(p => p.EstudioId);
        }

    }
}
