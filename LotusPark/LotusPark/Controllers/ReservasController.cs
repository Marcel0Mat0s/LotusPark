using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LotusPark.Data;
using LotusPark.Models;

namespace LotusPark.Controllers
{
    public class ReservasController : Controller
    {
        private readonly ApplicationDbContext _bd;

        public ReservasController(ApplicationDbContext context)
        {
            _bd = context;
        }

        // GET: Reservas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _bd.Reservas.Include(r => r.Cliente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reservas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _bd.Reservas == null)
            {
                return NotFound();
            }

            /* procurarm, na base de dados, a raserva com ID igual ao parâmetro fornecido
             * SELECT *
             * 
             * 
             */
            var reserva = await _bd.Reservas
                .Include(r => r.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: Reservas/Create
        /// <summary>
        /// Criar as condições para a View de criação de uma reserva
        /// ser enviada para o browser
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            // prepara os dados a serem apresentados na dropwdown
            ViewData["ClienteFK"] = new SelectList(_bd.Clientes, "Id", "Nome");

            // invoca a view
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataEntrada,DataSaida,Estado,ClienteFK")] Reservas reservas)
        {
            if (ModelState.IsValid)
            {
                _bd.Add(reservas);
                await _bd.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteFK"] = new SelectList(_bd.Clientes, "Id", "Nome");
            return View(reservas);
        }

        // GET: Reservas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _bd.Reservas == null)
            {
                return NotFound();
            }

            var reservas = await _bd.Reservas.FindAsync(id);
            if (reservas == null)
            {
                return NotFound();
            }
            ViewData["ClienteFK"] = new SelectList(_bd.Clientes, "Id", "Id", reservas.ClienteFK);
            return View(reservas);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataEntrada,DataSaida,Estado,ClienteFK")] Reservas reservas)
        {
            if (id != reservas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _bd.Update(reservas);
                    await _bd.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservasExists(reservas.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteFK"] = new SelectList(_bd.Clientes, "Id", "Id", reservas.ClienteFK);
            return View(reservas);
        }

        // GET: Reservas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _bd.Reservas == null)
            {
                return NotFound();
            }

            var reservas = await _bd.Reservas
                .Include(r => r.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservas == null)
            {
                return NotFound();
            }

            return View(reservas);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_bd.Reservas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Reservas'  is null.");
            }
            var reservas = await _bd.Reservas.FindAsync(id);
            if (reservas != null)
            {
                _bd.Reservas.Remove(reservas);
            }
            
            await _bd.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservasExists(int id)
        {
          return (_bd.Reservas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
