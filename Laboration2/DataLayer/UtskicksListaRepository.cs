﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;
using System.Collections.ObjectModel;

namespace DataLayer
{
    public class UtskicksListaRepository : GenericRepository<UtskicksLista>, IUtskicksListaRepository
    {

        public UtskicksListaRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        // SAKER
        public List<Alumn> HämtaTillgängligaAlumner(UtskicksLista lista)
        {
            using (var db = new AppDbContext())
            {
                var alumn = db.Alumner.Where(a => a.Listor.Any(mm => mm.Id == lista.Id));
                return alumn.ToList();
            }
        }


        /// <summary>
      
        /// </summary>

        private AppDbContext Context { get; }

        public List<UtskicksLista> GetAllListor()
        {
            using (var db = new AppDbContext())
            {
                return db.UtskicksListor.ToList();
            }
        }

        public ObservableCollection<Alumn> GetAlumnForList(int id)
        {
            ObservableCollection<Alumn> alumner = new ObservableCollection<Alumn>();

            var query =
                from lista in Context.UtskicksListor
                where lista.Id == id
                select lista;

            foreach (UtskicksLista lista in query)
            {
                foreach (Alumn a in lista.Mottagare)
                {
                    alumner.Add(a);
                }
            }

            return alumner;
        }


        public UtskicksLista GetLista(int id)
        {
            return (UtskicksLista)Context.UtskicksListor.Where(x => x.Id == id).FirstOrDefault();
        }

        public void CreateLista(UtskicksLista L)
        {

            Context.UtskicksListor.Add(L);


            //foreach (Alumn A in L.Mottagare)
            //{
            //    A.Listor.Add(L);
            //    //AddMottagare(A, L);
            //}

            //foreach (Alumn alumn in L.Användares)
            //{
            //    AddMottagare(L.Id, alumn);
            //}

            //Context.UtskicksListor.Add(L);

            Context.SaveChanges();

        }

        public void AddMottagare(Alumn A, UtskicksLista L)
        {

            var query =
                from lista in Context.UtskicksListor
                where lista.Id == L.Id
                select lista;

            foreach (UtskicksLista lista in query)
            {
                A.Listor.Add(lista);

                //var query2 =
                //    from alumn in Context.Alumner
                //    where alumn.AnvändarId == A.AnvändarId
                //    select alumn;

                //foreach (Alumn alumn in query2)
                //{
                //    alumn.Listor.Add(lista);
                //}

            }

            Context.SaveChanges();


            //A.Listor.Add(L);
            //L.Mottagare.Add(A);

            //var query =
            //    from lista in Context.UtskicksListor
            //    where lista.Id == id
            //    select lista;

            //foreach (UtskicksLista lista in query)
            //{
            //    //lista.Användares.Add(A);
            //    A.Listor.Add(lista);
            //}

            //Context.SaveChanges();

        }

        public void RemoveMottagare(int ID, Alumn A)
        {
            var query =
                from lista in Context.UtskicksListor
                where lista.Id == ID
                select lista;

            foreach (UtskicksLista lista in query)
            {
                lista.Mottagare.Remove(A);
                A.Listor.Remove(lista);
            }

            Context.SaveChanges();
        }

        public void RedigeraLista(int id, string titel, string info)
        {

            var query =
                from lista in Context.UtskicksListor
                where lista.Id == id
                select lista;

            foreach (UtskicksLista lista in query)
            {
                lista.Titel = titel;
                lista.Information = info;

            }

            Context.SaveChanges();

        }



    }
}
