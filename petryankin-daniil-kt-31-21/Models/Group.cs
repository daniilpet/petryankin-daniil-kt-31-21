using System.Text.RegularExpressions;

namespace petryankin_daniil_kt_31_21.Models
{
    public class Group
    {
        // Идентификатор группы
        public int GroupId { get; set; }

        // Название группы
        public required string GroupName { get; set; }

        public bool IsValidGroupName()
        {
            return Regex.Match(GroupName, @"\D*-?\d*-?\d\d").Success;
        }
    }
}
