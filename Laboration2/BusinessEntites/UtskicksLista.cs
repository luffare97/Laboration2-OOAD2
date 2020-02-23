using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class UtskicksLista : Entity
    {

        public string Information { get; set; }

        public ICollection<Användare> Användares { get; set; }
        //public ICollection<Alumn> Alumner { get; set; }
        //public ICollection<Student> Studenter { get; set; }
        public UtskicksLista()
        {

        }

        public UtskicksLista(List<Användare> folk, string Info)
        {
            this.Information = Info;
        }
    }
}
