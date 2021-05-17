﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public abstract class Kupovina
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public String statusKupovine { get; set; }
        [Required]
        public DateTime datumKupovine { get; set; }
        [Required]
        public int idKupca { get; set; }
        #endregion

        public Kupovina(int ID, String statusKupovine, DateTime datumKupovine, int idKupca)
        {
            this.ID = ID;
            this.statusKupovine = statusKupovine;
            this.datumKupovine = datumKupovine;
            this.idKupca = idKupca;
        }

        public void postaviStatus(String status) { }
        public void odustani() { }
    }
}