using Microsoft.EntityFrameworkCore;
using petryankin_daniil_kt_31_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petryankin_daniil_kt_31_21.Tests
{
    public class StudentIntegrationTests
    {
        public readonly DbContextOptions<StudentDbContext> _dbContextOptions;

        public StudentIntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<StudentDbContext>()
                .UseInMemoryDatabase(databaseName: "student_db")
                .Options;
        }

        [Fact]
        public async Task GetStudentsByGroupName_KT3121_TwoStudents()
        {
            var groupName = "KT-31-21";
            // Arrange
            using (var context = new StudentDbContext(_dbContextOptions))
            {
                // Добавляем студентов в in-memory базу данных
                context.Students.AddRange(
                    new Student { StudentId = 1, FirstName = "Ivan", LastName = "Ivanov", GroupId = 1, Group = new Group { GroupId = 1, GroupName = groupName } },
                    new Student { StudentId = 2, FirstName = "Petr", LastName = "Petrov", GroupId = 1, Group = new Group { GroupId = 1, GroupName = groupName } },
                    new Student { StudentId = 3, FirstName = "Olga", LastName = "Sidorova", GroupId = 2, Group = new Group { GroupId = 2, GroupName = groupName } }
                );
                await context.SaveChangesAsync();
            }

            // Act
            List<Student> result;
            using (var context = new StudentDbContext(_dbContextOptions))
            {
                // Выполняем запрос на получение студентов по имени группы
                result = await context.Students
                                      .Where(s => s.Group!.GroupName == groupName)
                                      .ToListAsync();
            }

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, s => s.FirstName == "Ivan" && s.LastName == "Ivanov");
            Assert.Contains(result, s => s.FirstName == "Petr" && s.LastName == "Petrov");
        }
    }
}
