using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeeIdentified.Data.Entities
{
    public class UserHistoryData
    {
        [Key]
        public int UserID { get; set; }

        public int SpeciesSeen { get; set; }
        public int TotalBeesSpotted { get; set; }
        public int TotalLocationsVisited { get; set; }
        public ICollection<BeeData> Bees { get; set; }
    }
}