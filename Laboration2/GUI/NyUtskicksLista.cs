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
            //FUNKAR INTE JUST NU
        {
            List<Alumn> A = new List<Alumn>();

            for (int i = 0; i < MottagareLB.SelectedItems.Count; i++)
            {
                Alumn a = (Alumn)MottagareLB.Items[i];
                A.Add(a);
            }

            UtskicksLista L = BusinessManager.UnitOfWork.UtskicksListaRepository.CreateLista(TitelTxt.Text, InfoTxt.Text, A);

            for (int u = 0; u < L.Användares.Count; u++)
            {
                BusinessManager.UnitOfWork.UtskicksListaRepository.AddMottagare(L.Id, A[u]);
            }
            

            //foreach (Alumn a in L.Användares)
            //{
            //    Alumn mottagare = BusinessManager.UnitOfWork.AlumnRepository.GetAlumn(a.AnvändarId);
            //    mottagare.Listor.Add(L);

            //}
            BusinessManager.UnitOfWork.Save();
        }
    }
}
