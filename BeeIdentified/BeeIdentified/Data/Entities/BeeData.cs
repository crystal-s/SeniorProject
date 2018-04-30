using System.ComponentModel.DataAnnotations;

namespace BeeIdentified.Data.Entities
{
    public class BeeData
    {
        [Key]
        public string BeeID { get; set; }
        public string LatinName { get; set; }
        public string CommonName { get; set; }
        public ConservationStatus ConservationStatus { get; set; }
        public Color FirstColor { get; set; }
        public Color SecondColor { get; set; }
        public Color ThirdColor { get; set; }
        public bool Fuzzy { get; set; }
        public byte[] Photo { get; set; }
    }

    // enums with Bee info
    public enum ConservationStatus
    {
        LeastConcern = 1,
        ConservationDependant = 2,
        NearThreatened = 3,
        Vulnerable = 4,
        Endangered = 5,
        CriticallyEndangered = 6,
        ExtinctintheWild = 7,
        Extinct = 8,
        DataDeficient = 9,
        NotEvaluated = 10
    }

    public enum Color
    {
        // Some colors
        Black = 1,
        White = 2,
        Brown = 3,
        Yellow = 4,
        Orange = 5,
        Blue = 6,
        Green = 7,
        Red = 8,
        Purple = 9
    }
}