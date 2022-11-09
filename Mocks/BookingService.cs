using System;
using System.Collections.Generic;
using System.Linq;

namespace Mocks
{
    public class BookingService
    {
        private readonly Dictionary<Hotel, IHotelApi> hotelApis;

        public BookingService(IEnumerable<IHotelApi> hotelApis) => this.hotelApis = hotelApis.ToDictionary(x => x.Hotel);

        public Dictionary<Hotel, List<Room>> FindAvailableHotels(string address, DateTime arrivalDate, DateTime departureDate, int persons)
        {
            var hotels = new Dictionary<Hotel, List<Room>>();
            foreach (var hotelApi in hotelApis.Values.Where(x => x.Hotel.Address.StartsWith(address)))
            {
                var availableRooms = hotelApi.GetRooms()
                    .Where(x => x.Persons >= persons && IsAvailable(x, hotelApi, arrivalDate, departureDate))
                    .OrderBy(x => x.Cost)
                    .ToList();
                if (availableRooms.Any())
                    hotels[hotelApi.Hotel] = availableRooms;
            }
            return hotels;
        }

        public bool Reserve(Hotel hotel, RoomClass roomClass, DateTime arrivalDate, DateTime departureDate, int persons)
        {
            var hotelApi = FindApi(hotel);
            var room = hotelApi.GetRooms().FirstOrDefault(x => x.Class == roomClass && x.Persons >= persons);
            if (room == null || !IsAvailable(room, hotelApi, arrivalDate, departureDate))
                return false;
            hotelApi.Reserve(roomClass, arrivalDate, departureDate, persons);
            return true;
        }

        private bool IsAvailable(Room room, IHotelApi hotelApi, DateTime arrivalDate, DateTime departureDate) =>
            EnumerateDates(arrivalDate, departureDate).All(x => hotelApi.CheckAvailability(room.Class, x));

        private IEnumerable<DateTime> EnumerateDates(DateTime from, DateTime to)
        {
            while (from <= to)
            {
                yield return from;
                from = from.AddDays(1);
            }
        }

        private IHotelApi FindApi(Hotel hotel) => hotelApis.TryGetValue(hotel, out var hotelApi)
            ? hotelApi
            : throw new HotelNotFoundException(hotel);
    }

    public class HotelNotFoundException : Exception
    {
        public HotelNotFoundException(Hotel hotel)
            : base($"Hotel '{hotel.Name}' is not found")
        {
        }
    }
}
