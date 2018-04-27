using System.ComponentModel.DataAnnotations;

namespace BeeIdentified.Data
{
    // Get userID and BeeID info
    public class UserBees
    {   [Key]
        public string UserID { get; set; }
        [Key]
        public string BeeID { get; set; }
        public string Location { get; set; } // Look into this -> some sort of coordinate value thing
    }
    
}