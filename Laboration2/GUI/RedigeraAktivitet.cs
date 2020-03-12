using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntites;
using BusinessLayer;

namespace GUI
{
    
    public partial class RedigeraAktivitet : Form
    {

        public BusinessManager BusinessManager { get; }


        public RedigeraAktivitet(BusinessManager businessManager, Aktivitet aktivitet)
        {
            InitializeComponent();
            BusinessManager = businessManager;

            this.DialogResult = DialogResult.No;

            IDLabel.Text = aktivitet.Id.ToString();
            TitelTxt.Text = aktivitet.AktivitetNamn;
            PlatserField.Text = aktivitet.AntalPlatser.ToString();
            DatumDateTime.Text = aktivitet.Datum.ToString();
            TidTxt.Text = aktivitet.Tid;
            PlatsTxt.Text = aktivitet.Plats;
            BeskrivningBox.Text = aktivitet.Beskrivning;


        }

        private void SparaBtn_Click(object sender, EventArgs e)
        {
            DialogResult Svar;
            Svar = MessageBox.Show("Vill du spara de här ändringarna?","Spara?", MessageBoxButtons.YesNo);

            bool OK = int.TryParse(PlatserField.Text.ToString(), out int platser);

            if (OK == true)
            {

                if (Svar == DialogResult.Yes)
                {
                    int id = int.Parse(IDLabel.Text);

                    DateTime datum = this.DatumDateTime.Value.Date;

                    Aktivitet A = new Aktivitet()
                    {

                        AktivitetNamn = TitelTxt.Text,
                        AntalPlatser = platser,
                        Datum = datum,
                        Tid = TidTxt.Text,
                        Plats = PlatsTxt.Text,
                        Beskrivning = BeskrivningBox.Text

                    };

                    BusinessManager.RedigeraAktivitet(id, A);

                    MessageBox.Show("Ändringarna har sparats", "Sparat");
                    Close();
                }
                else if (Svar == DialogResult.No)
                {
                    Close();
                }
            }
            else if (OK == false)
            {
                MessageBox.Show("Platser kan bara anges i siffror", "Error");
            }

        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult Svar;
            Svar = MessageBox.Show("Är du säker på att du vill ta bort den här aktiviteten?","Är du säker?", MessageBoxButtons.YesNo);

            if (Svar == DialogResult.Yes)
            {
                int ID = int.Parse(IDLabel.Text);
                BusinessManager.DeleteAktivitet(ID);
                MessageBox.Show("Aktiviteten har nu blivit raderad","Raderad");
                this.DialogResult = DialogResult.Yes;
            }
            else if (Svar == DialogResult.No)
            {
                this.DialogResult = DialogResult.No;
            }
        
        
        }
    }
}
