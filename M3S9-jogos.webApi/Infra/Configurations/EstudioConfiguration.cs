using M3S9_jogos.webApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M3S9_jogos.webApi.Infra.Configurations
{
    public class EstudioConfiguration : IEntityTypeConfiguration<Estudio>
    {
        public void Configure(EntityTypeBuilder<Estudio> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p =>p.Id).UseIdentityColumn();
            builder.ToTable("Estudios");
            builder.Property(p=>p.Nome).IsRequired().HasMaxLength(100).HasColumnName("Nome");
            builder.Property(p=>p.DataCriacao).IsRequired();
        }

    }
}
