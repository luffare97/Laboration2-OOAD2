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
    public partial class SeUtskicksListaAnnan : Form
    {
        public BusinessManager BusinessManager { get; }
        public SeUtskicksListaAnnan(BusinessManager businessManager, UtskicksLista utskicksLista)
        {
            InitializeComponent();
            BusinessManager = businessManager;

            IDTxt.Text = utskicksLista.Id.ToString();
            TitelTxt.Text = utskicksLista.Titel;
            MeddelandBox.Text = utskicksLista.Information;

        }

        private void SlutaFölja_Click(object sender, EventArgs e)
        {
            DialogResult Svar;
            Svar = MessageBox.Show("Är du säker på att du vill sluta följa den här listan?", "Är du säker?", MessageBoxButtons.YesNo);

            if (Svar == DialogResult.Yes)
            {
                int id = int.Parse(IDTxt.Text);
                BusinessManager.RemoveMottagare(id, BusinessManager.InloggadAlumn);
                BusinessManager.InloggadAlumn = BusinessManager.GetAlumn(BusinessManager.InloggadAlumn.AnvändarId);
                Close();

            }
            else if (Svar == DialogResult.No)
            {
                Close();
            }
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
