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

        public void UpdatePerson()
        {
            InLoggadJobb.Text = BusinessManager.InloggadAlumn.Anställning;
            InLoggadExamensÅr.Text = BusinessManager.InloggadAlumn.ExamensÅr.ToString();
            InLoggadOrt.Text = BusinessManager.InloggadAlumn.Ort;


            InLoggadNamn.Text = BusinessManager.InloggadAlumn.FNamn + " " + BusinessManager.InloggadAlumn.ENamn;
            InLoggadProgram.Text = BusinessManager.InloggadAlumn.program.ToString();
        }

        public void UpdateGrid()
        {
            //För att fylla List datagriden
            BindingSourceLista.DataSource = BusinessManager.InloggadAlumn.Listor;
            dataGridListor.DataSource = BindingSourceLista.DataSource;

            //För att fylla Aktivitet datagriden
            BindingSourceAktivitet.DataSource = BusinessManager.GetAllAktiviteter();
            dataGridAktiviteter.DataSource = BindingSourceAktivitet.DataSource;
            HideColumns();
        }
        
        public StartAnnan(BusinessManager businessManager)
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

        private void RedigeraBtn_Click(object sender, EventArgs e)
        {

            DialogResult Delete;

            RedigeraProfilAnnan Redigera = new RedigeraProfilAnnan(BusinessManager);
            Delete = Redigera.ShowDialog();

            if (Delete == DialogResult.Yes)
            {
                var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is LoggIn);
                if (formToShow != null)
                {
                    formToShow.Show();
                }

                this.Close();
            }
            else if (Delete == DialogResult.No)
            {
                UpdatePerson();
            }


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

                UpdateGrid();
            }
            
        }

    }
}
