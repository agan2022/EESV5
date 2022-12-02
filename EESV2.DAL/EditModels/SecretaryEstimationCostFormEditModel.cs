using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class SecretaryEstimationCostFormEditModel
    {
        [Required(ErrorMessage ="پر کردن ای دی ضروری است.")]
        public int ID { get; set; }
        [Required(ErrorMessage = "لطفا یک وضعیت را انتخاب کنید.")]
        public int ImpartStatusID { get; set; }
    }
}
