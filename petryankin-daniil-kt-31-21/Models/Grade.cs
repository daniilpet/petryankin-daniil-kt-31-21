using System;

namespace petryankin_daniil_kt_31_21.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public int StudentId { get; set; }
        public int DisciplineId { get; set; }
        public DateTime GradeDate { get; set; }
        public int GradeValue { get; set; }
        public required Discipline Discipline { get; set; }
    }
}
