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

namespace GUI
{
    public partial class StartAnnan : Form
    {
        BindingSource BindingSourceAktivitet = new BindingSource();
        BindingSource BindingSourceLista = new BindingSource();

        public StartAnnan(BusinessManager businessManager)
        {
            InitializeComponent();

            

            BindingSourceAktivitet.DataSource = businessManager.UnitOfWork.AktivitetRepository.GetAllAktiviteter();
            dataGridAktiviteter.DataSource = BindingSourceAktivitet.DataSource;
        }

        private void StartAnnan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
