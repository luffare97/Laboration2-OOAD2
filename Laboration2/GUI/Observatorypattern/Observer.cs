using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GUI.Observatorypattern
{
    public partial class Observer : Button, IObserver
    {

        
        public Observer()
        {
            //InitializeComponent();
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
