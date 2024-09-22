using System.Text.RegularExpressions;

namespace petryankin_daniil_kt_31_21.Models
{
    public class Student
    {
        // ������������� ��������
        public int StudentId { get; set; }

        // ��� ��������
        public required string FirstName { get; set; }

        // ������� ��������
        public required string LastName { get; set; }

        // �������� ��������
        public string? MiddleName { get; set; }

        // ������������� ������, � ������� ��������� �������
        public int GroupId { get; set; }

        // �������� �� �������� (�����������)
        public bool IsDeleted { get; set; }

        // ����� � �������� ������
        public Group? Group { get; set; }
    }
}