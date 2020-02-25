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

            BusinessManager = businessManager;

            InLoggadJobb.Text = businessManager.InloggadAlumn.Anställning;
             InLoggadExamensÅr.Text = businessManager.InloggadAlumn.ExamensÅr.ToString();
             InLoggadOrt.Text = businessManager.InloggadAlumn.Ort;


            InLoggadNamn.Text = businessManager.InloggadAlumn.FNamn + " " + businessManager.InloggadAlumn.ENamn;
            InLoggadProgram.Text = businessManager.InloggadAlumn.program.ToString();


            //För att fylla List datagriden
            BindingSourceLista.DataSource = businessManager.UnitOfWork.UtskicksListaRepository.GetAllListor();
            dataGridListor.DataSource = BindingSourceLista.DataSource;

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

        private void LoggaUtBtn_Click(object sender, EventArgs e)
        {

            //Kolla på senare kanske annars bara this.Close();
            //BusinessManager.InloggadAlumn = null;
            //LoggIn InLogg = new LoggIn(BusinessManager);
            //this.Close();
            //InLogg.ShowDialog();
            this.Close();

            
        }
    }
}
