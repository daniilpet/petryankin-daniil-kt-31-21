﻿using Microsoft.EntityFrameworkCore;
using petryankin_daniil_kt_31_21.Interfaces.StudentInterfaces;
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
            // Arrange
            var ctx = new StudentDbContext(_dbContextOptions);
            var studentService = new StudentService(ctx);
            var groups = new List<Group>
            {
                new Group
                {
                    GroupName = "KT-31-21"
                },
                new Group
                {
                    GroupName = "KT-41-21"
                }
            };
            await ctx.Set<Group>().AddRangeAsync(groups);

            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Hurupatov",
                    MiddleName = "Alexandrovich",
                    GroupId = 1,
                },
                new Student
                {
                    FirstName = "Maria",
                    LastName = "Egorova",
                    MiddleName = "Igorovna",
                    GroupId = 2,
                },
                new Student
                {
                    FirstName = "Igor",
                    LastName = "Alexandrov",
                    MiddleName = "Ivanovich",
                    GroupId = 1,
                }
            };
            await ctx.Set<Student>().AddRangeAsync(students);

            await ctx.SaveChangesAsync();

            // Act
            var filter = new Filters.StudentFilters.StudentGroupFilter
            {
                GroupName = "KT-31-21"
            };
            var studentsResult = await studentService.GetStudentsByGroupAsync(filter, CancellationToken.None);

            // Assert
            Assert.Equal(2, studentsResult.Length);

        }
    }
}
