using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblUsr
    {
        [Display(Name ="شماره پرسنلی")]
        [Required(ErrorMessage ="پر کردن شماره پرسنلی اجباری است")]
        public string Username { get; set; }
        [Display(Name = "رمز عبور")]
        [MinLength(8,ErrorMessage ="رمز عبور باید حداقل 8 کاراکتر داشته باشد.")]
        [Required(ErrorMessage = "پر کردن رمز عبور اجباری است")]
        public string Password { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "پر کردن نام اجباری است")]
        public string Fname { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "پر کردن نام خانوادگی اجباری است")]
        public string Lname { get; set; }
        [Display(Name ="نام اداره")]
        public int? ManId { get; set; }
        public DateTime? CreateDate { get; set; }
        [Display(Name ="وضعیت")]
        public bool? ActiveFlag { get; set; }
        public bool? IsRetired { get; set; }
        [Display(Name = "سمت")]
        public string Semat { get; set; }
        [Display(Name = "تلفن خانه")]
        public string HomePhone { get; set; }
        [RegularExpression("^09[0-9]{9}$", ErrorMessage = "شماره تلفن باید به فرمت 09xxxxxxxxx وارد شود")]
        [Display(Name = "شماره موبایل")]
        public string Mobile { get; set; }
        [Display(Name = "ادرس خانه")]
        public string AddressHome { get; set; }
        [Display(Name = "تلفن محل کار")]
        public string WorkPhone { get; set; }
        public string EmP { get; set; }
        public byte? Raeis { get; set; }
        [Display(Name = "تصویر")]
        public string Pic { get; set; }
        [Required(ErrorMessage = "انتخاب نام اداره اجباری است.")]
        [Display(Name = "نام اداره")]
        public int? UnitId { get; set; }
        public string Roles { get; set; }
        public bool? FinancialBoss { get; set; }
        public bool? Basij { get; set; }
    }
}
