using System.Text.RegularExpressions;

namespace petryankin_daniil_kt_31_21.Models
{
    public class Discipline
    {
        // ������������� ����������
        public int DisciplineId { get; set; }

        // ��� ����������
        public required string DisciplineName { get; set; }

        // ��� ����������
        public required string DisciplineCode { get; set; }
    }
}