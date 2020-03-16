using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GUI.GDPR;

namespace GUI.Observatorypattern
{
    class Checkboxen :/* GodkännBoxen*/ IObserver1
    {
        bool active = false;
        
        public void Uppdate(ISubject subject)
        {
            //if (!GodkännBoxen.Godkännbox.Checked)
            //{
            //    ConsoleColor color = color.Red;
            //}

        }
    }
}
