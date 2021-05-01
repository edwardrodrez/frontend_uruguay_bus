using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using UruguayBus.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UruguayBus.Areas.Identity.Data;
using UruguayBus.Controllers;
using System.Net.Http;
using System.Security.Claims;
using UruguayBus.Hubs;

namespace UruguayBus
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
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSignalR().AddAzureSignalR();
            services.AddHttpContextAccessor();

            services.AddAuthorization(options => options.AddPolicy("admin", builder =>
            {
                builder.RequireAssertion(async context =>
                {
                    if (Temp.Instance.GetUs() == null)
                        return false;
                    return Temp.Instance.GetUs().rol == "admin";
                });
            }));
            services.AddAuthorization(options => options.AddPolicy("superadmin", builder =>
            {
                builder.RequireAssertion(async context =>
                {
                    if (Temp.Instance.GetUs() == null)
                        return false;
                    return Temp.Instance.GetUs().rol == "superadmin";
                });
            }));
            services.AddAuthorization(options => options.AddPolicy("Conductor", builder =>
            {
                builder.RequireAssertion(async context =>
                {
                    if (Temp.Instance.GetUs() == null)
                        return false;
                    return  Temp.Instance.GetUs().rol == "Conductor";
                });
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                
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

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMiddlewareToken();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapHub<ChatHub>("/chathub");
            });
        }
    }
}
