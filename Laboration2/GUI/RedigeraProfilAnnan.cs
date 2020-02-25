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
    public partial class RedigeraProfilAnnan : Form
    {
        public RedigeraProfilAnnan(BusinessManager businessManager)
        {
            InitializeComponent();

            FNamnTxt.Text = businessManager.InloggadAlumn.FNamn;
            ENamnTxt.Text = businessManager.InloggadAlumn.ENamn;
            EMailTxt.Text = businessManager.InloggadAlumn.EMail;
            TeleNrTxt.Text = businessManager.InloggadAlumn.TeleNr.ToString();
            OrtTxt.Text = businessManager.InloggadAlumn.Ort;
            AnställningTxt.Text = businessManager.InloggadAlumn.Anställning;
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SparaLösenordBtn_Click(object sender, EventArgs e)
        {

        }

        private void SparaInfoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
