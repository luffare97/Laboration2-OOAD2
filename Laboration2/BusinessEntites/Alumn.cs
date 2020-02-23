using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessEntites.Program;

namespace BusinessEntites
{
    public class Alumn : Användare
    {
        public string Ort { get; set; }
        public string Anställning { get; set; }
        public NamnPåProgram program { get; set; }

        //Kanske DateTime istället?
        public int ExamensÅr { get; set; }

        public Alumn()
        {

        }

    }
}
