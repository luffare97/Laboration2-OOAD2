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
    public partial class Registrering : Form
    {

        public BusinessManager BusinessManager { get; }

        public Registrering(BusinessManager businessManager)
        {
            InitializeComponent();
            comboBoxProgram.DataSource = Enum.GetValues(typeof(Utbildning));

            BusinessManager = businessManager;

        }

        private void SparaBtn_Click(object sender, EventArgs e)
        {
            //BusinessManager.UnitOfWork.AlumnRepository.CreateAlumn();
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
