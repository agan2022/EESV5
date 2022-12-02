using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class EditOfficeViewModel
    {
        public int? ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="یک اداره را به عنوام سرپرست انتخاب کنید.")]
        public int? ParrentOfficeID { get; set; }
    }
}
