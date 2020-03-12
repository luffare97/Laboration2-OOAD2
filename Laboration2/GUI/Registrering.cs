﻿using System;
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

            if (textBoxLösenord1.Text == textBoxLösenord2.Text)
            {

                bool OK = int.TryParse(textBoxTeleNr.Text.ToString(), out int tele);
                bool ÅR = int.TryParse(textBoxÅr.Text.ToString(), out int år);

                if (ÅR == true)
                {

                    if (OK == true)
                    {
                        Utbildning utbildning = (Utbildning)comboBoxProgram.SelectedItem;

                        DialogResult Svar;

                        Svar = MessageBox.Show("Vill du spara den här användaren?", "Vill du spara detta?", MessageBoxButtons.YesNo);
                        if (Svar == DialogResult.No)
                        {
                            Close();
                        }
                        else if (Svar == DialogResult.Yes)
                        {
                            //Här är Ska vi visa GDPR grejen och sen ta tillbaks en bool som säger ifall det är godkännt eller inte och sen antingen göra ett inlogg eller inte


                            DialogResult Gkänd;

                            GDPR gdpr = new GDPR(BusinessManager);
                            Gkänd = gdpr.ShowDialog();

                            if (Gkänd == DialogResult.Yes)
                            {


                                IAlumn A = new Alumn()
                                {
                                    FNamn = FNamnTxt.Text,
                                    ENamn = ENamnTxt.Text,
                                    EMail = EMailTxt.Text,
                                    TeleNr = tele,
                                    Ort = OrtTxt.Text,
                                    Anställning = AnställningTxt.Text,
                                    ExamensÅr = år,
                                    program = utbildning,
                                    Lösenord = textBoxLösenord1.Text

                                };

                                BusinessManager.CreateAlumn(A);
                                MessageBox.Show($"Användaren är sparad \n Ditt användar ID är: s{BusinessManager.UnitOfWork.AnvändareRepository.AppDbContext.Användares.Count()}", "Sparad");
                                
                                Close();
                            }
                            else if (Gkänd == DialogResult.No)
                            {
                                MessageBox.Show("Du måste godkänna vilkåren för att få lov att skapa ett konto","Error");
                            }

                        }
                    }
                    else if (OK == false)
                    {
                        MessageBox.Show("Telefonnummer kan bara bestå av siffror", "Error");
                    }

                }
                else
                {
                    MessageBox.Show("Examensår måste vara siffror","Error");
                }

            }
            else
            {
                MessageBox.Show("Lösenorden stämmer inte överrens","Error");
            }

        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
