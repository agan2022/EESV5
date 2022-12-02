using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Notification
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublishedDateTime { get; set; }
        public bool IsShow { get; set; }
    }
}
