using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataDimensionApp.Models;
using DataDimensionApp.Areas.Identity.Data;

namespace DataDimensionApp.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<DataDimensionApp.Models.Employee> Employee { get; set; }
       

    }
}
