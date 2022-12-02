using EESV2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class ProposalViewModel
    {
        public string SubjectPr { get; set; }
        public string CurrentDescPr { get; set; }
        public string NewDesPr { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IP { get; set; }
        public string CodeBazr { get; set; }
        public string DesDabir { get; set; }
        public bool Ch01 { get; set; }
        public bool Ch02 { get; set; }
        public bool Ch03 { get; set; }
        public bool Ch04 { get; set; }
        public bool Ch05 { get; set; }
        public bool Ch06 { get; set; }
        public bool Ch07 { get; set; }
        public bool Ch08 { get; set; }
        public bool Ch09 { get; set; }
        public bool Ch10 { get; set; }
        public bool Ch11 { get; set; }
        public bool Ch12 { get; set; }
        public bool Ch13 { get; set; }
        public bool Ch14 { get; set; }
        public bool Ch15 { get; set; }
        public bool Ch16 { get; set; }
        public bool Ch17 { get; set; }
        public bool Ch18 { get; set; }
        public bool Ch19 { get; set; }
        public bool Ch20 { get; set; }
        public bool Ch21 { get; set; }
        public bool Ch22 { get; set; }
        public bool Ch23 { get; set; }
        public bool Ch24 { get; set; }
        public bool Ch25 { get; set; }
        public bool Ch26 { get; set; }
        public bool Ch27 { get; set; }
        public bool Ch28 { get; set; }
        public bool Ch29 { get; set; }
        public bool Ch30 { get; set; }
        public bool Ch31 { get; set; }
        public bool Ch32 { get; set; }
        public bool Ch33 { get; set; }
        public bool Ch34 { get; set; }
        public bool Ch35 { get; set; }
        public bool Ch36 { get; set; }
        public bool Ch37 { get; set; }
        public decimal? EjraDaily { get; set; }
        public decimal? EjraMonthly { get; set; }
        public decimal? EjraYear { get; set; }
        public decimal? Ejra5Year { get; set; }
        public decimal? GetDaily { get; set; }
        public decimal? GetMonthly { get; set; }
        public decimal? GetYear { get; set; }
        public decimal? Get5Year { get; set; }
        public decimal? SarfeDaily { get; set; }
        public decimal? SarfeMonthly { get; set; }
        public decimal? SarfeYear { get; set; }
        public decimal? Sarfe5Year { get; set; }

        public string file { get; set; }

        public int CommitteeID { get; set; }

    }
    public class NewProposalViewModel: ProposalViewModel
    {
        public NewProposalViewModel()
        {
            Helpers = new List<Participant>();
        }
        public Referral Referral { get; set; }
        public User Sender { get; set; }
        public User Reciver { get; set; }

        public User Registrar { get; set; }
        public List<Participant> Helpers { get; set; }
    }
}
