namespace petryankin_daniil_kt_31_21.Models
{
    public class Group
    {
        // Идентификатор группы
        public int GroupId { get; set; }

        // Название группы
        public required string GroupName { get; set; }

        public virtual List<Student>? Students { get; set; }
    }
}
