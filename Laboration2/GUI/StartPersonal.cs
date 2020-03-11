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

        public void UpdatePerson()
        {
            InLoggadNamn.Text = BusinessManager.InloggadPersonal.FNamn + " " + BusinessManager.InloggadPersonal.ENamn;
            InLoggadPosition.Text = BusinessManager.InloggadPersonal.Possition;
        }

        public void UpdateGrid()
        {
            //För att fylla List datagriden
            BindingSourceLista.DataSource = BusinessManager.GetAllListor();
            dataGridListor.DataSource = BindingSourceLista.DataSource;

            //För att fylla Aktivitet datagriden
            BindingSourceAktivitet.DataSource = BusinessManager.GetAllAktiviteter();
            dataGridAktiviteter.DataSource = BindingSourceAktivitet.DataSource;
            HideColumns();
        }

        public StartPersonal(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;

            UpdatePerson();
            UpdateGrid();
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
                UpdateGrid();
            }
            
        }

        private void LoggaUtBtn_Click(object sender, EventArgs e)
        {
            
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is LoggIn);
            if (formToShow != null)
            {
                formToShow.Show();
            }

            this.Close();

        }

        private void RedigeraProfilBtn_Click(object sender, EventArgs e)
        {
            RedigeraProfilPersonal Redigera = new RedigeraProfilPersonal(BusinessManager);
            Redigera.ShowDialog();
            UpdatePerson();
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
                UpdateGrid();
            }
            
        }

        private void SkapaAktivitetBtn_Click(object sender, EventArgs e)
        {
            
            NyAktivitet nyAktivitet = new NyAktivitet(BusinessManager);
            nyAktivitet.ShowDialog();
            UpdateGrid();

        }

        private void SkapaNyLista_Click(object sender, EventArgs e)
        {
            NyUtskicksLista nyLista = new NyUtskicksLista(BusinessManager);
            nyLista.ShowDialog();
            UpdateGrid();
        }

    }
}
