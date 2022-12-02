using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class CreateUserPostEditModel
    {
        [Required(ErrorMessage ="عنوان سمت را وارد کنید.")]
        public string Title { get; set; }
    }
}
