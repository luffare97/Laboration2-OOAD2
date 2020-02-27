using BusinessEntites;
using DataLayer;

namespace BusinessLayer
{
    public interface IBusinessManager
    {
        Alumn InloggadAlumn { get; set; }
        Personal InloggadPersonal { get; set; }
        UnitOfWork UnitOfWork { get; set; }
    }
}