using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UruguayBus.Areas.Identity.Data;
using UruguayBus.Data;

[assembly: HostingStartup(typeof(UruguayBus.Areas.Identity.IdentityHostingStartup))]
namespace UruguayBus.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UruguayBusContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UruguayBusContextConnection")));

                services.AddDefaultIdentity<UruguayBusUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<UruguayBusContext>(); 
                services.AddTransient<IUserStore<UruguayBusUser>, CustomUserStore>();
            });
        }
    }
}