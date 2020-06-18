﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }

        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }

        [ForeignKey("Patient")]
        public int IdPatient { get; set; }
        public virtual Patient Patiens { get; set; }

        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }
        public virtual Doctor Doctors { get; set; }

        public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }


    }
}
