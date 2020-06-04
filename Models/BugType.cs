namespace BugTracker.Models
{
    public class BugType
    {

        public int Id { get; set; }

        string[] bugtypes = new string[4] { "Memory Usage", "Performance", "RegressionBug", "Specific Website" };

    }
}