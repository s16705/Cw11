﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Models
{
    public class Prescription_Medicament
    {
        public int IdMedicament { get; set; }

        public int IdPrescription { get; set; }

        public int? Dose { get; set; }

        [MaxLength(100)]
        public string Details { get; set; }

        public virtual Medicament Medicaments { get; set; }
        public virtual Prescription Prescriptions { get; set; }
    }
}
