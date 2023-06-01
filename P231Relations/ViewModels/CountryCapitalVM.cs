using P231Relations.Entities;

namespace P231Relations.ViewModels
{
    public class CountryCapitalVM
    {
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Capital> Capitals { get; set; }
    }
}
