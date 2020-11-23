using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DataDimensionApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the DataDimensionAppUser class
    public class DataDimensionAppUser : IdentityUser
    {
        [PersonalData]
        [Column("EmployeeNum")]
        public int EmployeeNumber { get; set; }

        [PersonalData]
        [Column("JobLevel")]
        public int JobLevel { get; set; }

    }
}
