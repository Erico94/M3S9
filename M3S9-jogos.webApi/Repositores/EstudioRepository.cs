using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.Infra;
using Microsoft.EntityFrameworkCore;

namespace M3S9_jogos.webApi.Repositores
{
    public class EstudioRepository
    {
        readonly JogoDbContext _jogoDbContext;

        public EstudioRepository(JogoDbContext jogoDbContext)
        {
            _jogoDbContext = jogoDbContext;
        }

        public Estudio Get(int id)
        {
            var estudio = _jogoDbContext.Set<Estudio>().Where(p => p.Id == id).FirstOrDefault();
            return estudio;
        }

        public List<Estudio> Get()
        {
            var estudios = _jogoDbContext.Set<Estudio>().ToList();
            return estudios;
        }
        public void Insert(Estudio estudio)
        {
            _jogoDbContext.Set<Estudio>().Add(estudio);
            _jogoDbContext.SaveChanges();
        }

        public void Update(Estudio estudio)
        {
            _jogoDbContext.ChangeTracker.Clear();//código para evitar erros de update
            _jogoDbContext.Entry(estudio).State = EntityState.Modified;
            _jogoDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var estudio = _jogoDbContext.Set<Estudio>().Where(p => p.Id == id)
            .First();
            _jogoDbContext.Set<Estudio>().Remove(estudio);
            _jogoDbContext.SaveChanges();
        }
    }
}
