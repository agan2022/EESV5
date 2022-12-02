using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Quiz
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public List<Question> Questions { get; set; }
    }
}
