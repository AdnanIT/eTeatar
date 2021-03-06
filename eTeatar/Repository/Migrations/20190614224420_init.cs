﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickaUloga",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickaUloga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Predstava",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Trajanje = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    ReziserImePrezime = table.Column<string>(nullable: true),
                    NazivIzvornogDjela = table.Column<string>(nullable: true),
                    PisacIzvornogDjela = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predstava", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipKorisnika",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<int>(nullable: false),
                    CijenaKartePopust = table.Column<double>(nullable: false),
                    IduciTipKorisnikaId = table.Column<string>(nullable: true),
                    IsOsnovni = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipKorisnika", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipKorisnika_TipKorisnika_IduciTipKorisnikaId",
                        column: x => x.IduciTipKorisnikaId,
                        principalTable: "TipKorisnika",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipSjedista",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    CijenaKarteMultiplier = table.Column<double>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipSjedista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zanr",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Glumac",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Biografija = table.Column<string>(nullable: true),
                    SpolId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glumac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Glumac_Spol_SpolId",
                        column: x => x.SpolId,
                        principalTable: "Spol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PredstavaZanr",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PredstavaId = table.Column<string>(nullable: true),
                    ZanrId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredstavaZanr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PredstavaZanr_Predstava_PredstavaId",
                        column: x => x.PredstavaId,
                        principalTable: "Predstava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PredstavaZanr_Zanr_ZanrId",
                        column: x => x.ZanrId,
                        principalTable: "Zanr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickiNalog",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    KorisnickaUlogaId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    DatumKreiranja = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    GradId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KorisnickiNalog_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KorisnickiNalog_KorisnickaUloga_KorisnickaUlogaId",
                        column: x => x.KorisnickaUlogaId,
                        principalTable: "KorisnickaUloga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teatar",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    VrijemeOtvaranja = table.Column<DateTime>(nullable: false),
                    VrijemeZatvaranja = table.Column<DateTime>(nullable: false),
                    GradId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teatar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teatar_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    IsGlavnaUloga = table.Column<bool>(nullable: false),
                    PredstavaId = table.Column<string>(nullable: true),
                    GlumacId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uloga_Glumac_GlumacId",
                        column: x => x.GlumacId,
                        principalTable: "Glumac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uloga_Predstava_PredstavaId",
                        column: x => x.PredstavaId,
                        principalTable: "Predstava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    KorisnickiNalogId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrator_KorisnickiNalog_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "KorisnickiNalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kupac",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    KorisnickiNalogId = table.Column<string>(nullable: true),
                    TipKorisnikaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kupac_KorisnickiNalog_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "KorisnickiNalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kupac_TipKorisnika_TipKorisnikaId",
                        column: x => x.TipKorisnikaId,
                        principalTable: "TipKorisnika",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dvorana",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    TeatarId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dvorana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dvorana_Teatar_TeatarId",
                        column: x => x.TeatarId,
                        principalTable: "Teatar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naslov = table.Column<string>(nullable: true),
                    DatumVrijeme = table.Column<DateTime>(nullable: false),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    AdministratorId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obavijest_Administrator_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administrator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DvoranaTipSjedista",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DvoranaId = table.Column<string>(nullable: true),
                    TipSjedistaId = table.Column<string>(nullable: true),
                    BrojSjedista = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DvoranaTipSjedista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DvoranaTipSjedista_Dvorana_DvoranaId",
                        column: x => x.DvoranaId,
                        principalTable: "Dvorana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DvoranaTipSjedista_TipSjedista_TipSjedistaId",
                        column: x => x.TipSjedistaId,
                        principalTable: "TipSjedista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DatumVrijeme = table.Column<DateTime>(nullable: false),
                    PredstavaId = table.Column<string>(nullable: true),
                    DvoranaId = table.Column<string>(nullable: true),
                    BaznaCijenaKarte = table.Column<double>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Termin_Dvorana_DvoranaId",
                        column: x => x.DvoranaId,
                        principalTable: "Dvorana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Termin_Predstava_PredstavaId",
                        column: x => x.PredstavaId,
                        principalTable: "Predstava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DatumVrijeme = table.Column<DateTime>(nullable: false),
                    Sadrzaj = table.Column<string>(nullable: true),
                    KupacId = table.Column<string>(nullable: true),
                    ObavijestId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentar_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komentar_Obavijest_ObavijestId",
                        column: x => x.ObavijestId,
                        principalTable: "Obavijest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    KupacId = table.Column<string>(nullable: true),
                    TerminId = table.Column<string>(nullable: true),
                    TipSjedistaId = table.Column<string>(nullable: true),
                    CijenaKarte = table.Column<double>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false),
                    DatumKupovine = table.Column<DateTime>(nullable: false),
                    OcjenaId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Narudzba_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Narudzba_Termin_TerminId",
                        column: x => x.TerminId,
                        principalTable: "Termin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Narudzba_TipSjedista_TipSjedistaId",
                        column: x => x.TipSjedistaId,
                        principalTable: "TipSjedista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Vrijednost = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    NarudzbaId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocjena_Narudzba_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_KorisnickiNalogId",
                table: "Administrator",
                column: "KorisnickiNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Dvorana_TeatarId",
                table: "Dvorana",
                column: "TeatarId");

            migrationBuilder.CreateIndex(
                name: "IX_DvoranaTipSjedista_DvoranaId",
                table: "DvoranaTipSjedista",
                column: "DvoranaId");

            migrationBuilder.CreateIndex(
                name: "IX_DvoranaTipSjedista_TipSjedistaId",
                table: "DvoranaTipSjedista",
                column: "TipSjedistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Glumac_SpolId",
                table: "Glumac",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_KupacId",
                table: "Komentar",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_ObavijestId",
                table: "Komentar",
                column: "ObavijestId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnickiNalog_GradId",
                table: "KorisnickiNalog",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnickiNalog_KorisnickaUlogaId",
                table: "KorisnickiNalog",
                column: "KorisnickaUlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_KorisnickiNalogId",
                table: "Kupac",
                column: "KorisnickiNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_TipKorisnikaId",
                table: "Kupac",
                column: "TipKorisnikaId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KupacId",
                table: "Narudzba",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_TerminId",
                table: "Narudzba",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_TipSjedistaId",
                table: "Narudzba",
                column: "TipSjedistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_AdministratorId",
                table: "Obavijest",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_NarudzbaId",
                table: "Ocjena",
                column: "NarudzbaId",
                unique: true,
                filter: "[NarudzbaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PredstavaZanr_PredstavaId",
                table: "PredstavaZanr",
                column: "PredstavaId");

            migrationBuilder.CreateIndex(
                name: "IX_PredstavaZanr_ZanrId",
                table: "PredstavaZanr",
                column: "ZanrId");

            migrationBuilder.CreateIndex(
                name: "IX_Teatar_GradId",
                table: "Teatar",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_DvoranaId",
                table: "Termin",
                column: "DvoranaId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_PredstavaId",
                table: "Termin",
                column: "PredstavaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipKorisnika_IduciTipKorisnikaId",
                table: "TipKorisnika",
                column: "IduciTipKorisnikaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uloga_GlumacId",
                table: "Uloga",
                column: "GlumacId");

            migrationBuilder.CreateIndex(
                name: "IX_Uloga_PredstavaId",
                table: "Uloga",
                column: "PredstavaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DvoranaTipSjedista");

            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "PredstavaZanr");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Zanr");

            migrationBuilder.DropTable(
                name: "Glumac");

            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Kupac");

            migrationBuilder.DropTable(
                name: "Termin");

            migrationBuilder.DropTable(
                name: "TipSjedista");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropTable(
                name: "KorisnickiNalog");

            migrationBuilder.DropTable(
                name: "TipKorisnika");

            migrationBuilder.DropTable(
                name: "Dvorana");

            migrationBuilder.DropTable(
                name: "Predstava");

            migrationBuilder.DropTable(
                name: "KorisnickaUloga");

            migrationBuilder.DropTable(
                name: "Teatar");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
