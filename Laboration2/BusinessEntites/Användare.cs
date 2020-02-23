using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Användare : Entity
    {
        public string AnvändarId { get; set; }
        public string Lösenord { get; set; }
        public string FNamn { get; set; }
        public string ENamn { get; set; }
        public string EMail { get; set; }
        public int TeleNr { get; set; }

        public Användare()
        {

        }

    }
}
