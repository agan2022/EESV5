using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class CreateUserViewModel
    {
        [Display(Name = "شماره پرسنلی")]
        [Required(ErrorMessage = "پر کردن شماره پرسنلی الزامی است")]
        public string Username { get; set; }

        [Display(Name = "رمز عبور")]
        [MinLength(8, ErrorMessage = "رمز عبور باید حداقل 8 کاراکتر داشته باشد.")]
        [Required(ErrorMessage = "پر کردن رمز عبور الزامی است")]
        public string Password { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "پر کردن نام الزامی است")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "پر کردن نام خانوادگی الزامی است")]
        public string LastName { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "وضعیت الزامی است")]
        public int? StatusID { get; set; }

        [Display(Name = "سمت")]
        [Required(ErrorMessage = "سمت الزامی است")]
        public int? PostID { get; set; }

        [Display(Name = "تلفن خانه")]
        public string HomePhone { get; set; }

        [RegularExpression("^09[0-9]{9}$", ErrorMessage = "شماره تلفن باید به فرمت 09xxxxxxxxx وارد شود")]
        [Display(Name = "شماره موبایل")]
        public string Mobile { get; set; }

        [Display(Name = "ادرس خانه")]
        public string AddressHome { get; set; }

        [Display(Name = "تلفن محل کار")]
        public string WorkPhone { get; set; }

        [Display(Name = "تصویر")]
        public string Pic { get; set; }
        [Required(ErrorMessage ="اداره الزامی است")]
        [Range(0,int.MaxValue,ErrorMessage = "اداره الزامی است")]
        public int? OfficeID { get; set; }
        [Required(ErrorMessage = "نوع استخدامی الزامی است")]
        public int? EmploymentTypeID { get; set; }
        [Required(ErrorMessage = "نوع عضویت در پرتال الزامی است")]
        public int? PortalMembershipTypeID { get; set; }
    }
}
