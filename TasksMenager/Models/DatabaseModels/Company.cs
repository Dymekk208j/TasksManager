using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasksMenager.Models.DatabaseModels
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string City { get; set; }
        public virtual List<Project> ListOfProjects { get; set; }
    }
}