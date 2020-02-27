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
            Svar = MessageBox.Show("Vill du spara de här ändringarna?","Spara?");

            if (Svar == DialogResult.Yes)
            {
                int id = int.Parse(IDLabel.Text);
                int platser = Convert.ToInt32(Math.Round(PlatserField.Value, 0));
                DateTime datum = this.DatumDateTime.Value.Date;

                BusinessManager.UnitOfWork.AktivitetRepository.RedigeraAktivitet(id, TitelTxt.Text, platser, datum, TidTxt.Text, PlatsTxt.Text, BeskrivningBox.Text);
                MessageBox.Show("Ändringarna har sparats","Sparat") ;
                Close();
            }
            else if (Svar == DialogResult.No)
            {
                Close();
            }
            
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
