using System;
using System.Collections.Generic;

namespace Naija.Model
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public IEnumerable<Lga> Lgas { get; set; } = new List<Lga>();
    }
}
