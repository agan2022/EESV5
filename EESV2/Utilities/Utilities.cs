using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.Utilities
{
    public class Utilities: IUtilities
    {

        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
        public string GetDate()
        {
            DateTime d = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d).ToString("0#"), pc.GetDayOfMonth(d).ToString("0#"));
        }

        public int GetYearDate(int offset=0)
        {
            DateTime d = DateTime.Now.AddYears(offset);
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(d);
        }
        public int GetMonthDate(int offset=0)
        {
            DateTime d = DateTime.Now.AddMonths(offset);
            PersianCalendar pc = new PersianCalendar();
            return pc.GetMonth(d);
        }
        public int GetDayDate(int offset = 0)
        {
            DateTime d = DateTime.Now.AddDays(offset);
            PersianCalendar pc = new PersianCalendar();
            return pc.GetDayOfMonth(d);
        }









        public string GetTime()
        {
            string time = "";
            if (DateTime.Now.Hour < 10)
                time = "0" + DateTime.Now.Hour.ToString();
            else
                time = DateTime.Now.Hour.ToString();
            if (DateTime.Now.Minute < 10)
                time += ":0" + DateTime.Now.Minute.ToString();
            else
                time += ":" + DateTime.Now.Minute.ToString();
            if (DateTime.Now.Second < 10)
                time += ":0" + DateTime.Now.Second.ToString();
            else
                time += ":" + DateTime.Now.Second.ToString();
            return time;
        }
        public string GetUSRIP(HttpContext httpContext)
        {
            return httpContext.Connection.LocalIpAddress.MapToIPv4().ToString();
        }

        public string GetSHA512Hash(string text)
        {
            var data = Encoding.UTF8.GetBytes(text);
            string hash = "";
            using (SHA512Managed sha = new SHA512Managed())
            {
                var bytes = sha.ComputeHash(data);
                hash = BitConverter.ToString(bytes).Replace("-", String.Empty);
            }
            return hash;
        }
    }
}
