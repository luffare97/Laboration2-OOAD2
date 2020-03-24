using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using BusinessLayer;

namespace WPF_GUI.ViewModel
{
    
    public class StartAnnanViewModel : INotifyPropertyChanged
    {
        public void UpdateGrids()
        {

            //ICollection<UtskicksLista> L = BusinessManager.InloggadAlumn.Listor;
            //foreach (UtskicksLista l in L)
            //{
            //    listor.Add(l);
            //}

            //ICollection<Aktivitet> A = BusinessManager.InloggadAlumn.Aktiviteter;
            //foreach (Aktivitet a in A)
            //{
            //    aktiviteter.Add(a);
            //}
        }

        public BusinessManager BusinessManager { get; }
        public StartAnnanViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

            alumn = BusinessManager.InloggadAlumn;
           
            UpdateGrids();
            

        }


        private Alumn alumn = new Alumn();

        public Alumn Alumn
        {
            get { return alumn; }
            set
            {
                alumn = value;

            }
        }

        private ObservableCollection<Aktivitet> aktiviteter;
        public ObservableCollection<Aktivitet> Aktiviteter
        {
            get { return aktiviteter; }
            set
            {
                aktiviteter = value;
                Changed();
            }
        }


        private ObservableCollection<UtskicksLista> listor;
        public ObservableCollection<UtskicksLista> Listor
        {
            get { return listor; }
            set
            {
                listor = value;
                Changed();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
