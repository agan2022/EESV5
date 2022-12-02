using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
   public  class AddProgressReport
    {
        [Required]
        public string Description { get; set; }

        [Range(0,100,ErrorMessage="درصد باید بین 0 تا 100 باشد.")]
        [Required]
        public int Percentage { get; set; }

        [Required]
        public string Defects { get; set; }

        [Required]
        public int? ImpartID { get; set; }

        public string ErrorMessage { get; set; }
    }
}
