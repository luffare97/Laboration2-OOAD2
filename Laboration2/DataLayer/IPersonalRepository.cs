using BusinessEntites;

namespace DataLayer
{
    public interface IPersonalRepository : IGenericRepository<Personal>
    {
        void RedigeraPersonal(Personal P);

        Personal GetPersonal(string ID);
    }
}