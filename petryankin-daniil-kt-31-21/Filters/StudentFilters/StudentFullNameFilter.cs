namespace petryankin_daniil_kt_31_21.Filters.StudentFilters
{
    public class StudentFullNameFilter
    {
        // ��� ��������
        public required string FirstName { get; set; }

        // ������� ��������
        public required string LastName { get; set; }

        // �������� ��������
        public string? MiddleName { get; set; }
    }
}
