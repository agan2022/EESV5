using AutoMapper;
using EESV2.DAL;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    [Authorize]
    public class OfficeController : Controller
    {
        private readonly EESContext _context;
        public OfficeController(EESContext context)
        {
            _context = context;
        }
        public async Task<List<Office>> Offices()
        {
            List<Office> offices =await _context.Offices.ToListAsync();
            return offices;
        }
    }
}
