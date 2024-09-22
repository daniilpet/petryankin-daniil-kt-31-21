using System.Text.RegularExpressions;

namespace petryankin_daniil_kt_31_21.Models
{
    public class Discipline
    {
        // Идентификатор дисциплины
        public int DisciplineId { get; set; }

        // Имя дисциплины
        public required string DisciplineName { get; set; }

        // Код дисциплины
        public required string DisciplineCode { get; set; }
    }
}