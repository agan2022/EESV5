using EESV2.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Services
{
    public interface IRankCalculator
    {
        public List<UserRankViewModel> CalculateRank();
        public List<UserRankViewModel> CalculateRank(List<int> officeIDs, int year, int month);
    }
}
