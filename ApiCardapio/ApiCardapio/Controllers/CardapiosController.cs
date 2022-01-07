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
    public class ProdutoFranquiaController : ControllerBase
    {
        private readonly Contexto _context;

        public ProdutoFranquiaController(Contexto context)
        {
            _context = context;
        }

        // GET: api/ProdutoFranquia
        [HttpGet("recuperarCardapioFranquia")]
        public async Task<ActionResult<IEnumerable<ProdutoFranquia>>> GetCardapioFranquia(int idFranquia)
        {
            return await _context.ProdutoFranquias.Include(f => f.Franquia)
                                           .Include(f => f.Produto).ThenInclude(f => f.Categoria)
                                           .Where(f => f.FranquiaId == idFranquia).ToListAsync();       
        }

        [HttpGet("recuperarProdutoFranquia")]
        public async Task<ActionResult<IEnumerable<ProdutoFranquia>>> GetProdutoFranquia()
        {
            return await _context.ProdutoFranquias.Include(f => f.Franquia)
                                           .Include(f => f.Produto).ThenInclude(f => f.Categoria)
                                           .ToListAsync();

        }

        [HttpGet("recuperarAdicionais")]
        public async Task<ActionResult<IEnumerable<ProdutoFranquia>>> GetAdicionais(int idFranquia)
        {
            return await _context.ProdutoFranquias.Include(f => f.Franquia)
                                           .Include(f => f.Produto).ThenInclude(f => f.Categoria)
                                           .Where(f => f.Produto.CategoriaId == 2 && f.FranquiaId == idFranquia)
                                           .OrderBy(f => (f.Produto.NomeProduto).Trim())
                                           .ToListAsync();
        }

        // GET: api/ProdutoFranquia/5
        [HttpGet("recuperarCardapio")]
        public async Task<ActionResult<ProdutoFranquia>> GetCardapio(int id)
        {
            var cardapio = await _context.ProdutoFranquias.FindAsync(id);

            if (cardapio == null)
            {
                return NotFound();
            }

            return cardapio;
        }

        [HttpGet("recuperarProdutoId")]
        public async Task<ActionResult<ProdutoFranquia>> GetProduto(int idProduto)
        {
            var cardapio = await _context.ProdutoFranquias.Include(f => f.Produto).ThenInclude(f => f.ProdutoIngredientes).ThenInclude(f => f.Ingrediente)
                                                          //.Include(f => f.Produto).ThenInclude(f => f.ProdutoIngredientes)
                                                          .Where(f => f.Id == idProduto).SingleOrDefaultAsync();

            if (cardapio == null)
            {
                return NotFound();
            }

            return cardapio;
        }

        // PUT: api/ProdutoFranquia/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("editarCardapio")]
        public async Task<IActionResult> PutCardapio(int id, ProdutoFranquia cardapio)
        {
            if (id != cardapio.Id)
            {
                return BadRequest();
            }

            _context.Entry(cardapio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardapioExists(id))
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

        // POST: api/ProdutoFranquia
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("adicionarCardapio")]
        public async Task<ActionResult<ProdutoFranquia>> PostCardapio(ProdutoFranquia cardapio)
        {
            _context.ProdutoFranquias.Add(cardapio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCardapio", new { id = cardapio.Id }, cardapio);
        }

        // DELETE: api/ProdutoFranquia/5
        [HttpDelete("excluirCardapio")]
        public async Task<IActionResult> DeleteCardapio(int id)
        {
            var cardapio = await _context.ProdutoFranquias.FindAsync(id);
            if (cardapio == null)
            {
                return NotFound();
            }

            _context.ProdutoFranquias.Remove(cardapio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardapioExists(int id)
        {
            return _context.ProdutoFranquias.Any(e => e.Id == id);
        }
    }
}
