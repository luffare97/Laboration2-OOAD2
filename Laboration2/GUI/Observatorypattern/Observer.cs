using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Observatorypattern
{
    public abstract class Observer : Button, IObserver1
    {
        public Observer()
        {
            
        }

        public void Uppdate(ISubject subject)
        {

        }

        protected override void OnPrint(PaintEventArgs e)
        {
            base.OnPrint(e);
        }

    }
}
