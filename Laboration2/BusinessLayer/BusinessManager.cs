using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace BusinessLayer
{

    public class BusinessManager
    {

        public UnitOfWork UnitOfWork { get; set; }

        public BusinessManager(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        //public AktivitetRepository AktivitetRepo { get; set; }
        //public AlumnRepository AlumnRepo { get; set; }
        //public AnvändareRepository AnvändarRepo { get; set; }
        //public PersonalRepository PersonalRepo { get; set; }
        //public StudentRepository StudentRepo { get; set; }
        //public UtskicksListaRepository ListRepo { get; set; }
    }


}
