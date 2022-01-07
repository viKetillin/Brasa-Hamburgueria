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
    public class ProdutoIngredientesController : ControllerBase
    {
        private readonly Contexto _context;

        public ProdutoIngredientesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/ProdutoIngredientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoIngrediente>>> GetProdutoIngredientes()
        {
            return await _context.ProdutoIngredientes.ToListAsync();
        }

        // GET: api/ProdutoIngredientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoIngrediente>> GetProdutoIngrediente(int id)
        {
            var produtoIngrediente = await _context.ProdutoIngredientes.FindAsync(id);

            if (produtoIngrediente == null)
            {
                return NotFound();
            }

            return produtoIngrediente;
        }

        // PUT: api/ProdutoIngredientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdutoIngrediente(int id, ProdutoIngrediente produtoIngrediente)
        {
            if (id != produtoIngrediente.Id)
            {
                return BadRequest();
            }

            _context.Entry(produtoIngrediente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoIngredienteExists(id))
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

        // POST: api/ProdutoIngredientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProdutoIngrediente>> PostProdutoIngrediente(ProdutoIngrediente produtoIngrediente)
        {
            _context.ProdutoIngredientes.Add(produtoIngrediente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdutoIngrediente", new { id = produtoIngrediente.Id }, produtoIngrediente);
        }

        // DELETE: api/ProdutoIngredientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdutoIngrediente(int id)
        {
            var produtoIngrediente = await _context.ProdutoIngredientes.FindAsync(id);
            if (produtoIngrediente == null)
            {
                return NotFound();
            }

            _context.ProdutoIngredientes.Remove(produtoIngrediente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProdutoIngredienteExists(int id)
        {
            return _context.ProdutoIngredientes.Any(e => e.Id == id);
        }
    }
}
