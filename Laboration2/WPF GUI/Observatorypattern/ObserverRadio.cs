using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GUI.GDPR;
using System.Windows.Forms;
using System.Drawing;

namespace GUI.Observatorypattern
{
    class ObserverRadioBtn : RadioButton, IObserver
    {
        bool active = false;
        
        public void Uppdate(ISubject subject)
        {
            if (!Checked)
            {
                ForeColor = Color.Red;
            }
            else
            {
                ForeColor = Color.Green;
            }


            active = !active;
        }
    }
}
