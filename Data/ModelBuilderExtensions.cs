using BugTrackerv2.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerv2.Data
{
    public static class ModelBuilderExtensions
    {

        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bug>().HasData(
                new Bug
                {
                    BugId = 1,
                    Title = "Poor Website loading",
                    Summary = "Upon opening website loads very slowly",
                    Assignee = "Stephen",
                    StepstoReproduce = "I did alot!",
                    ApplicationUsage = "I did alot",
                    ExpectedResult = "It opens up!",
                    ActualResult = "It does not open up",
                    IsActive = true,
                    BugSeverity = "High",
                    BugPriority = "P1",
                    BugType = "Website"
                },
                new Bug
                {
                    BugId = 2,
                    Title = "Poor Website loading",
                    Summary = "Upon opening website loads very slowly",
                    Assignee = "Stephen",
                    StepstoReproduce = "I did alot!",
                    ApplicationUsage = "I did alot",
                    ExpectedResult = "It opens up!",
                    ActualResult = "It does not open up",
                    IsActive = true,
                    BugSeverity = "High",
                    BugPriority = "P1",
                    BugType = "Website"

                },
                new Bug
                {
                    BugId = 3,
                    Title = "Poor Website loading",
                    Summary = "Upon opening website loads very slowly",
                    Assignee = "Stephen",
                    StepstoReproduce = "I did alot!",
                    ApplicationUsage = "I did alot",
                    ExpectedResult = "It opens up!",
                    ActualResult = "It does not open up",
                    IsActive = true,
                    BugSeverity = "High",
                    BugPriority = "P1",
                    BugType = "Website"

                });
            return modelBuilder;
        }





    }
}