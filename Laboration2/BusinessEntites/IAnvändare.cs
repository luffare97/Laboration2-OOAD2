using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusinessEntites
{
    public interface IAnvändare
    {
        string AnvändarId { get; set; }
        string EMail { get; set; }
        string ENamn { get; set; }
        string FNamn { get; set; }
        string Lösenord { get; set; }
        string TeleNr { get; set; }

        event PropertyChangedEventHandler PropertyChanged;

        void Changed([CallerMemberName] string propertyName = "");
    }
}