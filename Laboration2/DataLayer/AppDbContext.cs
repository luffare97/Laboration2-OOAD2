﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
//using Microsoft.EntityFrameworkCore;

namespace DataLayer
{


    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<Alumn> Alumner { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Användare> Användares { get; set; }
        //public DbSet<Student> Studenter { get; set; }
        public virtual DbSet<UtskicksLista> UtskicksListor { get; set; }
        public virtual DbSet<Aktivitet> Aktiviteter { get; set; }

        //public DbSet<Program> Programs { get; set; }

        public AppDbContext() : base("osu2014")
        {

        }

        // Här är reset koden!

        // Place in your own instance of DbContext
        // Place in your own instance of DbContext
        public void Reset()
        {
            using (SqlConnection conn = new SqlConnection(Database.Connection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("DECLARE @SQL VARCHAR(MAX)='' SELECT @SQL = @SQL + 'ALTER TABLE ' + QUOTENAME(FK.TABLE_SCHEMA) + '.' + QUOTENAME(FK.TABLE_NAME) + ' DROP CONSTRAINT [' + RTRIM(C.CONSTRAINT_NAME) +'];' + CHAR(13) FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS C INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS FK ON C.CONSTRAINT_NAME = FK.CONSTRAINT_NAME INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS PK ON C.UNIQUE_CONSTRAINT_NAME = PK.CONSTRAINT_NAME INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE CU ON C.CONSTRAINT_NAME = CU.CONSTRAINT_NAME INNER JOIN (SELECT i1.TABLE_NAME, i2.COLUMN_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME WHERE i1.CONSTRAINT_TYPE = 'PRIMARY KEY') PT ON PT.TABLE_NAME = PK.TABLE_NAME EXEC (@SQL);EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'; EXEC sp_msforeachtable 'DROP TABLE ?'", conn))
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
                Anställning = "Arbetslös",
                ExamensÅr = 2022,
                Ort = "Borås",
                Program = Utbildning.Systemarkitekt
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
                Program = Utbildning.DataEkonom
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
                Program = Utbildning.Systemarkitekt
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
                Program = Utbildning.DataEkonom
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
                Program = Utbildning.Systemvetare
            });

            Aktiviteter.Add(new Aktivitet()
            {
                AktivitetNamn = "Seminarium om stolar",
                Datum = new DateTime(2020, 04, 08),
                Tid = "00:00 - 00:00",
                AntalPlatser = 5,
                Plats = "D433",
                Beskrivning = "Här ska ni få ett 24timmars seminarium där ni kommer lära er en massa om stolar och andra sittvänliga saker!"
            });

            ObservableCollection<Alumn> A = new ObservableCollection<Alumn>
            {
                Olof,
                Nisse
            };

            string B = "Lista med information om vilka elever som suger 5.Nisse 4.Klas 3.Lisa 2.Nisse igen 1.Roger";

            string C = "officiell tierlist";

            UtskicksLista L = new UtskicksLista(A)
            {
                
                Information = B,
                Titel = C
            };

            //foreach (Alumn alumn in A)
            //{
            //    L.Mottagare.Add(alumn);
            //}

            UtskicksListor.Add(L);


            //Olof.Listor.Add(L);
            //Nisse.Listor.Add(L);


            SaveChanges();

        }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
