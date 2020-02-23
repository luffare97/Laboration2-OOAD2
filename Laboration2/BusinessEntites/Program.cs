using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Program : Entity
    {
        //public int ProgramId { get; set; }
        public int År { get; set; }
        public ICollection<Användare> Användares { get; set; }


    }
}
