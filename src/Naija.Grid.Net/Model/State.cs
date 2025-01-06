using System.Collections.Generic;

namespace Naija.Model
{
    /// <summary>
    /// Represents a state, including its capital and Local Government Areas (LGAs).
    /// </summary>
    public class State
    {
        /// <summary>
        /// Gets or sets the unique identifier of the state.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the state.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the capital city of the state.
        /// </summary>
        public string Capital { get; set; }

        /// <summary>
        /// Gets or sets the collection of LGAs associated with the state.
        /// </summary>
        public IEnumerable<Lga> Lgas { get; set; } = new List<Lga>();
    }
}
