namespace Mocks
{
    /// <summary>
    /// Информация о номере в отеле
    /// </summary>
    public record Room
    {
        /// <summary>
        /// Класс номера
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Максимальное число гостей, которые могут проживать в номере
        /// </summary>
        public int Persons { get; set; }

        /// <summary>
        /// Стоимость проживания за сутки
        /// </summary>
        public decimal Cost { get; set; }
    }
}
