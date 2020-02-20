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
        private string Lösenord { get; set; }
        public string FNamn { get; set; }
        public string ENamn { get; set; }
        public string EMail { get; set; }
        public int TeleNr { get; set; }

        //kanske ska flyttas ifall personal behöver ha en lista med program istället då de kan undervisa i fler program, eller kanske inte behövs i personal alls 
        public Program Program { get; set; }

    }
}
