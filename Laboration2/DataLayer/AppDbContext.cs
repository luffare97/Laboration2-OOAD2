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

        public AppDbContext() : base("osu2014")
        {
            
        }
            // Dendär som vi inte vet om vi ska ha
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("data source=(localdb)\\mssqllocaldb;Initial Catalog=oosu2lab2;user id=;password=;");
        //    base.OnConfiguring(optionsBuilder);
        //}

            // Här är reset koden!

        // Place in your own instance of DbContext
        //public void Reset()
        //{
        //    using (SqlConnection conn = new SqlConnection(Database.Connection.ConnectionString))
        //    using (SqlCommand cmd = new SqlCommand("EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'; EXEC sp_msforeachtable 'DROP TABLE ?'", conn))
        //    {
        //        conn.Open();
        //        for (int i = 0; i < 5; i++)
        //        {
        //            try
        //            {
        //                cmd.ExecuteNonQuery();
        //            }
        //            catch (System.Exception)
        //            {
        //                // throw;
        //            }
        //        }
        //        conn.Close();
        //    }
        //    Database.Initialize(true);
        //}


        public virtual DbSet<Alumn> Alumner { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Användare> Användares { get; set; }
        public virtual DbSet<Entity> Entiteter { get; set; }
        public virtual DbSet<Student> Studenter { get; set; }
        public virtual DbSet<UtskicksLista> UtskicksListor { get; set; }
        public virtual DbSet<Aktivitet> Aktiviteter { get; set; }
        public virtual DbSet<Program> Programs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
