namespace BeeIdentified.Data.Entities
{
    public class BeeData
    {
        public string LatinName { get; set; }
        public string CommonName { get; set; }
        public string ConservationStatus { get; set; }
        public string FirstColor { get; set; }
        public string SecondColor { get; set; }
        public string ThirdColor { get; set; }
        public bool Fuzzy { get; set; }
    }
}