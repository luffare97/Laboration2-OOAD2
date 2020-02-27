﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;


namespace DataLayer
{
    public class UtskicksListaRepository : GenericRepository<UtskicksLista>, IUtskicksListaRepository
    {

        private AppDbContext Context { get; }

        public UtskicksListaRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        public List<UtskicksLista> GetAllListor()
        {
            using (var db = new AppDbContext())
            {
                return db.UtskicksListor.ToList();
            }
        }

        public UtskicksLista GetLista(int id)
        {
            return (UtskicksLista)Context.UtskicksListor.Where(x => x.Id == id).FirstOrDefault();
        }

        public void CreateLista(string titel, string info, List<Alumn> mottagare)
        {
            UtskicksLista L = new UtskicksLista(info, titel);

            foreach (Alumn alumn in mottagare)
            {
                AddMottagare(L.Id, alumn);
            }
            
            Context.UtskicksListor.Add(L);

            Context.SaveChanges();
            
        }

        public void AddMottagare(int id, Alumn A)
        {

            var query =
                from lista in Context.UtskicksListor
                where lista.Id == id
                select lista;

            foreach (UtskicksLista lista in query)
            {
                lista.Användares.Add(A);
                A.Listor.Add(lista);
            }

            Context.SaveChanges();

        }

        public void RemoveMottagare(int ID, Alumn A)
        {
            var query =
                from lista in Context.UtskicksListor
                where lista.Id == ID
                select lista;

            foreach (UtskicksLista lista in query)
            {
                lista.Användares.Remove(A);
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
