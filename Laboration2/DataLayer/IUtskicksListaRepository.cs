using BusinessEntites;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IUtskicksListaRepository : IGenericRepository<UtskicksLista>
    {
        void AddMottagare(Alumn A, UtskicksLista L);
        void CreateLista(UtskicksLista L);
        List<UtskicksLista> GetAllListor();
        UtskicksLista GetLista(int id);
        void RedigeraLista(int id, string titel, string info);
        void RemoveMottagare(int ID, Alumn A);
    }
}