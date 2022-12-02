using EESV2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class ProposalRefrralsViewModel
    {
        [Required(ErrorMessage ="کارگروه را انتخاب کنید")]
        public int? CommitteeID { get; set; }

        public string MeetingNo { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IP { get; set; }
        public string Result { get; set; }

        public User Sender { get; set; }

        public User Reciver { get; set; }

        public string DesDabir { get; set; }
        public int? ProposalID { get; set; }
        public Proposal Proposal { get; set; }

        [Required(ErrorMessage = "نوع ارزیابی را مشخص کنید.")]
        public int? EvaluationTypeID { get; set; }
        public EvaluationType EvaluationType { get; set; }

        public int StatusID { get; set; }
        public ReferralStatus Status { get; set; }
    }

}
