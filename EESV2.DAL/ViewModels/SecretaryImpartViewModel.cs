using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class SecretaryImpartViewModel
    {
        public SecretaryImpartViewModel(int impartID)
        {
            ImpartID = impartID;
        }
        public SecretaryImpartViewModel()
        {

        }
        public int? ImpartID { get; set; }
    }
}
