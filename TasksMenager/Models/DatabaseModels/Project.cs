using System;
using System.Collections.Generic;

namespace TasksMenager.Models.DatabaseModels
{
    public enum State
    {
        Realization,
        Paused,
        New,
        Checking,
        Done
    }
    public class Project
    {
        public int ProjectId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public Company Company { get; set; }
        public float TimeBudgetAllocated { get; set; }
        public float UsedTimeBudget { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime SheduledDate { get; set; }
        public DateTime ResponseDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public ApplicationUser AssignedTo { get; set; }
        public State State { get; set; }
        public virtual List<RegisteredRealization> RegisteredRealizationList { get; set; }

    }
}