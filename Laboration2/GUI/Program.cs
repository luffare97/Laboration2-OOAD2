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
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoggIn(BM));
        }
    }
}
