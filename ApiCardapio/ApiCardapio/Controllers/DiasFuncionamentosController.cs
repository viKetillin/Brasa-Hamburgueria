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
    public class DiasFuncionamentosController : ControllerBase
    {
        private readonly Contexto _context;

        public DiasFuncionamentosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/DiasFuncionamentos
        [HttpGet("recuperarDiasFuncionamento")]
        public async Task<ActionResult<IEnumerable<DiaFuncionamento>>> GetDiasFuncionamento()
        {
            return await _context.DiasFuncionamento.Include(f => f.Franquia).ToListAsync();
        }

        // GET: api/DiasFuncionamentos/5
        [HttpGet("recuperarDiaFuncionamento")]
        public async Task<ActionResult<DiaFuncionamento>> GetDiaFuncionamento(int id)
        {
            var diaFuncionamento = await _context.DiasFuncionamento.FindAsync(id);

            if (diaFuncionamento == null)
            {
                return NotFound();
            }

            return diaFuncionamento;
        }

        // PUT: api/DiasFuncionamentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("editarDiasFuncionamento")]
        public async Task<IActionResult> PutDiaFuncionamento(int id, DiaFuncionamento diaFuncionamento)
        {
            if (id != diaFuncionamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(diaFuncionamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiaFuncionamentoExists(id))
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

        // POST: api/DiasFuncionamentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("adicionarDiasFuncionamento")]
        public async Task<ActionResult<DiaFuncionamento>> PostDiaFuncionamento(DiaFuncionamento diaFuncionamento)
        {
            _context.DiasFuncionamento.Add(diaFuncionamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDiaFuncionamento", new { id = diaFuncionamento.Id }, diaFuncionamento);
        }

        // DELETE: api/DiasFuncionamentos/5
        [HttpDelete("excluirDiaFuncionamento")]
        public async Task<IActionResult> DeleteDiaFuncionamento(int id)
        {
            var diaFuncionamento = await _context.DiasFuncionamento.FindAsync(id);
            if (diaFuncionamento == null)
            {
                return NotFound();
            }

            _context.DiasFuncionamento.Remove(diaFuncionamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DiaFuncionamentoExists(int id)
        {
            return _context.DiasFuncionamento.Any(e => e.Id == id);
        }
    }
}
