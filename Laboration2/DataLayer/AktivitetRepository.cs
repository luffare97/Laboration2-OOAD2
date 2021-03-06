﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace DataLayer
{
    public class AktivitetRepository : GenericRepository<Aktivitet>, IAktivitetRepository
    {
        public AktivitetRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }


        public List<Alumn> GetAlumnForAktivitet(Aktivitet aktivitet)
        {

            using (var db = new AppDbContext())
            {

                //var alumner = db.Alumner
                //                .Include(a => a.Aktiviteter == aktivitet.Id)

                var alumn = db.Alumner.Where(a => a.Aktiviteter.Any(mm => mm.Id == aktivitet.Id));
                return alumn.ToList();
            }

            //ObservableCollection<Alumn> alumner = new ObservableCollection<Alumn>();

            //var query =
            //    from aktivitet in Context.Aktiviteter
            //    where aktivitet.Id == id
            //    select aktivitet;

            //foreach (Aktivitet aktivitet in query)
            //{
            //    foreach (Alumn a in aktivitet.Deltagare)
            //    {
            //        alumner.Add(a);
            //    }
            //}

            //return alumner;
        }

        //public List<Alumn> HämtaTillgängligaAlumner(Aktivitet aktivitet)
        //{
        //    using (var db = new AppDbContext())
        //    {
        //        var alumn = db.Alumner.Where(a => a.Listor.Any(mm => mm.Id == aktivitet.Id));
        //        return alumn.ToList();
        //    }
        //}

        public List<Aktivitet> GetAllAktiviteter()
        {
            using (var db = new AppDbContext())
            {
                return db.Aktiviteter.ToList();
            }
        }

        public void CreateAktivitet(Aktivitet A)
        {

            Context.Aktiviteter.Add(A);
            Context.SaveChanges();
        }

        public Aktivitet GetAktivitet(int ID)
        {
            return (Aktivitet)Context.Aktiviteter.Where(x => x.Id == ID).FirstOrDefault();
        }

        public void DeltaAktivitet(int ID, Alumn A)
        {
            var query =
                from aktivitet in Context.Aktiviteter
                where aktivitet.Id == ID
                select aktivitet;

            foreach (Aktivitet aktivitet in query)
            {
                aktivitet.Deltagare.Add(A);

                var query2 =
                    from alumn in Context.Alumner
                    where alumn.AnvändarId == A.AnvändarId
                    select alumn;

                foreach (Alumn alumn in query2)
                {
                    alumn.Aktiviteter.Add(aktivitet);
                }


            }

            Context.SaveChanges();

        }

        //Redigera aktivitet verkar inte funka?
        public void RedigeraAktivitet(int ID, Aktivitet A)
        {
            var query =
                from aktivitet in Context.Aktiviteter
                where aktivitet.Id == ID
                select aktivitet;

            foreach (Aktivitet aktivitet in query)
            {
                aktivitet.AktivitetNamn = A.AktivitetNamn;
                aktivitet.AntalPlatser = A.AntalPlatser;
                aktivitet.Datum = A.Datum;
                aktivitet.Tid = A.Tid;
                aktivitet.Plats = A.Plats;
                aktivitet.Beskrivning = A.Beskrivning;

            }

            Context.SaveChanges();
        }

    }
}
