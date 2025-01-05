namespace Naija.Model
{
    /// <summary>
    /// Represents a Local Government Area (LGA) in a state!
    /// </summary>
    public class Lga
    {
        /// <summary>
        /// Gets or sets the unique identifier of the LGA.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the LGA.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the population of the LGA.
        /// </summary>
        public int Population { get; set; }
    }
}
