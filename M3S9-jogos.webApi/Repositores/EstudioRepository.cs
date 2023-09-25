using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.Infra;

namespace M3S9_jogos.webApi.Repositores
{
    public class EstudioRepository
    {
        readonly JogoDbContext _jogoDbContext;

        public EstudioRepository( JogoDbContext jogoDbContext)
        {
            _jogoDbContext = jogoDbContext;
        }

        public Estudio Get(int id)
        {
            var estudio = _jogoDbContext.Set<Estudio>().Where(p => p.Id == id).FirstOrDefault();
            return estudio;
        }
    }
}
