namespace petryankin_daniil_kt_31_21.Models
{
    public class Group
    {
        // ������������� ������
        public int GroupId { get; set; }

        // �������� ������
        public required string GroupName { get; set; }

        public virtual List<Student>? Students { get; set; }
    }
}
