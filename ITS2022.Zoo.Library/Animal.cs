using System.Text.Json.Serialization;

namespace ITS2022.Zoo.Library
{
    /// <summary>
    /// Animale
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Identificativo dell'animale
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Nome dell'animale, ad esempio Chunky
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Specie animale, ad esempio orso bruno
        /// </summary>
        public string Kind { get; set; }
        /// <summary>
        /// Tipologia di cibo mangiato
        /// </summary>
        public FoodType Food { get; set; }
    }
}
