﻿using System;

namespace Models
{
    public class Narudzba : IIsDeleted
    {
        public Narudzba()
        {
            IsSkenirana = false;
        }

        public string Id { get; set; }

        //Kupac koji je izvrsio narudzbu
        public string KupacId { get; set; }
        public virtual Kupac Kupac { get; set; }

        //Termin za koji je korisnik kupio kartu
        public string TerminId { get; set; }
        public virtual Termin Termin { get; set; }

        public string TipSjedistaId { get; set; }
        public virtual TipSjedista TipSjedista { get; set; }

        //Cijena koju je kupac platio za kartu
        public double CijenaKarte { get; set; }
        //Broj karata koje je su kupljene
        public int Kolicina { get; set; }

        public bool IsSkenirana { get; set; }

        public DateTime DatumKupovine { get; set; }

        //Ocjena koju je kupac ostavio za predstavu
        public string OcjenaId { get; set; }
        public virtual Ocjena Ocjena { get; set; }

        //public bool isSkeniran { get; set; }

        public bool IsDeleted { get; set; }
    }
}
