using System;
using System.Collections.Generic;
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

            //Update();
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
