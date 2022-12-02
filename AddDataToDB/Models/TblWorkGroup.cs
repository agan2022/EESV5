using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblWorkGroup
    {
        [Display(Name ="کد کارگروه")]
        public int WgId { get; set; }
        [Display(Name ="نام کارگروه")]
        [Required(ErrorMessage ="وارد کردن نام کارگروه اجباری است.")]
        public string WgName { get; set; }
        [Display(Name ="وضعیت کارگروه")]
        public bool? WgStatus { get; set; }
    }
}
