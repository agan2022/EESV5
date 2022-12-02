using EESV2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class CommitteeViewModel
    {
        [Display(Name = "نام کارگروه")]
        [Required(ErrorMessage = "نام کارگروه الزامی است.")]
        public string Name { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "انتخاب وضعیت الزامی است.")]
        public int StatusID { get; set; }
    }
    public class CreateCommitteeViewModel: CommitteeViewModel
    {

    }
    public class EditCommitteeViewModel : CommitteeViewModel
    {
        [Display(Name ="کد کارگروه")]
        [Required(ErrorMessage ="کد کارگروه الزامی است.")]
        public int ID { get; set; }
    }
}
