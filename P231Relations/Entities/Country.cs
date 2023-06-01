namespace P231Relations.Entities
{
    public class Country//parent or principial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public Capital Capital { get; set; }
        public ICollection<City> Cities { get; set; }

        public Country()
        {
            Cities = new HashSet<City>();
        }
    }

    //public class Country//child or dependent
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Population { get; set; }
    //    public int CapitalId { get; set; }
    //    public Capital Capital { get; set; }

    //}

    //public class Capital//parent or principial
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Population { get; set; }
    //    public Country Country { get; set; }
    //}



}
