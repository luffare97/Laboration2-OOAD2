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
            Alumn Olof = new Alumn()
            {
                AnvändarId = "s1",
                EMail = "olof.pelle@hotmail.com",
                ENamn = "Pellesson",
                FNamn = "Olof",
                Lösenord = "LOL",
                TeleNr = 010555203,
                Anställning = "",
                ExamensÅr = 2022,
                Ort = "Borås",
                program = Utbildning.Systemarkitekt
            };
            Alumner.Add(Olof);


            Alumn Nisse = new Alumn()
            {
                AnvändarId = "s2",
                EMail = "SniffarNisse@HAHA.lol",
                FNamn = "Nisse",
                ENamn = "Sniffe",
                Lösenord = "LOL",
                TeleNr = 0708555324,
                Anställning = "Sniffare",
                ExamensÅr = 2005,
                Ort = "Göteborg",
                program = Utbildning.DataEkonom
            };
            Alumner.Add(Nisse);


            Alumner.Add(new Alumn()
            {
                AnvändarId = "s3",
                EMail = "Moa.Adolf@hotmail.com",
                ENamn = "Adolfsson",
                FNamn = "Moa",
                Lösenord = "LOL",
                TeleNr = 010002203,
                Anställning = "Codare",
                ExamensÅr = 2012,
                Ort = "Huddinge",
                program = Utbildning.Systemarkitekt
            });

            Alumner.Add(new Alumn()
            {
                AnvändarId = "s4",
                EMail = "Bosse.Bergman@hotmail.com",
                ENamn = "Bergman",
                FNamn = "Bosse",
                Lösenord = "LOL",
                TeleNr = 010002203,
                Anställning = "Bagare",
                ExamensÅr = 2008,
                Ort = "Frölunda",
                program = Utbildning.DataEkonom
            });

            Personals.Add(new Personal()
            {
                AnvändarId = "t5",
                EMail = "DummaElever@skolan.se",
                FNamn = "Lars-gunnar",
                ENamn = "Lärarsson",
                Lösenord = "LOL",
                TeleNr = 0100555666,
                Possition = "Föreläsare"
                
            });

            Personals.Add(new Personal()
            {
                AnvändarId = "t6",
                EMail = "LasseSuger@berg.sten",
                FNamn = "Sten-Stig",
                ENamn = "Bumling",
                Lösenord = "LOL",
                TeleNr = 5318008,
                Possition = "Professor"
                
            });

            Personals.Add(new Personal()
            {
                AnvändarId = "t7",
                EMail = "Smartare@an.dig",
                FNamn = "Leonard",
                ENamn = "McSmartis",
                Lösenord = "LOL",
                TeleNr = 12345678,
                Possition = "Programansvarig"

            });

            Alumner.Add(new Alumn()
            {
                AnvändarId = "s8",
                EMail = "BjörnarSuger@hmu.plz",
                FNamn = "Björn",
                ENamn = "Jägare",
                Lösenord = "LOL",
                TeleNr = 0708555324,
                Anställning = "Björn Jägare",
                ExamensÅr = 2005,
                Ort = "Mora",
                program = Utbildning.Systemvetare
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

            List<Användare> A = new List<Användare>();
            A.Add(Olof);
            A.Add(Nisse);

            string B = "Lista med information om vilka elever som suger";

            UtskicksListor.Add(new UtskicksLista(A, B));
                       
            
            SaveChanges();
            
        }

         
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
