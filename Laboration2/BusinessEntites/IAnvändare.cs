namespace BusinessEntites
{
    public interface IAnvändare
    {
        string AnvändarId { get; set; }
        string EMail { get; set; }
        string ENamn { get; set; }
        string FNamn { get; set; }
        string Lösenord { get; set; }
        int TeleNr { get; set; }
    }
}