namespace ITS2022.Zoo.Library
{
    /// <summary>
    /// Classe che permette il salvataggio ed il caricamento dei dati.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Lista degli animali presenti nello zoo
        /// </summary>
        public List<Animal> Animals { get; set; } = new List<Animal>();
        /// <summary>
        /// Lista delle gabbie presenti nello zoo
        /// </summary>
        public List<Cage> Cages { get; set; } = new List<Cage>();
        /// <summary>
        /// Registro dei pasti degli animali
        /// </summary>
        public List<FoodLog> Meals { get; set; } = new List<FoodLog>();
    }
}
