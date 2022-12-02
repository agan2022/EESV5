using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class CreateCommitteeEditModel
    {
        [Display(Name = "نام کارگروه")]
        [Required(ErrorMessage = "نام کارگروه الزامی است.")]
        public string Name { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "انتخاب وضعیت الزامی است.")]
        public int StatusID { get; set; }

        [Display(Name = "دبیر کارگروه")]
        [Range(1,int.MaxValue,ErrorMessage = "انتخاب دبیر کارگروه الزامی است.")]
        public int SecretaryID { get; set; }
    }
}
