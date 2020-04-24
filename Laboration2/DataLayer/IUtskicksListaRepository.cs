using BusinessEntites;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataLayer
{
    public interface IUtskicksListaRepository : IGenericRepository <UtskicksLista>
    {
        void AddMottagare(Alumn A, UtskicksLista L);
        void CreateLista(UtskicksLista L);
        List<UtskicksLista> GetAllListor();
        ObservableCollection<Alumn> GetAlumnForList(int id);
        UtskicksLista GetLista(int id);
        void RedigeraLista(int id, string titel, string info);
        void RemoveMottagare(int ID, Alumn A);


        List<Alumn> HämtaTillgängligaAlumner(UtskicksLista lista);
    }
}