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
    public class ProdutosPedidosController : ControllerBase
    {
        private readonly Contexto _context;

        public ProdutosPedidosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/ProdutosPedidos
        [HttpGet("recuperarProdutosPedidos")]
        public async Task<ActionResult<IEnumerable<ProdutoPedido>>> GetProdutosPedidos()
        {
            return await _context.ProdutosPedidos.ToListAsync();
        }

        // GET: api/ProdutosPedidos/5
        [HttpGet("recuperarProdutoPedido")]
        public async Task<ActionResult<ProdutoPedido>> GetProdutoPedido(int id)
        {
            var produtoPedido = await _context.ProdutosPedidos.FindAsync(id);

            if (produtoPedido == null)
            {
                return NotFound();
            }

            return produtoPedido;
        }

        // PUT: api/ProdutosPedidos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("editarProdutoPedido")]
        public async Task<IActionResult> PutProdutoPedido(int id, ProdutoPedido produtoPedido)
        {
            if (id != produtoPedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(produtoPedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoPedidoExists(id))
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

        // POST: api/ProdutosPedidos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("adicionarProdutoPedido")]
        public async Task<ActionResult<ProdutoPedido>> PostProdutoPedido(ProdutoPedido produtoPedido)
        {
            _context.ProdutosPedidos.Add(produtoPedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdutoPedido", new { id = produtoPedido.Id }, produtoPedido);
        }

        // DELETE: api/ProdutosPedidos/5
        [HttpDelete("excluirProdutoPedido")]
        public async Task<IActionResult> DeleteProdutoPedido(int id)
        {
            var produtoPedido = await _context.ProdutosPedidos.FindAsync(id);
            if (produtoPedido == null)
            {
                return NotFound();
            }

            _context.ProdutosPedidos.Remove(produtoPedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProdutoPedidoExists(int id)
        {
            return _context.ProdutosPedidos.Any(e => e.Id == id);
        }
    }
}
