﻿using System;

namespace DataTransferObjects
{
    public class Korisnik
    {
        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public virtual string AvatarId { get; set; }

        public string Adresa { get; set; }
        public string GradId { get; set; }

        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public DateTime DatumKreiranja { get; set; }
    }
}
