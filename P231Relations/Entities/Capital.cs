namespace P231Relations.Entities
{
    public class Capital//child or dependent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
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
