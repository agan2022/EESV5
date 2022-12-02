using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class CreateOfficeEditModel
    {
        [Required(ErrorMessage = "وارد کردن نام اداره الزامی است.")]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "انتخاب اداره سرپرست الزامی است.")]
        public int? ParrentOfficeID { get; set; }
    }
}
