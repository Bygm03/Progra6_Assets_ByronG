using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Progra6_Assets_ByronG.Models;

namespace Progra6_Assets_ByronG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepreciationsController : ControllerBase
    {
        private readonly Progra620241Context _context;

        public DepreciationsController(Progra620241Context context)
        {
            _context = context;
        }

        // GET: api/Depreciations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Depreciation>>> GetDepreciations()
        {
            return await _context.Depreciations.ToListAsync();
        }

        // GET: api/Depreciations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Depreciation>> GetDepreciation(int id)
        {
            var depreciation = await _context.Depreciations.FindAsync(id);

            if (depreciation == null)
            {
                return NotFound();
            }

            return depreciation;
        }

        // PUT: api/Depreciations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepreciation(int id, Depreciation depreciation)
        {
            if (id != depreciation.DepreciationId)
            {
                return BadRequest();
            }

            _context.Entry(depreciation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepreciationExists(id))
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

        // POST: api/Depreciations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Depreciation>> PostDepreciation(Depreciation depreciation)
        {
            _context.Depreciations.Add(depreciation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepreciation", new { id = depreciation.DepreciationId }, depreciation);
        }

        // DELETE: api/Depreciations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepreciation(int id)
        {
            var depreciation = await _context.Depreciations.FindAsync(id);
            if (depreciation == null)
            {
                return NotFound();
            }

            _context.Depreciations.Remove(depreciation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepreciationExists(int id)
        {
            return _context.Depreciations.Any(e => e.DepreciationId == id);
        }
    }
}
