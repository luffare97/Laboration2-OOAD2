using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public interface IAlumnRepository
    {
        IEnumerable<Alumn> GetAllSystemvetare();
    }
}
