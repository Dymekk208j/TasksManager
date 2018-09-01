using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasksMenager.Models.ViewModels
{
    public class CompanyListViewModel
    {
        public List<CompanyViewModel> Comapnies { get; set; }
        public bool NextPage { get; set; }
        public bool PreviousPage { get; set; }
        public int Page { get; set; }
    }
}