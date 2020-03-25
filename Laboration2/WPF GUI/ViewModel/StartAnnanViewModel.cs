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


        public BusinessManager BusinessManager { get; }
        public StartAnnanViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

            alumn = BusinessManager.InloggadAlumn;
           
            UpdateGrids();
            
        }

        public void UpdateGrids()
        {
            foreach (UtskicksLista u in Alumn.Listor)
            {
                UtskicksLista l = BusinessManager.GetUtskicksLista(u.Id);
                listor.Add(l);
            
            }
            foreach (Aktivitet a in BusinessManager.GetAllAktiviteter())
            {
                aktiviteter.Add(a);

            }

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


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
