using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EESV2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using EESV2.DAL.Services;
using EESV2.DAL.Repository;
using EESV2.DAL.Services.Interfaces;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using EESV2.MiddleWares;
using Newtonsoft.Json;

namespace EESV2
{
    public class Startup
    {
        IConfiguration _configuration;
        public Startup(IConfiguration conf)
        {
            _configuration = conf;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(option =>
            {
                option.LoginPath = "/Account/Login";
                option.LogoutPath = "/Account/LogOut";
                option.AccessDeniedPath = "/Account/AccessDenied";
            });
            services.AddDbContext<EESContext>(option =>
            {
                option.UseSqlServer(_configuration.GetConnectionString("Default"));
            });
            services.AddScoped<IProposalRepository, ProposalRepository>();
            services.AddScoped<IQuantitativeEvaluationRepository, QuantitativeEvaluationRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IUtilities,Utilities.Utilities>();
            services.AddTransient<IProposalService, ProposalService>();
            services.AddAutoMapper(typeof(Startup));
            services.AddMvc().AddNewtonsoftJson(options => {
                                      options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                  });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseMiddleware(typeof(VisitorCounterMiddleware));
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                //Secretary panel route
                endpoints.MapAreaControllerRoute(
                    "Secretary",
                    "Secretary",
                    "Secretary/{Controller=Home}/{action=index}/{id?}"
                    );
                //default route
                endpoints.MapControllerRoute(
                    name: "default",
                    //pattern: "{controller=Account}/{action=Login}/{id?}");
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
