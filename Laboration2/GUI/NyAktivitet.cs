using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace GUI
{
    public partial class NyAktivitet : Form
    {
        public NyAktivitet(BusinessManager businessManager)
        {
            InitializeComponent();
        }
    }
}
