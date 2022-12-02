using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class ProposalsViewModel
    {
        [Required]
        public int? StatusID { get; set; } = 4;
        [Required]
        public List<string> FromDate { get; set; }
        [Required]
        public List<string> ToDate { get; set; }
    }
}
