using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using My_Project.Context;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace My_Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Db_Context
            services.AddDbContext<My_ProjectContext>(options => 
                {
                    options.UseSqlServer("Data Source =.;Initial Catalog=My_Project;Integrated Security=true"); 
                });

            // services.AddDbContext<My_ProjectContext>(option =>
            // {
            //     option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            // });

            #endregion

            services.AddControllersWithViews();
            services.AddSession();
            services.AddHttpContextAccessor();
            services.AddMvc().AddRazorRuntimeCompilation();
            services.AddAuthentication (options => {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie (options => {
                options.LoginPath = "/Home/index";
                options.LogoutPath = "/Home/index";
                options.ExpireTimeSpan = TimeSpan.FromHours(4320);
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication ();
            app.UseAuthorization ();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
