using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.Infra;
using Microsoft.EntityFrameworkCore;

namespace M3S9_jogos.webApi.Repositores
{
    public class JogoRepository : IJogoRepository
    {
        readonly JogoDbContext _jogoDbContext;
        readonly IJogoRepository _jogoRepository;
        public JogoRepository(JogoDbContext jogoDbContext, IJogoRepository jogoRepository)
        {
            _jogoDbContext = jogoDbContext;
            _jogoRepository = jogoRepository;   
        }

        public Jogo Get(int id)
        {
            var jogo = _jogoDbContext.Set<Jogo>().Where(p => p.Id == id).FirstOrDefault();
            return jogo;
        }

        public List<Jogo> Get()
        {
            var jogos = _jogoDbContext.Set<Jogo>().ToList();
            return jogos;
        }
        public void Insert(Jogo jogo)
        {
            _jogoDbContext.Set<Jogo>().Add(jogo);
            _jogoDbContext.SaveChanges();
        }

        public void Update(Jogo jogo)
        {
            _jogoDbContext.ChangeTracker.Clear();//código para evitar erros de update
            _jogoDbContext.Entry(jogo).State = EntityState.Modified;
            _jogoDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var jogo = _jogoDbContext.Set<Jogo>().Where(p => p.Id == id)
            .First();
            _jogoDbContext.Set<Jogo>().Remove(jogo);
            _jogoDbContext.SaveChanges();
        }

        IEnumerable<Jogo> IJogoRepository.Get()
        {
            throw new NotImplementedException();
        }
    }
}
