using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class EditUserEditModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? StatusID { get; set; }
        public int? PostID { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string AddressHome { get; set; }
        public string WorkPhone { get; set; }
        public string Pic { get; set; }
        public int? OfficeID { get; set; }
        public int? EmploymentTypeID { get; set; }
        public int PictureState { get; set; }
        public int? PortalMembershipTypeID { get; set; }
    }
}
