namespace petryankin_daniil_kt_31_21.Filters.StudentFilters
{
    public class StudentIsDeletedFilter
    {
        /// <summary>
        /// Статус удаления студента (true - удалён, false - не удалён).
        /// </summary>
        public bool? IsDeleted { get; set; }
    }
}
