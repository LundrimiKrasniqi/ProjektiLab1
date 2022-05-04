#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudTest2.Models;

namespace CrudTest2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlientiDatabasesController : ControllerBase
    {
        private readonly KlientiContext _context;

        public KlientiDatabasesController(KlientiContext context)
        {
            _context = context;
        }

        // GET: api/KlientiDatabases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KlientiDatabase>>> GetKlienti()
        {
            return await _context.Klienti.ToListAsync();
        }

        // GET: api/KlientiDatabases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KlientiDatabase>> GetKlientiDatabase(int id)
        {
            var klientiDatabase = await _context.Klienti.FindAsync(id);

            if (klientiDatabase == null)
            {
                return NotFound();
            }

            return klientiDatabase;
        }

        // PUT: api/KlientiDatabases/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKlientiDatabase(int id, KlientiDatabase klientiDatabase)
        {
           klientiDatabase.KlientiID = id;

            _context.Entry(klientiDatabase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KlientiDatabaseExists(id))
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

        // POST: api/KlientiDatabases
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KlientiDatabase>> PostKlientiDatabase(KlientiDatabase klientiDatabase)
        {
            _context.Klienti.Add(klientiDatabase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKlientiDatabase", new { id = klientiDatabase.KlientiID }, klientiDatabase);
        }

        // DELETE: api/KlientiDatabases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKlientiDatabase(int id)
        {
            var klientiDatabase = await _context.Klienti.FindAsync(id);
            if (klientiDatabase == null)
            {
                return NotFound();
            }

            _context.Klienti.Remove(klientiDatabase);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KlientiDatabaseExists(int id)
        {
            return _context.Klienti.Any(e => e.KlientiID == id);
        }
    }
}
