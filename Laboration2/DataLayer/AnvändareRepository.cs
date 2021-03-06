﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class AnvändareRepository : GenericRepository<Användare>, IAnvändareRepository
    {
        public AnvändareRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        public AppDbContext AppDbContext
        {
            get { return Context as AppDbContext; }
        }

        private AppDbContext Context { get; }
        public List<Användare> användares { get; set; }



        public Användare GetAnvändare(string användarID)
        {

            return Context.Användares.Where(x => x.AnvändarId == användarID).FirstOrDefault();


        }

        public Användare LoggaIn(string ID, string Lösen)
        {

            Användare A = GetAnvändare(ID);
            if (A == null)
            {
                return null;
            }
            else
            {
                if (A.Lösenord != Lösen)
                {
                    return null;
                }
                else
                {
                    return A;
                }
            }


        }


        public void RedigeraLösenord(string ID, string nytt)
        {
            GetAnvändare(ID).Lösenord = nytt;

            Context.SaveChanges();

        }
    }
}
