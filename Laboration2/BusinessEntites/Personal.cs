using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Personal : Entity
    {
        public string Possition { get; set; }

        public Personal()
        {

        }

        public Aktivitet skapaAktivitet()
        {
            Aktivitet A = new Aktivitet();

            return A;
        }
    }
}
