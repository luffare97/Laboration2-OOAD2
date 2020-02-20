using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class UtskicksLista : Entity
    {
        public List<Alumn> Alumner { get; set; }
        public List<Student> Studenter { get; set; }
        public List<Aktivitet> Aktiviteter { get; set; }
        public string Information { get; set; }

        public UtskicksLista(List<Användare> folk, string Info)
        {
            this.Information = Info;
        }
    }
}
