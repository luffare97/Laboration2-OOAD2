using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusinessEntites
{
    public interface IAlumn
    {
        ObservableCollection<Aktivitet> Aktiviteter { get; set; }
        string Anställning { get; set; }
        int ExamensÅr { get; set; }
        ObservableCollection<UtskicksLista> Listor { get; set; }
        string Ort { get; set; }
        Utbildning Program { get; set; }

        event PropertyChangedEventHandler PropertyChanged;

        void Changed([CallerMemberName] string propertyName = "");
        string ToString();
    }
}