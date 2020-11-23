using System;
using DataDimensionApp.Areas.Identity.Data;
using DataDimensionApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DataDimensionApp.Areas.Identity.IdentityHostingStartup))]
namespace DataDimensionApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppUserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AppUserContextConnection")));

                services.AddDefaultIdentity<DataDimensionAppUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<AppUserContext>();
            });
        }
    }
}