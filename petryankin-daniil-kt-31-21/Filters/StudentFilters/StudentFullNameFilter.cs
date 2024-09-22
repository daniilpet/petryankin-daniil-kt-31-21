namespace petryankin_daniil_kt_31_21.Filters.StudentFilters
{
    public class StudentFullNameFilter
    {
        // Имя студента
        public required string FirstName { get; set; }

        // Фамилия студента
        public required string LastName { get; set; }

        // Отчество студента
        public string? MiddleName { get; set; }
    }
}
