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

            FNamnTxt.Text = businessManager.InloggadPersonal.FNamn;
            ENamnTxt.Text = businessManager.InloggadPersonal.ENamn;
            EMailTxt.Text = businessManager.InloggadPersonal.EMail;
            TeleNrTxt.Text = businessManager.InloggadPersonal.TeleNr.ToString();
            PossitionTxt.Text = businessManager.InloggadPersonal.Possition;
            
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
                BusinessManager.InloggadPersonal = BusinessManager.UnitOfWork.AnvändareRepository.GetAnvändare(BusinessManager.InloggadPersonal.AnvändarId) as Personal;
                
                this.Close();
            }
        }

        private void SparaLösenordBtn_Click(object sender, EventArgs e)
        {
            if (BusinessManager.InloggadPersonal.Lösenord == GammaltLösenordTxt.Text)
            {
                if (NyttLösenordTxt.Text == UpprepaTxt.Text)
                {
                    string nytt = NyttLösenordTxt.Text;
                    BusinessManager.UnitOfWork.AnvändareRepository.RedigeraLösenord(BusinessManager.InloggadPersonal.AnvändarId, nytt);
                    MessageBox.Show("Ditt nya löseord har nu sparats", "Sparat");
                    GammaltLösenordTxt.Clear();
                    NyttLösenordTxt.Clear();
                    UpprepaTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Nya lösenord stämmer inte överrens", "Error");
                }
            }
            else
            {
                MessageBox.Show("Fel gammalt lösenord", "Error");
            }
        }
    }
}
