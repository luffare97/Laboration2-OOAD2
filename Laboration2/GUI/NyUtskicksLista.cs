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
    public partial class NyUtskicksLista : Form
    {
        public BusinessManager BusinessManager { get; }
        public NyUtskicksLista(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;

        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SparaBtn_Click(object sender, EventArgs e)
        {
            List<Användare> A = new List<Användare>();

            for (int i = 0; i < MottagareLB.Items.Count; i++)
            {
                Användare a = (Användare)MottagareLB.Items[i];
                A.Add(a);
            }

            BusinessManager.UnitOfWork.UtskicksListaRepository.CreateLista(TitelTxt.Text, InfoTxt.Text, A);
        }
    }
}
