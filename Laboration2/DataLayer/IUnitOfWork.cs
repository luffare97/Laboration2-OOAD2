namespace DataLayer
{
    public interface IUnitOfWork
    {
        IAktivitetRepository AktivitetRepository { get; set; }
        IAlumnRepository AlumnRepository { get; set; }
        IAnvändareRepository AnvändareRepository { get; set; }
        IPersonalRepository PersonalRepository { get; set; }
        IUtskicksListaRepository UtskicksListaRepository { get; set; }

        int Save();
    }
}