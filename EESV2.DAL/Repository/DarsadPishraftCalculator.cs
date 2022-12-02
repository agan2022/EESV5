using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Repository
{
    public class DarsadPishraftCalculator : IDarsadPishraftCalculator
    {
        private readonly EESContext _context;
        public DarsadPishraftCalculator(EESContext context)
        {
            _context = context;
        }
        public int CalculateDarsadPishraft(int proposalID)
        {
            try
            {
                List<Impart> imparts = _context.Imparts.Where(i => i.ProposalID == proposalID).Include(i=>i.Reports).ToList();
                if (imparts==null)
                {
                    return 0;
                }
                int darsad = 0;
                foreach (var impart in imparts)
                {
                    darsad += impart.Reports.Sum(r => r.Percentage);
                }
                return darsad / imparts.Count();
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
