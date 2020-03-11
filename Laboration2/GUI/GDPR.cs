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
    public partial class GDPR : Form
    {
        
        public BusinessManager BusinessManager { get; }
        public GDPR(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void JaBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;

            if (GodkännBox.Checked == true)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kontot kan inte skapas ifall du inte läst och godkännt villkåren","Error");
            }
        }

        private void NejBtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.No;
            Close();
        }
    }
}
