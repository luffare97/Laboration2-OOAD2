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
using GUI.Observatorypattern;

namespace GUI
{
    public partial class GDPR : Form
    {
        
        public BusinessManager BusinessManager { get; }

        ObserverRadioBtn observerRadioBtn { get; set; } = new ObserverRadioBtn();       

        Jaknapp Jaknapp { get; set; } = new Jaknapp();


        public GDPR(BusinessManager businessManager)
        {
            InitializeComponent();


            this.Controls.Add(observerRadioBtn);

            observerRadioBtn.Location = radioButton1.Location;
            observerRadioBtn.Text = radioButton1.Text;
            observerRadioBtn.Width = radioButton1.Width;
            radioButton1.Hide();

            observerRadioBtn.CheckedChanged += radioButton1_CheckChanged;

            

            this.Controls.Add(Jaknapp);

            Jaknapp.Location = JaBtn.Location;
            Jaknapp.Text = JaBtn.Text;
            JaBtn.Hide();

            Jaknapp.Click += JaBtn_Click;

            Jaknapp.Subject.RegisterObserver(observerRadioBtn);

            BusinessManager = businessManager;


        }

        private void radioButton1_CheckChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void JaBtn_Click(object sender, EventArgs e)
        {

            Jaknapp.Subject.Notify();

            this.DialogResult = DialogResult.No;

            if (observerRadioBtn.Checked == true)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kontot kan inte skapas ifall du inte läst och godkännt vilkåren","Error");
            }
        }

        private void NejBtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.No;
            Close();
        }

        //public class GodkännBoxen
        //{
            void GodkännBox_CheckedChanged(object sender, EventArgs e)
           {
               

          }
        //}
        

        
    }
}
