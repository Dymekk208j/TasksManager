using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TasksMenager.Models.ViewModels
{
    public class CompanyViewModel
    {
        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        [Display(Name = "Numer domu")]
        public string HouseNumber { get; set; }
        [Display(Name = "Numer mieszkania")]
        public string FlatNumber { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }

        public string GetAddress()
        {
            if (!String.IsNullOrEmpty(HouseNumber))
            {
                if (!String.IsNullOrEmpty(FlatNumber))
                {
                    return Street + " " + HouseNumber + " / " + FlatNumber;
                }
                else return Street + " " + HouseNumber;
            }
            else return Street;
        }
    }


}