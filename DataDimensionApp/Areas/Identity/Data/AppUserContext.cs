using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataDimensionApp.Areas.Identity.Data;
using DataDimensionApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataDimensionApp.Data
{
    public class AppUserContext : IdentityDbContext<DataDimensionAppUser>
    {
        public AppUserContext(DbContextOptions<AppUserContext> options)
            : base(options)
        {
        }
        public DbSet <Employee> Employee { get; set; }
        public virtual DbQuery <Logins> Logins { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
