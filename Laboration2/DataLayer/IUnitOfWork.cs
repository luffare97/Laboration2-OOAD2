namespace DataLayer
{
    public interface IUnitOfWork
    {
        AktivitetRepository AktivitetRepository { get; set; }
        AlumnRepository AlumnRepository { get; set; }
        AnvändareRepository AnvändareRepository { get; set; }
        PersonalRepository PersonalRepository { get; set; }
        UtskicksListaRepository UtskicksListaRepository { get; set; }

        int Save();
    }
}