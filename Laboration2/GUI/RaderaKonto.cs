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
    public partial class RaderaKonto : Form
    {

        public BusinessManager BusinessManager { get; }
        public RaderaKonto(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;
        
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            DialogResult Svar;
            Svar = MessageBox.Show("Är du säker på att du vill radera kontot?","Är du helt säker?", MessageBoxButtons.YesNo);

            if (Svar == DialogResult.Yes)
            {
                if (Lösen1.Text == Lösen2.Text)
                {
                    if (Lösen1.Text == BusinessManager.InloggadAlumn.Lösenord)
                    {
                        BusinessManager.DeleteAlumn(BusinessManager.InloggadAlumn.AnvändarId);
                        MessageBox.Show("Kontot har nu blivit raderat och du kommer flyttas tillbaka till inloggningsskärmen","Raderat");
                        this.DialogResult = DialogResult.Yes;
                        Close();
                    }
                    else if (Lösen1.Text == BusinessManager.InloggadPersonal.Lösenord)
                    {
                        BusinessManager.DeletePersonal(BusinessManager.InloggadPersonal.AnvändarId);
                        MessageBox.Show("Kontot har nu blivit raderat och du kommer flyttas tillbaka till inloggningsskärmen", "Raderat");
                        this.DialogResult = DialogResult.Yes;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Lösenordet stämmer inte","Error");
                    }
                }
                else if (Lösen1.Text != Lösen2.Text)
                {
                    MessageBox.Show("Lösenorden stämmer inte övverens","Fel");
                }
            }
            else if (Svar == DialogResult.No)
            {

            }
        
        
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }
    }
}
