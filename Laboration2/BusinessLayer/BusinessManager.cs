﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace BusinessLayer
{

    public class BusinessManager : IBusinessManager
    {

        public UnitOfWork UnitOfWork { get; set; }

        public BusinessManager()
        {
            UnitOfWork = new UnitOfWork(new AppDbContext());
        }

        public Personal InloggadPersonal { get; set; }
        public Alumn InloggadAlumn { get; set; }

        private bool ok;
        public bool OK
        {
            get { return ok; }
            set
            {
                ok = value;
                Changed();
            }
        }


        public List<Alumn> HämtaTillgängligaAlumner(UtskicksLista lista)
        {
            return UnitOfWork.UtskicksListaRepository.HämtaTillgängligaAlumner(lista);
        }

        public List<UtskicksLista> GetListorForAlumn(Alumn a)
        {
            return UnitOfWork.AlumnRepository.GetListorForAlumn(a);
        }






        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        //calling repos

        //AnvändarRepo
        public Användare GetAnvändare(string id)
        {
            return UnitOfWork.AnvändareRepository.GetAnvändare(id);
        }

        public Användare LoggaIn(string ID, string Lösen)
        {
            return UnitOfWork.AnvändareRepository.LoggaIn(ID, Lösen);
        }

        public void RedigeraLösenord(string ID, string nytt)
        {
            UnitOfWork.AnvändareRepository.RedigeraLösenord(ID, nytt);
        }



        //AktivitetRepo
        public List<Aktivitet> GetAllAktiviteter()
        {
            return UnitOfWork.AktivitetRepository.GetAll().ToList();
        }

        public List<Alumn> GetAlumnForAktivitet(Aktivitet aktivitet)
        {
            return UnitOfWork.AktivitetRepository.GetAlumnForAktivitet(aktivitet);
        }

        public void CreateAktivitet(Aktivitet A)
        {
            UnitOfWork.AktivitetRepository.CreateAktivitet(A);
        }

        public Aktivitet GetAktivitet(int ID)
        {
            return UnitOfWork.AktivitetRepository.GetAktivitet(ID);
        }

        //Kanske ska vara observer pattern?
        public void DeltaAktivitet(int ID, Alumn A)
        {
            UnitOfWork.AktivitetRepository.DeltaAktivitet(ID, A);
        }

        public void RedigeraAktivitet(int ID, Aktivitet A)
        {
            UnitOfWork.AktivitetRepository.RedigeraAktivitet(ID, A);
        }

        public void DeleteAktivitet(int id)
        {
            Aktivitet A = UnitOfWork.AktivitetRepository.GetAktivitet(id);
            UnitOfWork.AktivitetRepository.Remove(A);
        }



        //AlumnRepo
        public void RedigeraAlumn(Alumn A)
        {
            UnitOfWork.AlumnRepository.RedigeraAlumn(A);
        }

        public void CreateAlumn(Alumn A)
        {
            UnitOfWork.AlumnRepository.CreateAlumn(A);
        }

        public Alumn GetAlumn(string ID)
        {
            return UnitOfWork.AlumnRepository.GetAlumn(ID);
        }

        public List<Alumn> GetAllAlumn()
        {
            return UnitOfWork.AlumnRepository.GetAllAlumn();
        }

        public void DeleteAlumn(string id)
        {
            Alumn A = UnitOfWork.AlumnRepository.GetAlumn(id);
            UnitOfWork.AlumnRepository.Remove(A);
        }



        //PersonaRepo
        public void RedigeraPersonal(Personal P)
        {
            UnitOfWork.PersonalRepository.RedigeraPersonal(P);
        }

        public void DeletePersonal(string id)
        {
            Personal P = UnitOfWork.PersonalRepository.GetPersonal(id);
            UnitOfWork.PersonalRepository.Remove(P);
        }



        //ListRepo
        public List<UtskicksLista> GetAllListor()
        {
            return UnitOfWork.UtskicksListaRepository.GetAllListor();
        }

        public ObservableCollection<Alumn> GetAlumnForList(int id)
        {
            return UnitOfWork.UtskicksListaRepository.GetAlumnForList(id);
        }

        public UtskicksLista GetUtskicksLista(int ID)
        {
            return UnitOfWork.UtskicksListaRepository.GetLista(ID);
        }

        public void CreateList(UtskicksLista L)
        {
            UnitOfWork.UtskicksListaRepository.CreateLista(L);
        }

        //Får kolla på om vi implementerar
        public void AddMottagare(Alumn A, UtskicksLista L)
        {
            UnitOfWork.UtskicksListaRepository.AddMottagare(A, L);
        }

        public void RemoveMottagare(int ID, Alumn A)
        {
            UnitOfWork.UtskicksListaRepository.RemoveMottagare(ID, A);
        }

        //kolla formatering 
        public void RedigeraLista(int id, string titel, string info)
        {
            UnitOfWork.UtskicksListaRepository.RedigeraLista(id, titel, info);
        }

        public void DeleteLista(int id)
        {
            UtskicksLista L = UnitOfWork.UtskicksListaRepository.GetLista(id);
            UnitOfWork.UtskicksListaRepository.Remove(L);
        }





    }


}
