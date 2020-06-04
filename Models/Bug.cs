using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTrackerv2.Models
{
    public class Bug
    {

        //business object, domain object. The model includes data and can also include behaviour. Typically, models for CRUD applications don't tend to incorporate a lot of behaviour.
        [Key]
        public int BugId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }

        [Required]
        public string Assignee { get; set; }

        [Required]
        [Display(Name = "Steps to Reproduce")]
        public string StepstoReproduce { get; set; }

        [Display(Name = "Application Usage")]
        public string ApplicationUsage { get; set; }

        [Required]
        [Display(Name = "Expected Result")]
        public string ExpectedResult { get; set; }

        [Required]
        [Display(Name = "Actual Result")]
        public string ActualResult { get; set; }

        [Required]
        [Display(Name = "Bug Type")]
        public string BugType { set; get; }

        [Required]
        [Display(Name = "Bug Priority")]
        public string BugPriority { get; set; }

        [Required]
        [Display(Name = "Bug Severity")]
        public string BugSeverity { set; get; }

        [Display(Name = "Bug is still active")]
        public bool IsActive { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Date Inactive")]
        public DateTime DateInactive { get; set; }
    }
}