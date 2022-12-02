using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class CreateQualitativeEvaluationFormViewModel
    {
        public CreateQualitativeEvaluationFormViewModel()
        {

        }
        public CreateQualitativeEvaluationFormViewModel(int referralID)
        {
            ReferralID = referralID;
        }
        [Required]
        public int? ReferralID { get; set; }
        public bool? PishOk { get; set; }
        public byte? Quality { get; set; }
        public double? HrWork { get; set; }
        public int? K1 { get; set; }
        public int? K2 { get; set; }
        public int? K3 { get; set; }
        public int? K4 { get; set; }
        public int? K5 { get; set; }
        public int? K6 { get; set; }
        public int? K7 { get; set; }
        public int? K8 { get; set; }

        public string RejectReason { get; set; }

        public int? ProposalID { get; set; }
    }
}
