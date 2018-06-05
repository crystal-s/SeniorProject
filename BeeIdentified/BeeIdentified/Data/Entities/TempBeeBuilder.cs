using System;
using System.ComponentModel.DataAnnotations;

namespace BeeIdentified.Data.Entities
{
    public class TempBeeBuilder
    {
        [Key]
        public string BeeID { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public Color FirstColor { get; set; }
        public Color SecondColor { get; set; }
        public Color ThirdColor { get; set; }
        public string Fuzzy { get; set; }
    }

}