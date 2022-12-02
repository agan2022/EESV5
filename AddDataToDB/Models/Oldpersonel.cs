using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class Oldpersonel
    {
        public int Id { get; set; }
        public string PersonCode { get; set; }
        public string Name { get; set; }
        public string Fam { get; set; }
        public string Semat { get; set; }
        public byte? Madrak { get; set; }
        public byte? PlaceCode { get; set; }
        public byte[] Photo { get; set; }
        public string Email { get; set; }
        public byte? Sen { get; set; }
        public byte? Kind { get; set; }
    }
}
