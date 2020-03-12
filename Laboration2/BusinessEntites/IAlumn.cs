using System.Collections.Generic;

namespace BusinessEntites
{
    public interface IAlumn : IAnvändare
    {
        ICollection<Aktivitet> Aktiviteter { get; set; }
        string Anställning { get; set; }
        int ExamensÅr { get; set; }
        ICollection<UtskicksLista> Listor { get; set; }
        string Ort { get; set; }
        Utbildning program { get; set; }

        string ToString();
    }
}