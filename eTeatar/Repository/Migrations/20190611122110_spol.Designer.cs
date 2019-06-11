﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(eTeatarContext))]
    [Migration("20190611122110_spol")]
    partial class spol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Administrator", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KorisnickiNalogId");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("Models.Avatar", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Link");

                    b.HasKey("Id");

                    b.ToTable("Avatar");
                });

            modelBuilder.Entity("Models.Drzava", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("Models.Dvorana", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv");

                    b.Property<string>("TeatarId");

                    b.HasKey("Id");

                    b.HasIndex("TeatarId");

                    b.ToTable("Dvorana");
                });

            modelBuilder.Entity("Models.DvoranaTipSjedista", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojSjedista");

                    b.Property<string>("DvoranaId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("TipSjedistaId");

                    b.HasKey("Id");

                    b.HasIndex("DvoranaId");

                    b.HasIndex("TipSjedistaId");

                    b.ToTable("DvoranaTipSjedista");
                });

            modelBuilder.Entity("Models.Glumac", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Biografija");

                    b.Property<string>("Ime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Prezime");

                    b.Property<string>("SlikaLink");

                    b.Property<string>("SpolId");

                    b.HasKey("Id");

                    b.HasIndex("SpolId");

                    b.ToTable("Glumac");
                });

            modelBuilder.Entity("Models.Grad", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DrzavaId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("Models.Komentar", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumVrijeme");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("KupacId");

                    b.Property<string>("ObavijestId");

                    b.Property<string>("Sadrzaj");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("ObavijestId");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("Models.KorisnickaUloga", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("KorisnickaUloga");
                });

            modelBuilder.Entity("Models.KorisnickiNalog", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("AvatarId");

                    b.Property<DateTime>("DatumKreiranja");

                    b.Property<string>("Email");

                    b.Property<string>("GradId");

                    b.Property<string>("Ime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("KorisnickaUlogaId");

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("LozinkaHash");

                    b.Property<string>("LozinkaSalt");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.HasIndex("GradId");

                    b.HasIndex("KorisnickaUlogaId");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("Models.Kupac", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KorisnickiNalogId");

                    b.Property<string>("TipKorisnikaId");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("TipKorisnikaId");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("Models.Narudzba", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CijenaKarte");

                    b.Property<DateTime>("DatumKupovine");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Kolicina");

                    b.Property<string>("KupacId");

                    b.Property<string>("OcjenaId");

                    b.Property<string>("TerminId");

                    b.Property<string>("TipSjedistaId");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("TerminId");

                    b.HasIndex("TipSjedistaId");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("Models.Obavijest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdministratorId");

                    b.Property<DateTime>("DatumVrijeme");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naslov");

                    b.Property<string>("Sadrzaj");

                    b.Property<string>("SlikaLink");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("Models.Ocjena", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("NarudzbaId");

                    b.Property<string>("Review");

                    b.Property<int>("Vrijednost");

                    b.HasKey("Id");

                    b.HasIndex("NarudzbaId")
                        .IsUnique()
                        .HasFilter("[NarudzbaId] IS NOT NULL");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("Models.Predstava", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv");

                    b.Property<string>("NazivIzvornogDjela");

                    b.Property<string>("Opis");

                    b.Property<string>("ReziserImePrezime");

                    b.Property<string>("SlikaLink");

                    b.Property<string>("Trajanje");

                    b.HasKey("Id");

                    b.ToTable("Predstava");
                });

            modelBuilder.Entity("Models.PredstavaZanr", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PredstavaId");

                    b.Property<string>("ZanrId");

                    b.HasKey("Id");

                    b.HasIndex("PredstavaId");

                    b.HasIndex("ZanrId");

                    b.ToTable("PredstavaZanr");
                });

            modelBuilder.Entity("Models.Spol", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Spol");
                });

            modelBuilder.Entity("Models.Teatar", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("BrojTelefona");

                    b.Property<string>("Email");

                    b.Property<string>("GradId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv");

                    b.Property<DateTime>("VrijemeOtvaranja");

                    b.Property<DateTime>("VrijemeZatvaranja");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Teatar");
                });

            modelBuilder.Entity("Models.Termin", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaznaCijenaKarte");

                    b.Property<DateTime>("DatumVrijeme");

                    b.Property<string>("DvoranaId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PredstavaId");

                    b.HasKey("Id");

                    b.HasIndex("DvoranaId");

                    b.HasIndex("PredstavaId");

                    b.ToTable("Termin");
                });

            modelBuilder.Entity("Models.TipKorisnika", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cijena");

                    b.Property<double>("CijenaKartePopust");

                    b.Property<string>("IduciTipKorisnikaId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsOsnovni");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.HasIndex("IduciTipKorisnikaId");

                    b.ToTable("TipKorisnika");
                });

            modelBuilder.Entity("Models.TipSjedista", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CijenaKarteMultiplier");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("TipSjedista");
                });

            modelBuilder.Entity("Models.Uloga", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GlumacId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsGlavnaUloga");

                    b.Property<string>("Naziv");

                    b.Property<string>("PredstavaId");

                    b.HasKey("Id");

                    b.HasIndex("GlumacId");

                    b.HasIndex("PredstavaId");

                    b.ToTable("Uloga");
                });

            modelBuilder.Entity("Models.Zanr", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Zanr");
                });

            modelBuilder.Entity("Models.Administrator", b =>
                {
                    b.HasOne("Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Dvorana", b =>
                {
                    b.HasOne("Models.Teatar", "Teatar")
                        .WithMany("Dvorane")
                        .HasForeignKey("TeatarId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.DvoranaTipSjedista", b =>
                {
                    b.HasOne("Models.Dvorana", "Dvorana")
                        .WithMany("TipoviSjedista")
                        .HasForeignKey("DvoranaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.TipSjedista", "TipSjedista")
                        .WithMany("Dvorane")
                        .HasForeignKey("TipSjedistaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Glumac", b =>
                {
                    b.HasOne("Models.Spol", "Spol")
                        .WithMany()
                        .HasForeignKey("SpolId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Grad", b =>
                {
                    b.HasOne("Models.Drzava", "Drzava")
                        .WithMany("Gradovi")
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Komentar", b =>
                {
                    b.HasOne("Models.Kupac", "Kupac")
                        .WithMany("Komentari")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.Obavijest", "Obavijest")
                        .WithMany("Komentari")
                        .HasForeignKey("ObavijestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.KorisnickiNalog", b =>
                {
                    b.HasOne("Models.Avatar", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.Grad", "Grad")
                        .WithMany("Korisnici")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.KorisnickaUloga", "KorisnickaUloga")
                        .WithMany()
                        .HasForeignKey("KorisnickaUlogaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Kupac", b =>
                {
                    b.HasOne("Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.TipKorisnika", "TipKorisnika")
                        .WithMany()
                        .HasForeignKey("TipKorisnikaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Narudzba", b =>
                {
                    b.HasOne("Models.Kupac", "Kupac")
                        .WithMany("Narudzbe")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.Termin", "Termin")
                        .WithMany("Narudzbe")
                        .HasForeignKey("TerminId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.TipSjedista", "TipSjedista")
                        .WithMany()
                        .HasForeignKey("TipSjedistaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Obavijest", b =>
                {
                    b.HasOne("Models.Administrator", "Administrator")
                        .WithMany("Obavijesti")
                        .HasForeignKey("AdministratorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Ocjena", b =>
                {
                    b.HasOne("Models.Narudzba", "Narudzba")
                        .WithOne("Ocjena")
                        .HasForeignKey("Models.Ocjena", "NarudzbaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.PredstavaZanr", b =>
                {
                    b.HasOne("Models.Predstava", "Predstava")
                        .WithMany("Zanrovi")
                        .HasForeignKey("PredstavaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.Zanr", "Zanr")
                        .WithMany("Predstave")
                        .HasForeignKey("ZanrId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Teatar", b =>
                {
                    b.HasOne("Models.Grad", "Grad")
                        .WithMany("Teatri")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Termin", b =>
                {
                    b.HasOne("Models.Dvorana", "Dvorana")
                        .WithMany("Termini")
                        .HasForeignKey("DvoranaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.Predstava", "Predstava")
                        .WithMany("Termini")
                        .HasForeignKey("PredstavaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.TipKorisnika", b =>
                {
                    b.HasOne("Models.TipKorisnika", "IduciTipKorisnika")
                        .WithMany()
                        .HasForeignKey("IduciTipKorisnikaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.Uloga", b =>
                {
                    b.HasOne("Models.Glumac", "Glumac")
                        .WithMany("Uloge")
                        .HasForeignKey("GlumacId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.Predstava", "Predstava")
                        .WithMany("Uloge")
                        .HasForeignKey("PredstavaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
