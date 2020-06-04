using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class SiteUser
    {

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string UserName { get; set; }

        [Required, StringLength(128)]
        public string Password { get; set; }


    }
}