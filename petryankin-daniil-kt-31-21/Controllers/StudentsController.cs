using Microsoft.AspNetCore.Mvc;
using petryankin_daniil_kt_31_21.Filters.StudentFilters;
using petryankin_daniil_kt_31_21.Interfaces.StudentInterfaces;
using System.Threading;
using System.Threading.Tasks;

namespace petryankin_daniil_kt_31_21.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentService _studentService;

        public StudentsController(ILogger<StudentsController> logger, IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        // Получение студентов по группе
        [HttpPost("ByGroup", Name = "GetStudentsByGroup")]
        public async Task<IActionResult> GetStudentsByGroupAsync([FromBody] StudentGroupFilter filter, CancellationToken cancellationToken)
        {
            var students = await _studentService.GetStudentsByGroupAsync(filter, cancellationToken);

            return Ok(students);
        }

        // Получение студентов по ФИО
        [HttpPost("ByFullName", Name = "GetStudentsByFullName")]
        public async Task<IActionResult> GetStudentsByFullNameAsync([FromBody] StudentFullNameFilter filter, CancellationToken cancellationToken)
        {
            var students = await _studentService.GetStudentsByFullNameAsync(filter, cancellationToken);

            return Ok(students);
        }

        // Получение студентов по статусу удаления
        [HttpPost("ByIsDeleted", Name = "GetStudentsByIsDeleted")]
        public async Task<IActionResult> GetStudentsByIsDeletedAsync([FromBody] StudentIsDeletedFilter filter, CancellationToken cancellationToken)
        {
            var students = await _studentService.GetStudentsByIsDeletedAsync(filter, cancellationToken);

            return Ok(students);
        }
    }
}
