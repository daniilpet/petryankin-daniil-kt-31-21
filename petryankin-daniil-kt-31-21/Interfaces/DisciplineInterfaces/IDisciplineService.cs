using Microsoft.EntityFrameworkCore;
using petryankin_daniil_kt_31_21.Models;
using System.Threading;
using System.Threading.Tasks;

namespace petryankin_daniil_kt_31_21.Interfaces.DisciplineInterfaces
{
    public interface IDisciplineService
    {
        Task<Discipline[]> GetDisciplinesAsync(CancellationToken cancellationToken);
        Task<Discipline> GetDisciplineByIdAsync(int id, CancellationToken cancellationToken);
        Task AddDisciplineAsync(Discipline discipline, CancellationToken cancellationToken);
        Task UpdateDisciplineAsync(Discipline discipline, CancellationToken cancellationToken);
        Task DeleteDisciplineAsync(Discipline discipline, CancellationToken cancellationToken);
    }

    public class DisciplineService : IDisciplineService
    {
        private readonly StudentDbContext _dbContext;

        public DisciplineService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Discipline[]> GetDisciplinesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Disciplines
                                   .ToArrayAsync(cancellationToken);
        }

        public async Task<Discipline?> GetDisciplineByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Disciplines
                                   .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task AddDisciplineAsync(Discipline discipline, CancellationToken cancellationToken = default)
        {
            _dbContext.Disciplines.Add(discipline);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateDisciplineAsync(Discipline discipline, CancellationToken cancellationToken = default)
        {
            _dbContext.Entry(discipline).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteDisciplineAsync(Discipline discipline, CancellationToken cancellationToken = default)
        {
            // Пока не знаю как это сделать правильно, но сделаю потом
        }
    }
}
