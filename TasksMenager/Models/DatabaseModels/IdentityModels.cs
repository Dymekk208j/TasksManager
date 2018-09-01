using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TasksMenager.Models.DatabaseModels
{
    public class ApplicationUser : IdentityUser
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string PostCode { get; set; }

        public string PhoneNumberSecond { get; set; }
        public virtual List<Project> ProjectsList { get; set; } 
        public virtual List<RegisteredRealization> RegisteredRealizationsList { get; set; } 
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("AppConnectionString", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<RegisteredRealization> RegisteredRealizations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}