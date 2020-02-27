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
    public partial class StartAnnan : Form
    {
        BindingSource BindingSourceAktivitet = new BindingSource();
        BindingSource BindingSourceLista = new BindingSource();

        public BusinessManager BusinessManager { get; }

        
        public StartAnnan(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;

            InLoggadJobb.Text = businessManager.InloggadAlumn.Anställning;
            InLoggadExamensÅr.Text = businessManager.InloggadAlumn.ExamensÅr.ToString();
            InLoggadOrt.Text = businessManager.InloggadAlumn.Ort;


            InLoggadNamn.Text = businessManager.InloggadAlumn.FNamn + " " + businessManager.InloggadAlumn.ENamn;
            InLoggadProgram.Text = businessManager.InloggadAlumn.program.ToString();


            //För att fylla List datagriden
            BindingSourceLista.DataSource = businessManager.InloggadAlumn.Listor; //businessManager.UnitOfWork.UtskicksListaRepository.GetAllListor();
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
            dataGridAktiviteter.Columns["deltagare"].Visible = false;
            //dataGridAktiviteter.Columns["AntalPlatser"].Visible = false;
            //dataGridAktiviteter.Columns["Plats"].Visible = false;
            dataGridAktiviteter.Columns["ID"].Visible = false;
        }

        private void StartAnnan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Välj aktivitet
            

            Aktivitet aktivitet = (Aktivitet)dataGridAktiviteter.CurrentRow.DataBoundItem;

            if (aktivitet == null)
            {
                MessageBox.Show("Du har inte valt en aktivitet", "Error");
            }
            else
            {
                SeAktivitetAnnan seAktivitet = new SeAktivitetAnnan(BusinessManager, aktivitet);
                seAktivitet.ShowDialog();
            }
            


        }

        private void LoggaUtBtn_Click(object sender, EventArgs e)
        {

            //Kolla på senare kanske annars bara this.Close();
            //BusinessManager.InloggadAlumn = null;
            //LoggIn InLogg = new LoggIn(BusinessManager);
            //this.Close();
            //InLogg.ShowDialog();
            this.Close();

            
        }

        private void RedigeraBtn_Click(object sender, EventArgs e)
        {
            RedigeraProfilAnnan Redigera = new RedigeraProfilAnnan(BusinessManager);
            Redigera.ShowDialog();
        }

        private void VäljListaBtn_Click(object sender, EventArgs e)
        {
            //Välj lista
            UtskicksLista lista = (UtskicksLista)dataGridListor.CurrentRow.DataBoundItem;
            
            if (lista == null)
            {
                MessageBox.Show("Du har inte valt en lista","Error");
            }
            else
            {
                SeUtskicksListaAnnan SeLista = new SeUtskicksListaAnnan(BusinessManager, lista);
                SeLista.ShowDialog();
            }
            
        }

        private void UppdateraBtn_Click(object sender, EventArgs e)
        {
            //Funkar inte
            this.Refresh();
        }
    }
}
