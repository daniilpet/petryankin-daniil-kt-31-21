using Microsoft.EntityFrameworkCore;
using petryankin_daniil_kt_31_21.Models;
using petryankin_daniil_kt_31_21.Filters.StudentFilters;

namespace petryankin_daniil_kt_31_21.Interfaces.StudentInterfaces
{
    public interface IStudentService
    {
        Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken);
    }

    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _dbContext;

        public StudentService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default)
        {
            var students = _dbContext.Set<Student>()
                .Where(w => w.Group.GroupName == filter.GroupName)
                .ToArrayAsync(cancellationToken);

            return students;
        }
    }
}
