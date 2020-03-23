using BusinessEntites;
using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IBusinessManager
    {
        Alumn InloggadAlumn { get; set; }
        Personal InloggadPersonal { get; set; }
        UnitOfWork UnitOfWork { get; set; }

        void AddMottagare(Alumn A, UtskicksLista L);
        void CreateAktivitet(Aktivitet A);
        void CreateAlumn(Alumn A);
        void CreateList(UtskicksLista L);
        void DeleteAktivitet(int id);
        void DeleteAlumn(string id);
        void DeleteLista(int id);
        void DeletePersonal(string id);
        void DeltaAktivitet(int ID, Alumn A);
        Aktivitet GetAktivitet(int ID);
        List<Aktivitet> GetAllAktiviteter();
        List<Alumn> GetAllAlumn();
        List<UtskicksLista> GetAllListor();
        Alumn GetAlumn(string ID);
        Användare GetAnvändare(string id);
        UtskicksLista GetUtskicksLista(int ID);
        void RedigeraAktivitet(int ID, Aktivitet A);
        void RedigeraAlumn(Alumn A);
        void RedigeraLista(int id, string titel, string info);
        void RedigeraLösenord(string ID, string nytt);
        void RedigeraPersonal(Personal P);
        void RemoveMottagare(int ID, Alumn A);
    }
}