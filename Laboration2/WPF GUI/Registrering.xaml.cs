using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessEntites;
using BusinessLayer;
using WPF_GUI.ViewModel;

namespace WPF_GUI
{
    /// <summary>
    /// Interaction logic for Registrering.xaml
    /// </summary>
    public partial class Registrering : Window
    {
        public BusinessManager BusinessManager { get; }
        public RegistreringViewModel vm { get; set; }
        public Registrering(BusinessManager businessManager)
        {
            InitializeComponent();            
            BusinessManager = businessManager;
            vm = new RegistreringViewModel(BusinessManager);
            this.DataContext = vm;

            if (vm.TillbakaAction == null)
                vm.TillbakaAction = new Action(this.Close);

            ProgramCB.ItemsSource = Enum.GetValues(typeof(Utbildning)).Cast<Utbildning>();
        }

    //    private void Tillbaka(object sender, RoutedEventArgs e)
    //    {
    //        this.Close();

    //    }

    //    private void Spara(object sender, RoutedEventArgs e)
    //    {

    //        if (Lösen1.Password == Lösen2.Password)
    //        {

    //            vm.Alumn.Lösenord = Lösen1.Password;

    //            bool ID = int.TryParse(AnvändarIdTxt.Text.ToString(), out int id);
    //            bool OK = int.TryParse(TeleNrTxt.Text.ToString(), out int tele);
    //            bool ÅR = int.TryParse(ÅrTxt.Text.ToString(), out int år);

    //            if (ÅR == true)
    //            {

    //                if (OK == true)
    //                {
    //                    if (ID == true)
    //                    {

    //                        string användarid = $"s{int.Parse(AnvändarIdTxt.Text.ToString())}";

    //                        Användare A = BusinessManager.GetAlumn(användarid);

    //                        if (A == null)
    //                        {

    //                            if (ProgramCB.SelectedItem == null)
    //                            {
    //                                MessageBox.Show("Du måste välja ett program","Error");
    //                            }
    //                            else
    //                            {

    //                                Utbildning utbildning = (Utbildning)ProgramCB.SelectedItem;



    //                                MessageBoxResult result = MessageBox.Show("Vill du spara den här användaren?", "Vill du spara detta?", MessageBoxButton.YesNo);
    //                                if (result == MessageBoxResult.No)
    //                                {
    //                                    Close();
    //                                }
    //                                else if (result == MessageBoxResult.Yes)
    //                                {

    //                                    GDPR gdpr = new GDPR(BusinessManager);
    //                                    gdpr.ShowDialog();

    //                                    if (gdpr.DialogResult == true)
    //                                    {
    //                                        MessageBox.Show($"{vm.Alumn.FNamn}","test");
    //                                        vm.Spara();
    //                                        MessageBox.Show($"Användaren är sparad \n Ditt användar ID är: {användarid}", "Sparad");

    //                                        Close();
    //                                    }
    //                                    else if (gdpr.DialogResult == false)
    //                                    {
    //                                        MessageBox.Show("Du måste godkänna vilkåren för att få lov att skapa ett konto", "Error");
    //                                    }
    //                                }
                               

    //                            }

    //                        }
    //                        else if (A != null)
    //                        {
    //                            MessageBox.Show("AnvändarIDt används redan vänligen välj ett annat", "Error");
    //                        }
    //                    }
    //                    else if (ID == false)
    //                    {
    //                        MessageBox.Show("AnvändarIDt kan bara bestå av sifforor", "Error");
    //                    }

    //                }
    //                else if (OK == false)
    //                {
    //                    MessageBox.Show("Telefonnummer kan bara bestå av siffror", "Error");
    //                }

    //            }
    //            else
    //            {
    //                MessageBox.Show("Examensår måste vara siffror", "Error");
    //            }

    //        }
    //        else
    //        {
    //            MessageBox.Show("Lösenorden stämmer inte överrens", "Error");
    //        }

    //    }

    }
}
