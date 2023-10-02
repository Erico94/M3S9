using M3S9_jogos.webApi.Domain;

namespace M3S9_jogos.webApi.Repositores
{
    public interface IEstudioRepository
    {
        void Delete(int id);
        List<Estudio> Get();
        Estudio Get(int id);
        void Insert(Estudio estudio);
        void Update(Estudio estudio);
    }
}