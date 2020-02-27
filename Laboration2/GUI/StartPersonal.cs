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
    public partial class StartPersonal : Form
    {
        BindingSource BindingSourceAktivitet = new BindingSource();
        BindingSource BindingSourceLista = new BindingSource();

        public BusinessManager BusinessManager { get; }

        public StartPersonal(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;

            InLoggadNamn.Text = businessManager.InloggadPersonal.FNamn + " " + businessManager.InloggadPersonal.ENamn;
            InLoggadPosition.Text = businessManager.InloggadPersonal.Possition;


            //För att fylla List datagriden
            BindingSourceLista.DataSource = businessManager.UnitOfWork.UtskicksListaRepository.GetAllListor();
            dataGridListor.DataSource = BindingSourceLista.DataSource;

            //För att fylla Aktivitet datagriden
            BindingSourceAktivitet.DataSource = businessManager.UnitOfWork.AktivitetRepository.GetAllAktiviteter();
            dataGridAktiviteter.DataSource = BindingSourceAktivitet.DataSource;
            HideColumns();
        }

        public void HideColumns()
        {
            //Saker som inte ska synas för Utskickslistor
            dataGridListor.Columns["Användares"].Visible = false;

            //Saker som inte ska synas för Aktiviteter
            dataGridAktiviteter.Columns["datum"].Visible = false;
            dataGridAktiviteter.Columns["tid"].Visible = false;
            //dataGridAktiviteter.Columns["AntalPlatser"].Visible = false;
            //dataGridAktiviteter.Columns["Plats"].Visible = false;
            dataGridAktiviteter.Columns["ID"].Visible = false;
        }

        private void VäljListaBtn_Click(object sender, EventArgs e)
        {
            UtskicksLista lista = (UtskicksLista)dataGridListor.CurrentRow.DataBoundItem;

            if (lista == null)
            {
                MessageBox.Show("Du har inte valt en aktivitet", "Error");
            }
            else
            {
                SeUtskicksListaPersonal seLista = new SeUtskicksListaPersonal(BusinessManager, lista);
                seLista.ShowDialog();
            }
            
        }

        private void LoggaUtBtn_Click(object sender, EventArgs e)
        {
            //Kolla på senare kanske annars bara this.Close();//

            //BusinessManager.InloggadPersonal = null;
            //LoggIn InLogg = new LoggIn(BusinessManager);
            //this.Close();
            //InLogg.ShowDialog();

            this.Close();

        }

        private void RedigeraProfilBtn_Click(object sender, EventArgs e)
        {
            RedigeraProfilPersonal Redigera = new RedigeraProfilPersonal(BusinessManager);
            Redigera.ShowDialog();
        }

        private void VäljaAktivitetBtn_Click(object sender, EventArgs e)
        {
            Aktivitet aktivitet = (Aktivitet)dataGridAktiviteter.CurrentRow.DataBoundItem;


            if (aktivitet == null)
            {
                MessageBox.Show("Du har inte valt en aktivitet", "Error");
            }
            else
            {
                SeAktivitetPersonal seAktivitet = new SeAktivitetPersonal(BusinessManager, aktivitet);
                seAktivitet.ShowDialog();
            }
            
        }

        private void SkapaAktivitetBtn_Click(object sender, EventArgs e)
        {
            
            NyAktivitet nyAktivitet = new NyAktivitet(BusinessManager);
            nyAktivitet.ShowDialog();

        }

        private void SkapaNyLista_Click(object sender, EventArgs e)
        {
            NyUtskicksLista nyLista = new NyUtskicksLista(BusinessManager);
            nyLista.ShowDialog();
        }
    }
}
