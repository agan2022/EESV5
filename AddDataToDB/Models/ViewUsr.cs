using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewUsr
    {
        public int ManId { get; set; }
        public string ManName { get; set; }
        
        [Display(Name ="شماره پرسنلی")]
        public string Username { get; set; }

        [Display(Name ="رمز عبور")]
        public string Password { get; set; }

        [Display(Name ="نام")]
        public string Fname { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Lname { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime? CreateDate { get; set; }

        [Display(Name = "وضعیت")]
        public bool? ActiveFlag { get; set; }

        public bool? IsRetired { get; set; }


        [Display(Name = "سمت")]
        public string Semat { get; set; }

        [Display(Name = "تلفن خانه")]
        public string HomePhone { get; set; }

        [Display(Name = "شماره موبایل")]
        public string Mobile { get; set; }

        [Display(Name = "آدرس خانه")]
        public string AddressHome { get; set; }

        [Display(Name = "شماره تلفن محل کار")]
        public string WorkPhone { get; set; }
        public string EmP { get; set; }
        public byte? Raeis { get; set; }

        [Display(Name = "تصویر")]
        public string Pic { get; set; }
        public int? UnitId { get; set; }


        [Display(Name = "اداره")]
        public string Unit { get; set; }
        public bool? FinancialBoss { get; set; }

        [Display(Name = "بسیج")]
        public bool? Basij { get; set; }
        public string FatherUnit { get; set; }
    }
}
