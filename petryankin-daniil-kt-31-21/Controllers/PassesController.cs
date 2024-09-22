using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using petryankin_daniil_kt_31_21;
using petryankin_daniil_kt_31_21.Models;

namespace petryankin_daniil_kt_31_21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassesController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public PassesController(StudentDbContext context)
        {
            _context = context;
        }

        // GET: api/Passes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pass>>> GetPasses()
        {
            return await _context.Passes.ToListAsync();
        }

        // GET: api/Passes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pass>> GetPass(int id)
        {
            var pass = await _context.Passes.FindAsync(id);

            if (pass == null)
            {
                return NotFound();
            }

            return pass;
        }

        // PUT: api/Passes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPass(int id, Pass pass)
        {
            if (id != pass.PassId)
            {
                return BadRequest();
            }

            _context.Entry(pass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Passes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pass>> PostPass(Pass pass)
        {
            _context.Passes.Add(pass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPass", new { id = pass.PassId }, pass);
        }

        // DELETE: api/Passes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePass(int id)
        {
            var pass = await _context.Passes.FindAsync(id);
            if (pass == null)
            {
                return NotFound();
            }

            _context.Passes.Remove(pass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PassExists(int id)
        {
            return _context.Passes.Any(e => e.PassId == id);
        }
    }
}
