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
    public partial class RedigeraProfilPersonal : Form
    {
        public RedigeraProfilPersonal(BusinessManager businessManager)
        {
            InitializeComponent();
            
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SparaInfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void SparaLösenordBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
