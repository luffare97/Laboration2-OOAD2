using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BusinessEntites
{
    public interface IUtskicksLista
    {
        ObservableCollection<Alumn> Mottagare { get; set; }
        string Information { get; set; }
        string Titel { get; set; }


    }
}