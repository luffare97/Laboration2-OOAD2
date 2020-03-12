using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
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
            
            MottagareLB.DataSource = businessManager.UnitOfWork.AlumnRepository.GetAllAlumn();
            MottagareLB.SelectionMode = SelectionMode.MultiExtended;

        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SparaBtn_Click(object sender, EventArgs e)
        {
            

            DialogResult Svar;
            Svar = MessageBox.Show("Vill du spara den här utskickslistan?", "Spara?", MessageBoxButtons.YesNo);

            if (Svar == DialogResult.Yes)
            {
                List<Alumn> A = new List<Alumn>();
                foreach (Alumn a in MottagareLB.SelectedItems)
                {
                    A.Add(a);
                }

                UtskicksLista L = new UtskicksLista(InfoTxt.Text, TitelTxt.Text, new List<Alumn>());

                BusinessManager.CreateList(L, A);
                Close();

            }
            else if (Svar == DialogResult.No)
            {
                Close();
            }

          
            BusinessManager.UnitOfWork.Save();
        }
    }
}
