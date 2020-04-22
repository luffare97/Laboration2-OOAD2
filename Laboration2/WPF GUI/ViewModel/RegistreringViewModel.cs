using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BusinessEntites;
using BusinessLayer;

namespace WPF_GUI.ViewModel
{
    public class RegistreringViewModel : INotifyPropertyChanged
    {

        public BusinessManager BusinessManager { get; }
        public RegistreringViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;
            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            SparaCmd = new RelayCommand(Spara, param => this.canExecute);

        }
        public Action TillbakaAction { get; set; }


        public string Lösen2 { get; set; }

        private Alumn alumn = new Alumn();
        public Alumn Alumn
        {
            get { return alumn; }
            set
            {
                alumn = value;
                Changed();
            }
        }

        private bool canExecute = true;
        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }
            set
            {
                if (this.canExecute == value)
                {
                    return;
                }
                this.canExecute = value;
            }
        }

        private ICommand sparaCmd;
        public ICommand SparaCmd
        {
            get
            {
                return sparaCmd;
            }
            set
            {
                sparaCmd = value;
            }
        }

        private ICommand tillbakaCmd;
        public ICommand TillbakaCmd
        {
            get
            {
                return this.tillbakaCmd;
            }
            set
            {
                tillbakaCmd = value;
            }
        }


        private void Tillbaka(object obj)
        {
            TillbakaAction();
        }

        private bool godkännd;
        public bool Godkännd
        {
            get { return godkännd; }
            set
            {
                godkännd = value;
                Changed();
            }
        }

        private void Spara(object obj)
        {

            if (Alumn.Lösenord == Lösen2)
            {



                bool ID = int.TryParse(Alumn.AnvändarId.ToString(), out int id);
                bool OK = int.TryParse(Alumn.TeleNr.ToString(), out int tele);
                bool ÅR = int.TryParse(Alumn.ExamensÅr.ToString(), out int år);

                if (ÅR == true)
                {

                    if (OK == true)
                    {
                        if (ID == true)
                        {

                            string användarid = $"s{int.Parse(Alumn.AnvändarId.ToString())}";

                            Användare A = BusinessManager.GetAlumn(användarid);

                            if (A == null)
                            {
                                Alumn.AnvändarId = användarid;

                                if (Alumn.Program == null)
                                {
                                    MessageBox.Show("Du måste välja ett program", "Error");
                                }
                                else
                                {

                                    //Utbildning utbildning = (Utbildning)ProgramCB.SelectedItem;



                                    MessageBoxResult result = MessageBox.Show("Vill du spara den här användaren?", "Vill du spara detta?", MessageBoxButton.YesNo);
                                    if (result == MessageBoxResult.No)
                                    {
                                        TillbakaAction();
                                    }
                                    else if (result == MessageBoxResult.Yes)
                                    {

                                        GDPR gdpr = new GDPR(BusinessManager);
                                        gdpr.ShowDialog();

                                        if (BusinessManager.OK == true)
                                        {
                                            
                                            Spara();
                                            MessageBox.Show($"Användaren är sparad \n Ditt användar ID är: {användarid}", "Sparad");

                                            TillbakaAction();
                                        }
                                        else if (BusinessManager.OK == false)
                                        {
                                            MessageBox.Show("Du måste godkänna vilkåren för att få lov att skapa ett konto", "Error");
                                        }
                                    }

                                }

                            }
                            else if (A != null)
                            {
                                MessageBox.Show("AnvändarIDt används redan vänligen välj ett annat", "Error");
                            }
                        }
                        else if (ID == false)
                        {
                            MessageBox.Show("AnvändarIDt kan bara bestå av sifforor", "Error");
                        }

                    }
                    else if (OK == false)
                    {
                        MessageBox.Show("Telefonnummer kan bara bestå av siffror", "Error");
                    }

                }
                else
                {
                    MessageBox.Show("Examensår måste vara siffror", "Error");
                }

            }
            else
            {
                MessageBox.Show("Lösenorden stämmer inte överrens", "Error");
            }

        }


        public void Spara()
        {
            BusinessManager.CreateAlumn(alumn);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
