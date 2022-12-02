using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class EditNotificationEditModel
    {
        public int? ID { get; set; }
        [Required(ErrorMessage = "عنوان اطلاعیه اجباری است.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "متن اطلاعیه اجباری است.")]
        public string Text { get; set; }
        public bool IsShow { get; set; }
    }
}
