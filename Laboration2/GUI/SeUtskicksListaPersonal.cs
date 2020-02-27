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
        public SeUtskicksListaPersonal(BusinessManager businessManager, UtskicksLista lista)
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

        private void RedigeraBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTxt.Text);
            UtskicksLista lista = BusinessManager.UnitOfWork.UtskicksListaRepository.GetLista(id);
            RedigeraLista Redigera = new RedigeraLista(BusinessManager, lista);
            Redigera.ShowDialog();
        }
    }
}
