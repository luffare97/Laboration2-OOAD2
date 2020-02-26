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
    public partial class RedigeraProfilPersonal : Form
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraProfilPersonal(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SparaInfoBtn_Click(object sender, EventArgs e)
        {
            DialogResult Svar;
            Svar = MessageBox.Show("Är du säker på att du vill spara ändringarna?", "Spara dessa ändringar?", MessageBoxButtons.YesNo);
            if (Svar == DialogResult.No)
            {
                Close();
            }
            else if (Svar == DialogResult.Yes)
            {
                string ID = BusinessManager.InloggadPersonal.AnvändarId;
                BusinessManager.UnitOfWork.PersonalRepository.RedigeraPersonal(ID, FNamnTxt.Text, ENamnTxt.Text, EMailTxt.Text, TeleNrTxt.Text, PossitionTxt.Text);
                BusinessManager.InloggadPersonal = BusinessManager.UnitOfWork.AnvändareRepository.GetAnvändare(BusinessManager.InloggadAlumn.AnvändarId) as Personal;
                this.Close();
            }
        }

        private void SparaLösenordBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
