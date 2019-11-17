using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Data;
using CIS174_TestCoreApp.Models;
using CIS174_TestCoreApp.Services;
using CIS174_TestCoreApp.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CIS174_TestCoreApp
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
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                options.Password.RequiredLength = 10)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            services.AddMvc();
            services.AddDbContext<PersonContext>();
            services.AddScoped<PersonContext>();
            services.AddDbContext<ErrorLogContext>();
            services.AddScoped<ErrorLogContext>();
            services.AddDbContext<LogContext>();
            services.AddScoped<LogContext>();
            services.AddDbContext<ApplicationDbContext>();
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<PersonService>();
            services.AddScoped<IAuthorizationHandler, IsAdminHandler>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "students",
                    template: "{controller=Student}/{action=Student}/{accessLevel?}");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "createperson",
                    template: "{controller=Student}/{action=Assignment7}");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "persons",
                    template: "{controller=Persons}/{action=Index}");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "famouspeople",
                    template: "{controller=FamousPeople}/{action=Accomplishments}");
            });
        }
    }
}
