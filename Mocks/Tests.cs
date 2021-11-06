using System;
using System.Collections.Generic;
using FakeItEasy;
using Moq;
using NSubstitute;
using NUnit.Framework;

namespace Mocks
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            // Moq
            // var hotelApiMock = new Mock<IHotelApi>();
            // var service = new BookingService(new List<IHotelApi> {hotelApiMock.Object});

            // FakeItEasy
            // var hotelApiMock = A.Fake<IHotelApi>();
            // var service = new BookingService(new List<IHotelApi> {hotelApiMock});

            // NSubstitute
            // var hotelApiMock = Substitute.For<IHotelApi>();
            // var service = new BookingService(new List<IHotelApi> {hotelApiMock});

            // ...
        }
    }
}
