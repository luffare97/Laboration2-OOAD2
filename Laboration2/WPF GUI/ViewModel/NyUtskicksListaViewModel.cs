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

    public class NyUtskicksListaViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }

        public NyUtskicksListaViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;
            FyllLB();

        }

        public void FyllLB()
        {
            ICollection<Alumn> A = BusinessManager.GetAllAlumn();

            foreach (Alumn a in A)
            {
                alumner.Add(a);
            }
        }


        private ObservableCollection<Alumn> alumner = new ObservableCollection<Alumn>();
        public ObservableCollection<Alumn> Alumner
        {
            get { return alumner; }
            set
            {
                alumner = value;
                Changed();
            }
        }


        private UtskicksLista lista = new UtskicksLista();
        public UtskicksLista Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                Changed();
            }
        }


        public void Spara()
        {
            
            BusinessManager.CreateList(Lista);
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
