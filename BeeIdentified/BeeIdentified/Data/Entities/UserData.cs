using System.ComponentModel.DataAnnotations;

namespace BeeIdentified.Data.Entities
{
    public class UserData
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        //public 
    }
}