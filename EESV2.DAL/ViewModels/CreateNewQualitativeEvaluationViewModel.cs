using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class CreateNewQualitativeEvaluationViewModel
    {
        [Required]
        public bool? PishOk { get; set; }
        [Required]
        public byte? Quality { get; set; }
        [Required]
        public double? HrWork { get; set; }
        public int Q1 { get; set; }
        public int Q2 { get; set; }
        public int Q3 { get; set; }
        public int Q4 { get; set; }
        public int Q5 { get; set; }
        public int Q6 { get; set; }
        public int Q7 { get; set; }
        public int Q8 { get; set; }
        public int Q9 { get; set; }
        public int Q10 { get; set; }
        public int Q11 { get; set; }
        public int Q12 { get; set; }
        public int Q13 { get; set; }
        public int Q14 { get; set; }
        public int Q15 { get; set; }
        public int Q16 { get; set; }
        public int Q17 { get; set; }
        public int Q18 { get; set; }
        public string RejectReason { get; set; }

        public int? ReferralID { get; set; }
        public int? ProposalID { get; set; }
    }
}
