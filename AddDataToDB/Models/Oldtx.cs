using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class Oldtx
    {
        public int Id { get; set; }
        public string Onvan { get; set; }
        public string TarikhErsal { get; set; }
        public string ShomarePish { get; set; }
        public string NamVahed { get; set; }
        public string NamPishnahadDaha { get; set; }
        public string TarikhSabt { get; set; }
        public string NoePish { get; set; }
        public string Eghdam { get; set; }
        public string TarihJalase { get; set; }
        public string Vaziat { get; set; }
    }
}
