﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AGEXPORTBACKEND.Data;
using AGEXPORTBACKEND.Models;

namespace AGEXPORTBACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly AGEXPORTBACKENDContext _context;

        public EmpleadosController(AGEXPORTBACKENDContext context)
        {
            _context = context;
        }

        // GET: api/Empleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleado()
        {
            return await _context.Empleado.ToListAsync();
        }

        // GET: api/Empleados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleado(int id)
        {
            var empleado = await _context.Empleado.FindAsync(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return empleado;
        }

        // PUT: api/Empleados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleado(int id, Empleado empleado)
        {
            if (id != empleado.Id)
            {
                return BadRequest();
            }

            _context.Entry(empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoExists(id))
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

        // POST: api/Empleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empleado>> PostEmpleado(Empleado empleado)
        {
            _context.Empleado.Add(empleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleado", new { id = empleado.Id }, empleado);
        }

        // DELETE: api/Empleados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleado(int id)
        {
            var empleado = await _context.Empleado.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            _context.Empleado.Remove(empleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleado.Any(e => e.Id == id);
        }
    }
}
