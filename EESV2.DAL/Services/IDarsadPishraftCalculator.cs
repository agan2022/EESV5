using EESV2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Services
{
    public interface IDarsadPishraftCalculator
    {
        public int CalculateDarsadPishraft(int proposalID);
    }
}
