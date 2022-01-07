using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCardapio.Data;
using ApiCardapio.Models;

namespace ApiCardapio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FranquiasController : ControllerBase
    {
        private readonly Contexto _context;

        public FranquiasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Franquias
        [HttpGet("recuperarFranquias")]
        public async Task<ActionResult<IEnumerable<Franquia>>> GetFranquias()
        {
            return await _context.Franquias.ToListAsync();
        }

        // GET: api/Franquias/5
        [HttpGet("recuperarFranquia")]
        public async Task<ActionResult<Franquia>> GetFranquia(int id)
        {
            var franquia = await _context.Franquias.FindAsync(id);

            if (franquia == null)
            {
                return NotFound();
            }

            return franquia;
        }

        // PUT: api/Franquias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("editarFranquia")]
        public async Task<IActionResult> PutFranquia(int id, Franquia franquia)
        {
            if (id != franquia.Id)
            {
                return BadRequest();
            }

            _context.Entry(franquia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FranquiaExists(id))
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

        // POST: api/Franquias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("adicionarFranquia")]
        public async Task<ActionResult<Franquia>> PostFranquia(Franquia franquia)
        {
            _context.Franquias.Add(franquia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFranquia", new { id = franquia.Id }, franquia);
        }

        // DELETE: api/Franquias/5
        [HttpDelete("excluirFranquia")]
        public async Task<IActionResult> DeleteFranquia(int id)
        {
            var franquia = await _context.Franquias.FindAsync(id);
            if (franquia == null)
            {
                return NotFound();
            }

            _context.Franquias.Remove(franquia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FranquiaExists(int id)
        {
            return _context.Franquias.Any(e => e.Id == id);
        }
    }
}
