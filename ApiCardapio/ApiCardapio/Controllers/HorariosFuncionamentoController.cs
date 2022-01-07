using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCardapio.Data;
using ApiCardapio.Models;
using System.Globalization;

namespace ApiCardapio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosFuncionamentoController : ControllerBase
    {
        private readonly Contexto _context;

        public HorariosFuncionamentoController(Contexto context)
        {
            _context = context;
        }

        // GET: api/HorariosFuncionamento
        [HttpGet("recuperarHorarioFuncionamento")]
        public async Task<ActionResult<IEnumerable<HorarioFuncionamento>>> GetHorariosFuncionamento()
        {
            return await _context.HorariosFuncionamento.Include(f => f.DiaFuncionamento).ThenInclude(f => f.Franquia).ToListAsync();
        }

        [HttpGet("recuperarHorarioFuncionamentoFranquia")]
        public async Task<ActionResult<IEnumerable<HorarioFuncionamento>>> GetHorariosFuncionamentoFranquia(int idFranquia)
        {
            return await _context.HorariosFuncionamento.Include(f => f.DiaFuncionamento).ThenInclude(f => f.Franquia).OrderBy(i => i.DiaFuncionamento.FranquiaId == idFranquia).ToListAsync();
        }

        // GET: api/HorariosFuncionamento/5
        [HttpGet("recuperarHorarioFuncionamentoId")]
        public async Task<ActionResult<HorarioFuncionamento>> GetHorarioFuncionamento(int id)
        {                
            var horarioFuncionamento = await _context.HorariosFuncionamento.Include(f => f.DiaFuncionamento).ThenInclude(f => f.Franquia).FirstOrDefaultAsync(i => i.Id == id);
           
            if (horarioFuncionamento == null)
            {
                return NotFound();
            }
            
            return horarioFuncionamento;
        }

        // PUT: api/HorariosFuncionamento/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("editarHorarioFuncionamento")]
        public async Task<IActionResult> PutHorarioFuncionamento(int id, HorarioFuncionamento horarioFuncionamento)
        {
            if (id != horarioFuncionamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(horarioFuncionamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HorarioFuncionamentoExists(id))
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

        // POST: api/HorariosFuncionamento
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("adicionarHorarioFuncionamento")]
        public async Task<ActionResult<HorarioFuncionamento>> PostHorarioFuncionamento(HorarioFuncionamento horarioFuncionamento)
        {
            _context.HorariosFuncionamento.Add(horarioFuncionamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHorarioFuncionamento", new { id = horarioFuncionamento.Id }, horarioFuncionamento);
        }

        // DELETE: api/HorariosFuncionamento/5
        [HttpDelete("excluirHorarioFuncionamento")]
        public async Task<IActionResult> DeleteHorarioFuncionamento(int id)
        {
            var horarioFuncionamento = await _context.HorariosFuncionamento.FindAsync(id);
            if (horarioFuncionamento == null)
            {
                return NotFound();
            }

            _context.HorariosFuncionamento.Remove(horarioFuncionamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HorarioFuncionamentoExists(int id)
        {
            return _context.HorariosFuncionamento.Any(e => e.Id == id);
        }
    }
}
