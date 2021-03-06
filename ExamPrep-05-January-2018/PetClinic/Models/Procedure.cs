﻿namespace PetClinic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class Procedure
    {
        [Key]
        public int Id { get; set; }

        public int AnimalId { get; set; }
        [Required]
        public Animal Animal { get; set; }

        public int VetId { get; set; }
        [Required]
        public Vet Vet { get; set; }

        public DateTime DateTime { get; set; }

        [NotMapped]
        public decimal Cost => this.ProcedureAnimalAids.Select(x => x.AnimalAid.Price).Sum();

        public ICollection<ProcedureAnimalAid> ProcedureAnimalAids { get; set; } = new HashSet<ProcedureAnimalAid>();
    }
}