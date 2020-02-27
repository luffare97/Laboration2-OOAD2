using BusinessEntites;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IUtskicksListaRepository
    {
        void AddMottagare(int id, Alumn A);
        void CreateLista(string titel, string info, List<Alumn> mottagare);
        List<UtskicksLista> GetAllListor();
        UtskicksLista GetLista(int id);
        void RedigeraLista(int id, string titel, string info);
        void RemoveMottagare(int ID, Alumn A);
    }
}