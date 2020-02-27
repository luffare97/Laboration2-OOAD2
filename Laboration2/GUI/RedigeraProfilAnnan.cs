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
    public partial class RedigeraProfilAnnan : Form
    {
        public BusinessManager BusinessManager { get; }

        public RedigeraProfilAnnan(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;

            FNamnTxt.Text = BusinessManager.InloggadAlumn.FNamn;
            ENamnTxt.Text = BusinessManager.InloggadAlumn.ENamn;
            EMailTxt.Text = BusinessManager.InloggadAlumn.EMail;
            TeleNrTxt.Text = BusinessManager.InloggadAlumn.TeleNr.ToString();
            OrtTxt.Text = BusinessManager.InloggadAlumn.Ort;
            AnställningTxt.Text = BusinessManager.InloggadAlumn.Anställning;
            ExamensårTxt.Text = BusinessManager.InloggadAlumn.ExamensÅr.ToString();
            comboBoxProgram.DataSource = Enum.GetValues(typeof(Utbildning));
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SparaLösenordBtn_Click(object sender, EventArgs e)
        {
            if (BusinessManager.InloggadAlumn.Lösenord == GammaltLösenordTxt.Text)
            {
                if (NyttLösenordTxt.Text == UpprepaTxt.Text)
                {
                    string nytt = NyttLösenordTxt.Text;
                    BusinessManager.UnitOfWork.AnvändareRepository.RedigeraLösenord(BusinessManager.InloggadAlumn.AnvändarId, nytt);
                    MessageBox.Show("Ditt nya löseord har nu sparats","Sparat");
                    GammaltLösenordTxt.Clear();
                    NyttLösenordTxt.Clear();
                    UpprepaTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Nya lösenord stämmer inte överrens","Error");
                }
            }
            else
            {
                MessageBox.Show("Fel gammalt lösenord", "Error");
            }
        }

        private void SparaInfoBtn_Click(object sender, EventArgs e)
        {
            bool OK = int.TryParse(TeleNrTxt.Text.ToString(), out int tele);
            bool ÅR = int.TryParse(ExamensårTxt.Text.ToString(), out int år);
            if (OK == true)
            {
                if (ÅR == true)
                {
                    DialogResult Svar;
                    Svar = MessageBox.Show("Är du säker på att du vill spara ändringarna?", "Spara dessa ändringar?", MessageBoxButtons.YesNo);
                    if (Svar == DialogResult.No)
                    {
                        Close();
                    }
                    else if (Svar == DialogResult.Yes)
                    {
                        string ID = BusinessManager.InloggadAlumn.AnvändarId;
                        Utbildning utbildning = (Utbildning)comboBoxProgram.SelectedItem;

                        BusinessManager.UnitOfWork.AlumnRepository.RedigeraAlumn(ID, FNamnTxt.Text, ENamnTxt.Text, EMailTxt.Text, TeleNrTxt.Text, OrtTxt.Text, AnställningTxt.Text, ExamensårTxt.Text, utbildning);
                        BusinessManager.InloggadAlumn = BusinessManager.UnitOfWork.AnvändareRepository.GetAnvändare(BusinessManager.InloggadAlumn.AnvändarId) as Alumn;
                        this.Close();
                    }
                }
                else if (ÅR == false)
                {
                    MessageBox.Show("Examens år får endast bestå av siffror","Error");
                }

            }
            else if (OK == false)
            {
                MessageBox.Show("Telefonnummer måste bestå av endast siffror","Error");
            }


        }
    }
}
