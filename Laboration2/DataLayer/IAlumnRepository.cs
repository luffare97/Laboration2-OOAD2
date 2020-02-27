using BusinessEntites;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IAlumnRepository
    {
        void CreateAlumn(string Fnamn, string Enamn, string EMail, int tele, string Ort, string Job, string Lösenord, Utbildning utb, int år);
        List<Alumn> GetAllAlumn();
        Alumn GetAlumn(string ID);
        void RedigeraAlumn(string ID, string Fnamn, string Enamn, string EMail, string TeleNr, string Ort, string Job, string ÅR, Utbildning utbildning);
    }
}