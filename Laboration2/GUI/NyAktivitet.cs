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
    public partial class NyAktivitet : Form
    {
        public BusinessManager BusinessManager { get; }
        public NyAktivitet(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SparaBtn_Click(object sender, EventArgs e)
        {
            DialogResult Svar;
            bool OK = int.TryParse(PlatserField.Text.ToString(), out int platser);

            if (OK == true)
            {


                Svar = MessageBox.Show("Vill du spara den här aktiviteten?", "Vill du spara detta?", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {
                    Close();
                }
                else if (Svar == DialogResult.Yes)
                {
                    
                    DateTime datum = this.StartDateTime.Value.Date;

                    Aktivitet A = new Aktivitet()
                    {
                        AktivitetNamn = TitelTxt.Text,
                        AntalPlatser = platser,
                        Datum = datum,
                        Tid = TidTxt.Text,
                        Plats = PlatsTxt.Text,
                        Beskrivning = BeskrivningTxt.Text

                    };

                    BusinessManager.CreateAktivitet(A);
                    MessageBox.Show("Aktiviteten har blivit sparad", "Sparad");
                    Close();
                }
            }
            else if (OK == false)
            {
                MessageBox.Show("Platser kan bara anges i form av sifror", "Error");
            }
        }
    }
}
