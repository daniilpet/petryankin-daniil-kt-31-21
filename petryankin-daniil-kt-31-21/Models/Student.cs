using System.Text.RegularExpressions;

namespace petryankin_daniil_kt_31_21.Models
{
    public class Student
    {
        // Идентификатор студента
        public int StudentId { get; set; }

        // Имя студента
        public required string FirstName { get; set; }

        // Фамилия студента
        public required string LastName { get; set; }

        // Отчество студента
        public string? MiddleName { get; set; }

        // Идентификатор группы, к которой относится студент
        public int GroupId { get; set; }

        // Является ли удалённым (отчисленным)
        public bool IsDeleted { get; set; }

        // Связь с объектом группы
        public Group? Group { get; set; }
    }
}