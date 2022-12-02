using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class EditUserByUserEditModel
    {
        public int ID { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string AddressHome { get; set; }
        public string WorkPhone { get; set; }
        public string Pic { get; set; }
        public int PictureState { get; set; }
    }
}
