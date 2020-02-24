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
    public partial class StartAnnan : Form
    {
        BindingSource BindingSourceAktivitet = new BindingSource();
        BindingSource BindingSourceLista = new BindingSource();
        
        public void HideColumns()
        {
            //Saker som inte ska synas för Utskickslistor
            //dataGridListor.Columns["Användares"].Visible = false;

            //Saker som inte ska synas för Aktiviteter
            dataGridAktiviteter.Columns["Start"].Visible = false;
            dataGridAktiviteter.Columns["Slut"].Visible = false;
            //dataGridAktiviteter.Columns["AntalPlatser"].Visible = false;
            //dataGridAktiviteter.Columns["Plats"].Visible = false;
            dataGridAktiviteter.Columns["ID"].Visible = false;
        }

        public StartAnnan(BusinessManager businessManager)
        {
            InitializeComponent();
            //För att fylla List datagriden
            //BindingSourceLista.DataSource = businessManager.UnitOfWork.UtskicksListaRepository.GetAllListor();
            //dataGridListor.DataSource = BindingSourceLista.DataSource;

            //För att fylla Aktivitet datagriden
            BindingSourceAktivitet.DataSource = businessManager.UnitOfWork.AktivitetRepository.GetAllAktiviteter();
            dataGridAktiviteter.DataSource = BindingSourceAktivitet.DataSource;
            HideColumns();
        }

        private void StartAnnan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
