using System;
using System.ComponentModel.DataAnnotations;
using TasksMenager.Models.DatabaseModels;

namespace TasksMenager.Models.ViewModels
{
    public class CreateProjectViewModel
    {
        [Display(Name="Kod zadania")]
        public string Code { get; set; }
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [Display(Name = "Firma")]
        public int CompanyId { get; set; }
        [Display(Name = "Przydzielony budżet czasowy")]
        public float TimeBudgetAllocated { get; set; }
        [Display(Name = "Zaplanowana data wykonania")]
        public DateTime SheduledDate { get; set; }
        [Display(Name = "Ostateczna data wykonania")]
        public DateTime Deadline { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Display(Name = "Przydzielone do")]
        public string AssignedToUserId { get; set; }
    }
}