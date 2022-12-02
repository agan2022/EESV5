using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class NewObjectionViewModel
    {
        [Required]
        public int? ProposalID { get; set; }
        [Required]
        public string Reasons { get; set; }
    }
}
