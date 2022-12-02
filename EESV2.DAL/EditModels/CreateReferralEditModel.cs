using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class CreateReferralEditModel
    {
        public int? ProposalID { get; set; }

        [Required(ErrorMessage = "کارگروه را انتخاب کنید")]
        public int? CommitteeID { get; set; }
        [Required(ErrorMessage = "نوع ارزیابی را مشخص کنید.")]
        public int? EvaluationTypeID { get; set; }
        public string MeetingNo { get; set; }
        public string Description { get; set; }

    }
}
