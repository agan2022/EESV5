using EESV2.DAL.Entities;
using EESV2.DAL.ViewModels.TopMemberReport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels.TopMemberReport
{
    public class TopMemberViewModel
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
                _year = Convert.ToInt32(temp[0]);
                _month = Convert.ToInt32(temp[1]);
            }
        }




        public List<UserRankViewModel> userRankViewModels { get; set; }


        private string _date;
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
