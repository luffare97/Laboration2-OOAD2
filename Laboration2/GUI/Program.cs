using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessEntites;
using BusinessLayer;


namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Återställer databasen
            AppDbContext DB = new AppDbContext();
            DB.Reset();

            BusinessManager BM = new BusinessManager(new UnitOfWork(DB));
            Alumn A = BM.GetAlumn("s1");
            Alumn B = BM.GetAlumn("s2");

            BM.DeltaAktivitet(1, A);
            BM.DeltaAktivitet(1, B);

            BM.AddMottagare(0, A);
            BM.AddMottagare(0, B);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoggIn(BM));
        }
    }
}
