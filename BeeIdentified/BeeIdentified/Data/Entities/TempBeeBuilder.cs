using System;

namespace BeeIdentified.Data.Entities
{
    public class TempBeeBuilder
    {

        public string Location { get; set; }
        public DateTime Date { get; set; }
        public Color FirstColor { get; set; }
        public Color SecondColor { get; set; }
        public Color ThirdColor { get; set; }
        public string Fuzzy { get; set; }
    }

}