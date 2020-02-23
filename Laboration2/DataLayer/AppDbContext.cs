using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using System.Data.Entity;
using System.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
   

    public class AppDbContext : DbContext
    {
        public DbSet<Alumn> Alumner { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Användare> Användares { get; set; }
        public DbSet<Student> Studenter { get; set; }
        public virtual DbSet<UtskicksLista> UtskicksListor { get; set; }
        public DbSet<Aktivitet> Aktiviteter { get; set; }

        //public DbSet<Program> Programs { get; set; }

        public AppDbContext() : base("osu2014")
        {
            
        }

        // Här är reset koden!

        // Place in your own instance of DbContext
        public void Reset()
        {
            using (SqlConnection conn = new SqlConnection(Database.Connection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'; EXEC sp_msforeachtable 'DROP TABLE ?'", conn))
            {
                conn.Open();
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Exception)
                    {
                        // throw;
                    }
                }
                conn.Close();
            }
            Database.Initialize(true);

            Seed();
        }
        public void Seed()
        {

            
            Studenter.Add(new Student()
            {
                AnvändarId = "s10",
                EMail = "Moa.Adolf@hotmail.com",
                ENamn = "Moa",
                FNamn = "Adolfsson",
                Lösenord = "LOL",
                TeleNr = 010002203,
                program = Program.Systemarkitekt
            });

            Studenter.Add(new Student()
            {
                AnvändarId = "s11",
                EMail = "Bosse.Bergman@hotmail.com",
                ENamn = "Bergman",
                FNamn = "Bosse",
                Lösenord = "LOL",
                TeleNr = 010002203,
                program = Program.DataEkonom
            });

            Personals.Add(new Personal()
            {
                AnvändarId = "t15",
                EMail = "DummaElever@skolan.se",
                FNamn = "Lars-gunnar",
                ENamn = "Lärarsson",
                Lösenord = "LOL",
                TeleNr = 0100555666,
                Id = 1,
                Possition = "Chef"
                
            });

            Alumner.Add(new Alumn()
            {
                AnvändarId = "s12",
                EMail = "BjörnarSuger@hmu.plz",
                FNamn = "Björn",
                ENamn = "Jägare",
                Lösenord = "LOL",
                TeleNr = 0708555324,
                Anställning = "Björn Jägare",
                ExamensÅr = 2005,
                Ort = "Mora",
                program = Program.Systemvetare
            });

            Aktiviteter.Add(new Aktivitet()
            {
                AktivitetNamn = "Seminarium om stolar",
                Start = new DateTime(2020, 04, 08),
                Slut = new DateTime(2020, 04, 09),
                AntalPlatser = 50,
                Plats = "D433",
                Beskrivning = "Här ska ni få ett 24timmars seminarium där ni kommer lära er en massa om stolar och andra sittvänliga saker!"
            });
                       
            
            SaveChanges();
            
        }

         
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
