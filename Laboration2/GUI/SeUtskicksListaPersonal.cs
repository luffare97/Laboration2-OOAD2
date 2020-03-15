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
    public partial class SeUtskicksListaPersonal : Form
    {
        public BusinessManager BusinessManager { get; }

        public void UpdateLista()
        {
            int ID = int.Parse(IDTxt.Text);

            MottagareLB.Items.Clear();

            UtskicksLista lista = BusinessManager.GetUtskicksLista(ID);

            IDTxt.Text = lista.Id.ToString();
            TitelTxt.Text = lista.Titel;
            MeddelandeBox.Text = lista.Information;

            foreach (Alumn a in lista.Mottagare)
            {
                MottagareLB.Items.Add(a);
            }

        }


        public SeUtskicksListaPersonal(BusinessManager businessManager, UtskicksLista lista)
        {
            InitializeComponent();


            BusinessManager = businessManager;

            UtskicksLista L = BusinessManager.GetUtskicksLista(lista.Id);

            IDTxt.Text = L.Id.ToString();
            TitelTxt.Text = L.Titel;
            MeddelandeBox.Text = L.Information;

            foreach (Alumn a in L.Mottagare)
            {
                MottagareLB.Items.Add(a);
            }

        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RedigeraBtn_Click(object sender, EventArgs e)
        {


            DialogResult Delete;
            int id = int.Parse(IDTxt.Text);
            UtskicksLista L = BusinessManager.GetUtskicksLista(id);

            RedigeraLista redigeraLista = new RedigeraLista(BusinessManager, L);
            Delete = redigeraLista.ShowDialog();

            if (Delete == DialogResult.Yes)
            {
                
                Close();
            }
            else if (Delete == DialogResult.No)
            {
               
                UpdateLista();
            }
        }

        private void SeUtskicksListaPersonal_Load(object sender, EventArgs e)
        {

        }

        private void MottagareLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
