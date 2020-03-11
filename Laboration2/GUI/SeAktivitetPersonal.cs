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
    public partial class SeAktivitetPersonal : Form
    {
        BusinessManager BusinessManager { get; }

        public void UpdateAktivitet()
        {
            int ID = int.Parse(IDLabel.Text);
            Aktivitet A = BusinessManager.GetAktivitet(ID);

            IDLabel.Text = A.Id.ToString();
            TitelLabel.Text = A.AktivitetNamn;
            PlatserLabel.Text = A.AntalPlatser.ToString();
            DatumLabel.Text = A.Datum.ToString();
            TidLabel.Text = A.Tid;
            PlatsLabel.Text = A.Plats;
            BeskrivningBox.Text = A.Beskrivning;
        }

        public SeAktivitetPersonal(BusinessManager businessManager, Aktivitet aktivitet)
        {
            InitializeComponent();
            BusinessManager = businessManager;

            IDLabel.Text = aktivitet.Id.ToString();
            TitelLabel.Text = aktivitet.AktivitetNamn;
            PlatserLabel.Text = aktivitet.AntalPlatser.ToString();
            DatumLabel.Text = aktivitet.Datum.ToString();
            TidLabel.Text = aktivitet.Tid;
            PlatsLabel.Text = aktivitet.Plats;
            BeskrivningBox.Text = aktivitet.Beskrivning;
        }

        private void SeAktivitetPersonal_Load(object sender, EventArgs e)
        {

        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RedigeraBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDLabel.Text);
            Aktivitet aktivitet = BusinessManager.GetAktivitet(id);
            RedigeraAktivitet Redigera = new RedigeraAktivitet(BusinessManager, aktivitet);
            Redigera.ShowDialog();

            UpdateAktivitet();


        }
    }
}
