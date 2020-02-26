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
using BusinessEntites;

namespace GUI
{
    public partial class SeUtskicksListaPersonal : Form
    {
        public SeUtskicksListaPersonal(BusinessManager businessManager, UtskicksLista lista)
        {
            InitializeComponent();
        }
    }
}
