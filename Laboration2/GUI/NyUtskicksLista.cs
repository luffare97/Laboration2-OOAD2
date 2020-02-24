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
    public partial class NyUtskicksLista : Form
    {
        public NyUtskicksLista(BusinessManager businessManager)
        {
            InitializeComponent();
        }
    }
}
