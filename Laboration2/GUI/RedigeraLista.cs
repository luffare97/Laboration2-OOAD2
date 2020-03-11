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
    public partial class RedigeraLista : Form
    {
        public BusinessManager BusinessManager { get; }

        public RedigeraLista(BusinessManager businessManager, UtskicksLista lista)
        {
            InitializeComponent();
            BusinessManager = businessManager;

            IDTxt.Text = lista.Id.ToString();
            TitelTxt.Text = lista.Titel;
            MeddelandeBox.Text = lista.Information;


        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SparaBtn_Click(object sender, EventArgs e)
        {
            DialogResult Svar;
            Svar = MessageBox.Show("Vill du spara dessa ändringar?","Spara?",MessageBoxButtons.YesNo);

            if (Svar == DialogResult.Yes)
            {
                int id = int.Parse(IDTxt.Text);
                UtskicksLista L = new UtskicksLista()
                {

                };

                BusinessManager.UnitOfWork.UtskicksListaRepository.RedigeraLista(id, TitelTxt.Text, MeddelandeBox.Text);
                MessageBox.Show("Ändringarna har sparats","Sparat");
                Close();
            }
            else if (Svar == DialogResult.No)
            {
                Close();
            }
        }
    }
}
