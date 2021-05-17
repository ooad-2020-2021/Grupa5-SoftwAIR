﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public class KupovinaKarte : Kupovina
    {
        #region Properties
        [Required]
        public int brojKarti { get; set; }
        [Required]
        public DateTime datumPolaska { get; set; }
        [Required]
        public Lokacija lokacijaPolaska { get; set; }
        [Required]
        public Lokacija lokacijaOdredista { get; set; }
        public DateTime datumPovratka { get; set; } //nije required jer ne mora biti povratna karta
        [NotMapped]
        [Required]
        public List<Karta> listaKarata { get; set; }
        #endregion

        public KupovinaKarte(int ID, String statusKupovine, DateTime datumKupovine, int idKupca, int brojKarti, DateTime datumPolaska, Lokacija lokacijaPolaska, Lokacija lokacijaOdredista, DateTime datumPovratka, List<Karta> listaKarata)
        : base(ID, statusKupovine, datumKupovine, idKupca) {
            this.brojKarti = brojKarti;
            this.datumPolaska = datumPolaska;
            this.lokacijaOdredista = lokacijaOdredista;
            this.lokacijaPolaska = lokacijaPolaska;
            this.datumPovratka = datumPovratka;
            this.listaKarata = listaKarata;
            
        }

        public void dodajKartu(Karta karta) {
            //TODO
        }
        public Double dajCijenu() {
            //TODO
            return 0;
        }

        public List<Let> dajDostupneLetove()
        {
            List < Let > lista = new List<Let>();
            return lista;
            //TODO
        }
       
    }
}