namespace BusinessEntites
{
    public interface IPersonal
    {
        string Possition { get; set; }

        Aktivitet skapaAktivitet();
    }
}