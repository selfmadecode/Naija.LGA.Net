using System;
using System.Collections.Generic;
using System.Text;

namespace Naija
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public IEnumerable<Lga> LGAs { get; set; } = new List<Lga>();
    }
}
