using Microsoft.AspNetCore.Mvc;
using petryankin_daniil_kt_31_21.Interfaces.DisciplineInterfaces;
using petryankin_daniil_kt_31_21.Models;
using System.Threading;
using System.Threading.Tasks;

namespace petryankin_daniil_kt_31_21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinesController : ControllerBase
    {
        private readonly IDisciplineService _disciplineService;

        public DisciplinesController(IDisciplineService disciplineService)
        {
            _disciplineService = disciplineService;
        }

        // GET: api/Disciplines
        [HttpGet]
        public async Task<ActionResult<Discipline[]>> GetDisciplines(CancellationToken cancellationToken)
        {
            var disciplines = await _disciplineService.GetDisciplinesAsync(cancellationToken);
            return Ok(disciplines);
        }

        // GET: api/Disciplines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Discipline>> GetDiscipline(int id, CancellationToken cancellationToken)
        {
            var discipline = await _disciplineService.GetDisciplineByIdAsync(id, cancellationToken);

            if (discipline == null)
            {
                return NotFound();
            }

            return Ok(discipline);
        }

        // POST: api/Disciplines
        [HttpPost]
        public async Task<ActionResult<Discipline>> PostDiscipline([FromBody] Discipline discipline, CancellationToken cancellationToken)
        {
            await _disciplineService.AddDisciplineAsync(discipline, cancellationToken);

            return CreatedAtAction(nameof(GetDiscipline), new { id = discipline.DisciplineId }, discipline);
        }

        // PUT: api/Disciplines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiscipline(int id, [FromBody] Discipline discipline, CancellationToken cancellationToken)
        {
            if (id != discipline.DisciplineId)
            {
                return BadRequest("ID in route and in body do not match");
            }

            var existingDiscipline = await _disciplineService.GetDisciplineByIdAsync(id, cancellationToken);
            if (existingDiscipline == null)
            {
                return NotFound();
            }

            await _disciplineService.UpdateDisciplineAsync(discipline, cancellationToken);

            return NoContent();
        }

        // DELETE: api/Disciplines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscipline(int id, CancellationToken cancellationToken)
        {
            var discipline = await _disciplineService.GetDisciplineByIdAsync(id, cancellationToken);
            if (discipline == null)
            {
                return NotFound();
            }

            await _disciplineService.DeleteDisciplineAsync(discipline, cancellationToken);

            return NoContent();
        }
    }
}
