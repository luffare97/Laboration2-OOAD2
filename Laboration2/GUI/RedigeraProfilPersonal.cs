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

            FNamnTxt.Text = BusinessManager.InloggadPersonal.FNamn;
            ENamnTxt.Text = BusinessManager.InloggadPersonal.ENamn;
            EMailTxt.Text = BusinessManager.InloggadPersonal.EMail;
            TeleNrTxt.Text = BusinessManager.InloggadPersonal.TeleNr.ToString();
            PossitionTxt.Text = BusinessManager.InloggadPersonal.Possition;
            
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SparaInfoBtn_Click(object sender, EventArgs e)
        {

            bool OK = int.TryParse(TeleNrTxt.Text.ToString(), out int tele);

            if (OK == true)
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



                    Personal P = new Personal()
                    {
                        AnvändarId = BusinessManager.InloggadPersonal.AnvändarId,
                        FNamn = FNamnTxt.Text,
                        ENamn = ENamnTxt.Text,
                        EMail = EMailTxt.Text,
                        TeleNr = tele,
                        Possition = PossitionTxt.Text

                    };
    
                    BusinessManager.RedigeraPersonal(P);
                    BusinessManager.InloggadPersonal = P;

                    this.Close();
                }
            }
            else if (OK == false)
            {
                MessageBox.Show("Telefonnummer kan bara bestå av siffror", "Error");
            }
        }

        private void SparaLösenordBtn_Click(object sender, EventArgs e)
        {
            if (BusinessManager.InloggadPersonal.Lösenord == GammaltLösenordTxt.Text)
            {
                if (NyttLösenordTxt.Text == UpprepaTxt.Text)
                {
                    string nytt = NyttLösenordTxt.Text;
                    BusinessManager.RedigeraLösenord(BusinessManager.InloggadPersonal.AnvändarId, nytt);
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
