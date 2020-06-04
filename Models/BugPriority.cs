namespace BugTracker.Models
{
    public class BugPriority
    {
        public int Id { get; set; }
        string[] bugpriorities = new string[3] { "High", "Medium", "Low" };
    }
}