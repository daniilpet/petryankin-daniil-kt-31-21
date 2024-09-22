using System;

namespace petryankin_daniil_kt_31_21.Models
{
    public class Pass
    {
        public int PassId { get; set; }
        public int StudentId { get; set; }
        public int DisciplineId { get; set; }
        public DateTime PassDate { get; set; }
        public bool IsPassed { get; set; }
    }
}
