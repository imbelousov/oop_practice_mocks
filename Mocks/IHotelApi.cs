using System;
using System.Collections.Generic;

namespace Mocks
{
    /// <summary>
    /// API ��� ������ � ���������� ������
    /// </summary>
    public interface IHotelApi
    {
        /// <summary>
        /// ���������� �� �����, � ������� �������� API
        /// </summary>
        Hotel Hotel { get; }

        /// <summary>
        /// ���������� ������ ���� ��������� � ����� �������
        /// </summary>
        List<Room> GetRooms();

        /// <summary>
        /// ��������� ����������� ������ ���������� ������ �� ��������� ����
        /// </summary>
        /// <param name="roomClass">����� ������</param>
        /// <param name="date">����</param>
        /// <returns>������� ����������� ������ ��� ������������</returns>
        bool CheckAvailability(string roomClass, DateTime date);

        /// <summary>
        /// ���������� � ����� ������ �� ������������ ������
        /// </summary>
        /// <param name="roomClass">����� ������</param>
        /// <param name="arrivalDate">���� ���������</param>
        /// <param name="departureDate">���� ���������</param>
        /// <param name="persons">���������� ������</param>
        void Reserve(string roomClass, DateTime arrivalDate, DateTime departureDate, int persons);
    }
}
