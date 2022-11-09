using System;
using System.Collections.Generic;

namespace Mocks
{
    /// <summary>
    /// API для работы с конкретным отелем
    /// </summary>
    public interface IHotelApi
    {
        /// <summary>
        /// Информация об отеле, с которым работает API
        /// </summary>
        Hotel Hotel { get; }

        /// <summary>
        /// Возвращает список всех имеющихся в отеле номеров
        /// </summary>
        List<Room> GetRooms();

        /// <summary>
        /// Проверяет доступность номера указанного класса на указанную дату
        /// </summary>
        /// <param name="roomClass">Класс номера</param>
        /// <param name="date">Дата</param>
        /// <returns>Признак доступности номера для бронирования</returns>
        bool CheckAvailability(RoomClass roomClass, DateTime date);

        /// <summary>
        /// Отправляет в отель заявку на бронирование номера
        /// </summary>
        /// <param name="roomClass">Класс номера</param>
        /// <param name="arrivalDate">Дата заселения</param>
        /// <param name="departureDate">Дата выселения</param>
        /// <param name="persons">Количество гостей</param>
        void Reserve(RoomClass roomClass, DateTime arrivalDate, DateTime departureDate, int persons);
    }
}
