using EESV2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class QuantitativeEvaluationFormViewModel
    {
        [Required]
        public bool? PishOk { get; set; }

        [Required]
        public byte? Quality { get; set; }

        [Required]
        public double? HrWork { get; set; }

        [Required]
        public byte? Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Q5 { get; set; }
        public string Q6 { get; set; }
        public string Q7 { get; set; }
        public string Q8 { get; set; }
        public string Q9 { get; set; }
        public string Q10 { get; set; }

        [Required]
        public string ErjraDaily { get; set; }

        [Required]
        public string EjraMonth { get; set; }

        [Required]
        public string EjraYear { get; set; }

        [Required]
        public string Ejra5Year { get; set; }

        [Required]
        public string SamarDaily { get; set; }

        [Required]
        public string SamarMonth { get; set; }

        [Required]
        public string SamarYear { get; set; }

        [Required]
        public string Sama5Year { get; set; }

        [Required]
        public string SarfeDaily { get; set; }

        [Required]
        public string SarfeMonth { get; set; }

        [Required]
        public string SarfeYear { get; set; }

        [Required]
        public string Sarfe5Year { get; set; }

        [Required]
        public string MablaghNahaiNumber { get; set; }

        [Required]
        public string MablaghNahaiAlphabet { get; set; }


        [Required]
        public int? ReferralID { get; set; }
    }
}
