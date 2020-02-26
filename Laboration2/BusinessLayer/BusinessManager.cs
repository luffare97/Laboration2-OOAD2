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

        public Personal InloggadPersonal { get; set; }
        public Alumn InloggadAlumn { get; set; }


    }


}
