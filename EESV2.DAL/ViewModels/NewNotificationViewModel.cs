using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class NewNotificationViewModel
    {
        public NewNotificationViewModel()
        {
            IsShow = true;
        }
        [Required(ErrorMessage = "عنوان اطلاعیه اجباری است.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="متن اطلاعیه اجباری است.")]
        public string Text { get; set; }
        public bool IsShow { get; set; }
    }
}
