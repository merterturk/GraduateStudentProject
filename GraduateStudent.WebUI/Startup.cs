using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using GraduateStudent.Bll.Abstract;
using GraduateStudent.Bll.Concrete;
using GraduateStudent.Dal.Abstract;
using Microsoft.AspNetCore.Authentication.Cookies;
using GraduateStudent.Dal.Concrete.EntityFramework;

namespace GraduateStudent.WebUI
{
    public class Startup
    {
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSession(options=> {
                options.IdleTimeout = TimeSpan.FromMinutes(40);
                });
            services.AddDistributedMemoryCache();

            services.AddSingleton<IDepartmentService, DepartmentManager>();
            services.AddTransient<IStudentService, StudentManager>();
            services.AddSingleton<IDepartmentDal, EfDepartmentDal>();
            services.AddTransient<IStudentDal, EfStudentDal>();
            services.AddSingleton<IAnnouncementDal, EfAnnouncementDal>();
            services.AddSingleton<IAnnouncementService, AnnouncementManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseMvc(routes =>
            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}"
                )
                
             );
            app.UseStaticFiles();

            
        }
    }
}
