using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class EditCommitteeEditModel
    {
        [Display(Name = "کد کارگروه")]
        [Required(ErrorMessage = "کد کارگروه الزامی است.")]
        public int ID { get; set; }

        [Display(Name = "نام کارگروه")]
        [Required(ErrorMessage = "نام کارگروه الزامی است.")]
        public string Name { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "انتخاب وضعیت الزامی است.")]
        public int StatusID { get; set; }

        [Display(Name = "دبیر کارگروه")]
        [Required(ErrorMessage = "انتخاب دبیر کارگروه الزامی است.")]
        public int SecretaryID { get; set; }
    }
}
