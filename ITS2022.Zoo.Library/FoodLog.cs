namespace ITS2022.Zoo.Library
{
    /// <summary>
    /// Registro per tenere traccia dei pasti
    /// </summary>
    public class FoodLog
    {
        /// <summary>
        /// Identificativo dell'animale
        /// </summary>
        public string AnimalId { get; set; }
        /// <summary>
        /// Che tipo di cibo è stato dato
        /// </summary>
        public FoodType Food { get; set; }
        /// <summary>
        /// Quando è stato dato
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}
