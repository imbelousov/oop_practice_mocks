namespace Mocks
{
    /// <summary>
    /// Информация об отеле
    /// </summary>
    public record Hotel
    {
        /// <summary>
        /// Название отеля
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес отеля
        /// </summary>
        public string Address { get; set; }
    }
}
