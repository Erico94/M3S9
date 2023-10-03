using M3S9_jogos.webApi.Domain;

namespace M3S9_jogos.webApi.Repositores
{
    public interface IJogoRepository
    {
        void Delete(int id);
        IEnumerable<Jogo> Get();
        Jogo Get(int id);
        void Insert(Jogo jogo);
        void Update(Jogo jogo);
    }
}