using Naija.LGA.Net.Model;
using System.Collections.Generic;

namespace Naija.Model
{
    public class Lga
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }
}
