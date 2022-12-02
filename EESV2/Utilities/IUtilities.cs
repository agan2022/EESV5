using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace EESV2.Utilities
{
    public interface IUtilities
    {
        public DateTime GetCurrentDateTime();
        public string GetDate();
        public string GetTime();
        public string GetUSRIP(HttpContext httpContext);
        public int GetYearDate(int offset=0);
        public int GetMonthDate(int offset = 0);
        public int GetDayDate(int offset = 0);
        public string GetSHA512Hash(string text);
    }
}
