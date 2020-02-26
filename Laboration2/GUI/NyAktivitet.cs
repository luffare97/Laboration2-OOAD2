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

            Svar = MessageBox.Show("Vill du spara den här aktiviteten?", "Vill du spara detta?", MessageBoxButtons.YesNo);
            if (Svar == DialogResult.No)
            {
                Close();
            }
            else if (Svar == DialogResult.Yes)
            {
                int platser = Convert.ToInt32(Math.Round(PlatserField.Value, 0));
                DateTime datum = this.StartDateTime.Value.Date;
                
                BusinessManager.UnitOfWork.AktivitetRepository.CreateAktivitet(TitelTxt.Text, platser, datum, TidTxt.Text, PlatsTxt.Text, BeskrivningTxt.Text);
                MessageBox.Show("Aktiviteten har blivit sparad", "Sparad");
                Close();
            }
        }
    }
}
