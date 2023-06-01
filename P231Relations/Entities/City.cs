namespace P231Relations.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Area { get; set; } = null!;
        public int Population { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
