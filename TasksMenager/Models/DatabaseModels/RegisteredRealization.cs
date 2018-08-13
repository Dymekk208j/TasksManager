using System;

namespace TasksMenager.Models.DatabaseModels
{
    public class RegisteredRealization
    {
        public int RegisteredRealizationId { get; set; }
        public DateTime Date { get; set; }
        public float AmountOfHours { get; set; }
        public ApplicationUser User { get; set; }

    }
}