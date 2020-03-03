using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GDPR : Form
    {
        public bool godkännd { get; set; }
        

        public GDPR()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void JaBtn_Click(object sender, EventArgs e)
        {
            godkännd = false;

            if (GodkännBox.Checked == true)
            {
                godkännd = true;
            }
            else
            {
                MessageBox.Show("Kontot kan inte skapas ifall du inte läst och godkännt villkåren","Error");
            }
        }

        private void NejBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Om du inte godkänner villkåren kan inte ett konto skapas","Konto skapas inte");
            godkännd = false;
            Close();
        }
    }
}
