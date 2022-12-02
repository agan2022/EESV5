using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class ChangePasswordByUserEditModel
    {
        [Required(ErrorMessage ="رمز عبور قبلی را وارد کنید.")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "رمز عبور جدید را وارد کنید.")]
        public string NewPassword { get; set; }
    }
}
