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
        /// Lista degli identificativi degli animali che vivono in questa gabbia.
        /// </summary>
        public List<string> Animals { get; set; } = new List<string>();
    }
}
