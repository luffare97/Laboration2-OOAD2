using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Alumn : Entity
    {
        public string Ort { get; set; }
        public string Anställning { get; set; }
        public Program Program { get; set; }

        //Kanske DateTime istället?
        public int ExamensÅr { get; set; }

        public Alumn()
        {

        }

    }
}
