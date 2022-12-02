using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class CreateImpartBySecretaryEditModel
    {
        [Required(ErrorMessage ="یک کاربر را انتخاب کنید")]
        [Range(1,int.MaxValue,ErrorMessage = "یک کاربر را انتخاب کنید")]
        public string UserName { get; set; }

        [Required]
        public int ProposalID { get; set; }
    }
}
