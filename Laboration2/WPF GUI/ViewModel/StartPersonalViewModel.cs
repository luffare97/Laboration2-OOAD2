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
using static System.Net.Mime.MediaTypeNames;

namespace WPF_GUI.ViewModel
{
    public class StartPersonalViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }



        public StartPersonalViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

            personal = BusinessManager.InloggadPersonal;

            

            FyllGrids();

            
        }

        public void FyllGrids()
        {
            ICollection<UtskicksLista> L = BusinessManager.GetAllListor();

            foreach (UtskicksLista l in L)
            {
                listor.Add(l);
            }

            ICollection<Aktivitet> A = BusinessManager.GetAllAktiviteter();

            foreach (Aktivitet a in A)
            {
                aktiviteter.Add(a);
            }
        }


        private Personal personal = new Personal();

        public Personal Personal
        {
            get { return personal; }
            set
            {
                personal = value;

            }
        }

        private ObservableCollection<UtskicksLista> listor = new ObservableCollection<UtskicksLista>();
        public ObservableCollection<UtskicksLista> Listor
        {
            get { return listor; }
            set
            {
                listor = value;
                Changed();
            }
        }


        private ObservableCollection<Aktivitet> aktiviteter = new ObservableCollection<Aktivitet>();
        public ObservableCollection<Aktivitet> Aktiviteter
        {
            get { return aktiviteter; }
            set
            {
                aktiviteter = value;
                Changed();
            }
        }





        //public void FillGrids()
        //{

        //}

        //public void Update()
        //{
        //    FillGrids();
        //}


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }


    
}
