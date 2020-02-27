using BusinessEntites;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IAnvändareRepository
    {
        List<Användare> användares { get; set; }
        AppDbContext AppDbContext { get; }

        Användare GetAnvändare(string användarID);
        void RedigeraLösenord(string ID, string nytt);
    }
}