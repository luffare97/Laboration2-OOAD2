using BusinessEntites;

namespace DataLayer
{
    public interface IPersonalRepository
    {
        void RedigeraPersonal(Personal P);
        Personal GetPersonal(string ID);
    }
}