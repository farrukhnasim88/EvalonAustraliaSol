namespace EvalonAustralia.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public Person Person { get; set; }
        public string ImageUrl { get; set; }

    }
}