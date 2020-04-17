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
    public partial class SeAktivitetAnnan : Form
    {
        BusinessManager BusinessManager { get; }
        public SeAktivitetAnnan(BusinessManager businessManager, Aktivitet aktivitet)
        {
            InitializeComponent();
            BusinessManager = businessManager;

            //Aktivitet aktivitet = businessManager.UnitOfWork.AktivitetRepository.GetAktivitet(id+1);

            IDTxt.Text = aktivitet.Id.ToString();
            TitelLabel.Text = aktivitet.AktivitetNamn;
            PlatserLabel.Text = aktivitet.AntalPlatser.ToString();
            DatumLabel.Text = aktivitet.Datum.ToString();
            TidLabel.Text = aktivitet.Tid;
            PlatsLabel.Text = aktivitet.Plats;
            BeskrivningBox.Text = aktivitet.Beskrivning;

        }

        private void DeltaBtn_Click(object sender, EventArgs e)
        {

            int id = int.Parse(IDTxt.Text);
            Aktivitet aktivitet = BusinessManager.GetAktivitet(id);
            int deltagare = aktivitet.Deltagare.Count;

            if (deltagare >= aktivitet.AntalPlatser)
            {
                MessageBox.Show("Den här aktiviteten är fullbokad","Fullbokad");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("vill du delta i denna aktivitet?", "Är du säker?", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {
                    Close();
                }
                else if (Svar == DialogResult.Yes)
                {
                    BusinessManager.UnitOfWork.AktivitetRepository.DeltaAktivitet(id, BusinessManager.InloggadAlumn);
                    MessageBox.Show("Du kommer nu att delta den här aktivietetn", "Grattis!");
                }
            }
            
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
