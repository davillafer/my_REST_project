using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS.Proyecto.Mapa.WebAPI.Data;
using WS.Proyecto.Mapa.WebAPI.Model;

namespace WS.Proyecto.Mapa.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetitionsController : ControllerBase
    {
        private readonly DataContext _context;

        public PetitionsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Petitions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Petition>>> GetPetitions()
        {
            return await _context.Petitions.ToListAsync();
        }

        // GET: api/Petitions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Petition>> GetPetition(long id)
        {
            var petition = await _context.Petitions.FindAsync(id);

            if (petition == null)
            {
                return NotFound();
            }

            return petition;
        }

        // PUT: api/Petitions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPetition(long id, Petition petition)
        {
            if (id != petition.Id)
            {
                return BadRequest();
            }

            _context.Entry(petition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetitionExists(id))
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

        // POST: api/Petitions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Petition>> PostPetition(Petition petition)
        {
            _context.Petitions.Add(petition);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPetition", new { id = petition.Id }, petition);
        }

        // DELETE: api/Petitions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Petition>> DeletePetition(long id)
        {
            var petition = await _context.Petitions.FindAsync(id);
            if (petition == null)
            {
                return NotFound();
            }

            _context.Petitions.Remove(petition);
            await _context.SaveChangesAsync();

            return petition;
        }

        private bool PetitionExists(long id)
        {
            return _context.Petitions.Any(e => e.Id == id);
        }
    }
}
