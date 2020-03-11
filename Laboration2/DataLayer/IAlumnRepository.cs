using BusinessEntites;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IAlumnRepository
    {
        void CreateAlumn(Alumn A);
        List<Alumn> GetAllAlumn();
        Alumn GetAlumn(string ID);
        void RedigeraAlumn(Alumn A);
    }
}