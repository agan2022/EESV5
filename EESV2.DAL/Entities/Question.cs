using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Question
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public AnswerType Type { get; set; }

        public string Value { get; set; }

        public int QuizID { get; set; }
        public Quiz Quiz { get; set; }
        public List<Radio> Radios { get; set; }
    }
    public enum AnswerType
    {
        test,
        descriptive
    }
}
