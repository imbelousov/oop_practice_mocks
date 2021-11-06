namespace Mocks
{
    /// <summary>
    /// ���������� � ������ � �����
    /// </summary>
    public record Room
    {
        /// <summary>
        /// ����� ������
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// ������������ ����� ������, ������� ����� ��������� � ������
        /// </summary>
        public int Persons { get; set; }

        /// <summary>
        /// ��������� ���������� �� �����
        /// </summary>
        public decimal Cost { get; set; }
    }
}
