using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels.ReportMonitoringIndicatorsOfEES
{
    public class ReportMonitoringIndicatorsOfEESViewModel
    {
        [Required(ErrorMessage = "انتخاب حداقل یک اداره الزامی است")]
        public List<int> OfficeIDs { get; set; }
        public string Date
        {
            get
            { return _date; }
            set 
            {
                _date = value;
                var temp = value.Split("/");
                _year =Convert.ToInt32(temp[0]);
                _month = Convert.ToInt32(temp[1]);
            }
        }





        private string _date;
        public List<int> Days { get; set; }
        public List<int> Months { get; set; }

        private int _year;
        private int _month;
        public int getYear()
        {
            return _year;
        }
        public int getMonth()
        {
            return _month;
        }
    }
}
