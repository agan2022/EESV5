using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EESV2.DAL;
using EESV2.DAL.Services;
using EESV2.Utilities;
using EESV2.DAL.Entities;

namespace EESV2.MiddleWares
{
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        public VisitorCounterMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context,IUnitOfWork UW,IUtilities utilities)
        {
            string visitorId = context.Request.Cookies["VisitorId"];
            if (visitorId == null)
            {
                //don the necessary staffs here to save the count by one

                context.Response.Cookies.Append("VisitorId", Guid.NewGuid().ToString(), new CookieOptions()
                {
                    Path = "/",
                    HttpOnly = true,
                    Secure = false,
                    Expires= DateTime.Today.AddDays(1)
                });
                VisitorStatistic visitorStatistic = UW.VisitorStatisticRepository.Get(v => v.Date == utilities.GetDate()).FirstOrDefault();
                if ((visitorStatistic != null))
                {
                    visitorStatistic.VisitCount++;
                    UW.VisitorStatisticRepository.Update(visitorStatistic);
                    await UW.SaveChangesAsync();
                }
                else 
                {
                    visitorStatistic = new VisitorStatistic()
                    {
                        Date = utilities.GetDate(),
                        VisitCount = 1
                    };
                    UW.VisitorStatisticRepository.Create(visitorStatistic);
                    await UW.SaveChangesAsync();
                }
            }

            await _requestDelegate(context);
        }
    }
}
