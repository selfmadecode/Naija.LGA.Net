using System;
using System.Collections.Generic;
using System.Text;

namespace Naija.Grid.Net.Model
{
    internal class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public IEnumerable<LGA> LGAs { get; set; } = new List<LGA>();
    }
}
