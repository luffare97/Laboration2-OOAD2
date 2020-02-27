namespace DataLayer
{
    public interface IPersonalRepository
    {
        void RedigeraPersonal(string ID, string Fnamn, string Enamn, string Email, string TeleNr, string possition);
    }
}