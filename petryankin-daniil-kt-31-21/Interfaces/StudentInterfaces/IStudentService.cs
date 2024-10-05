using Microsoft.EntityFrameworkCore;
using petryankin_daniil_kt_31_21.Models;
using petryankin_daniil_kt_31_21.Filters.StudentFilters;

namespace petryankin_daniil_kt_31_21.Interfaces.StudentInterfaces
{
    public interface IStudentService
    {
        Task<Student[]> GetStudentsByIsDeletedAsync(StudentIsDeletedFilter filter, CancellationToken cancellationToken);
        Task<Student[]> GetStudentsByFullNameAsync(StudentFullNameFilter filter, CancellationToken cancellationToken);
        Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken);
    }

    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _dbContext;

        public StudentService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Student[]> GetStudentsByIsDeletedAsync(StudentIsDeletedFilter filter, CancellationToken cancellationToken = default)
        {
            var students = _dbContext.Set<Student>()
                .Where(w => w.IsDeleted == filter.IsDeleted)
                .ToArrayAsync(cancellationToken);

            return students;
        }

        public Task<Student[]> GetStudentsByFullNameAsync(StudentFullNameFilter filter, CancellationToken cancellationToken = default)
        {
            var students = _dbContext.Set<Student>()
                .Where(w => w.FirstName == filter.FirstName)
                .Where(w => w.LastName == filter.LastName)
                .Where(w => w.MiddleName == filter.MiddleName)
                .ToArrayAsync(cancellationToken);

            return students;
        }

        public async Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default)
        {
            var students = await _dbContext.Set<Student>()
                .Where(w => w.Group!.GroupName == filter.GroupName)
                .ToArrayAsync(cancellationToken);

            return students;
        }

    }
}
