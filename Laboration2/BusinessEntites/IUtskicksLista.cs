using System.Collections.Generic;

namespace BusinessEntites
{
    public interface IUtskicksLista
    {
        ICollection<Alumn> Mottagare { get; set; }
        string Information { get; set; }
        string Titel { get; set; }
    }
}