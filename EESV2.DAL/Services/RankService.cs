using EESV2.DAL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EESV2.DAL.Entities;
using EESV2.DAL.ViewModels;
using EESV2.DAL.ViewModels.TopMemberReport;
using Microsoft.EntityFrameworkCore;

namespace EESV2.DAL.Services
{
    public class RankService : IRankService
    {
        private EESContext _context;

        public RankService(EESContext context)
        {
            _context = context;
        }

    }
}
