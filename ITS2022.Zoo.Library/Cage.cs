namespace ITS2022.Zoo.Library
{
    /// <summary>
    /// Gabbie dello zoo
    /// </summary>
    public class Cage
    {
        /// <summary>
        /// Id riconoscitivo
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Nome della gabbia
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Lista degi animali che vivono in questa gabbia. Lista degli identificativi.
        /// </summary>
        public List<string> Animals { get; set; } = new List<string>();
    }
}
