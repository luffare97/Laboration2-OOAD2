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
using DataLayer;

namespace GUI
{
    public partial class LoggIn : Form
    {
        
        public BusinessManager BusinessManager { get; }

        public LoggIn(BusinessManager businessManager)
        {
            
            InitializeComponent();
            BusinessManager = businessManager;
        }

        private void LoggaInBtn_Click(object sender, EventArgs e)
        {
                
            Användare A = BusinessManager.UnitOfWork.AnvändareRepository.GetAnvändare(IDTxt.Text);

            if (A == null)
            {
                MessageBox.Show("AnvändarIDt eller lösenordet stämmer inte", "Error");

            }
            else if (A.Lösenord == LösenordTxt.Text)
            {
                if ((A as Personal) != null)
                {
                    BusinessManager.InloggadPersonal = A as Personal;
                    MessageBox.Show($"Användare: {A.FNamn + " " + A.ENamn } \nLösenord: {A.Lösenord}");
                    StartPersonal startPersonal = new StartPersonal(BusinessManager);
                    this.Hide();
                    startPersonal.ShowDialog();
                    
                    this.Close();


                }
                else if((A as Alumn) != null)
                {
                    BusinessManager.InloggadAlumn = A as Alumn;
                    //MessageBox.Show($"Användare: {A.FNamn + " " + A.ENamn } \nLösenord: {A.Lösenord}");
                    StartAnnan startAnnan = new StartAnnan(BusinessManager);
                    this.Hide();
                    startAnnan.ShowDialog();

                    this.Close();


                }

            }
        }

        private void RegistreraBtn_Click(object sender, EventArgs e)
        {
            Registrering registrering = new Registrering(BusinessManager);
            registrering.ShowDialog();
        }
    }
}
