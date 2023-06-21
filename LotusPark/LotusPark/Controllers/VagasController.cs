using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LotusPark.Data;
using LotusPark.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;

namespace LotusPark.Controllers
{
    [Authorize]
    public class VagasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VagasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vagas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Vagas.Include(v => v.Estado).Include(v => v.Reserva);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Vagas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }

            var vagas = await _context.Vagas
                .Include(v => v.Estado)
                .Include(v => v.Reserva)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vagas == null)
            {
                return NotFound();
            }

            return View(vagas);
        }

        // GET: Vagas/Create
        public IActionResult Create()
        {
            ViewData["EstadoFK"] = new SelectList(_context.Set<Estados>(), "Id", "Nome");
            ViewData["ReservaFK"] = new SelectList(_context.Reservas, "Id", "Id");
            return View();
        }

        // POST: Vagas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Numero,EstadoFK,ReservaFK")] Vagas vagas)
        {
            IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                try { 
                    _context.Add(vagas);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                } catch(Exception) {
                    ModelState.AddModelError("", "Ocorreu um erro com a criação da vaga "+vagas.Numero);
                }
                
            }
            ViewData["EstadoFK"] = new SelectList(_context.Set<Estados>(), "Id", "Nome", vagas.EstadoFK);
            ViewData["ReservaFK"] = new SelectList(_context.Reservas, "Id", "Id", vagas.ReservaFK);
            return View(vagas);
        }

        // GET: Vagas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }

            var vagas = await _context.Vagas.FindAsync(id);
            if (vagas == null)
            {
                return NotFound();
            }
            ViewData["EstadoFK"] = new SelectList(_context.Set<Estados>(), "Id", "Nome", vagas.EstadoFK);
            ViewData["ReservaFK"] = new SelectList(_context.Reservas, "Id", "Id", vagas.ReservaFK);
            return View(vagas);
        }

        // POST: Vagas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero,EstadoFK,ReservaFK")] Vagas vagas)
        {
            if (id != vagas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vagas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VagasExists(vagas.Id))
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
            ViewData["EstadoFK"] = new SelectList(_context.Set<Estados>(), "Id", "Nome", vagas.EstadoFK);
            ViewData["ReservaFK"] = new SelectList(_context.Reservas, "Id", "Id", vagas.ReservaFK);
            return View(vagas);
        }

        // GET: Vagas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }

            var vagas = await _context.Vagas
                .Include(v => v.Estado)
                .Include(v => v.Reserva)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vagas == null)
            {
                return NotFound();
            }

            return View(vagas);
        }

        // POST: Vagas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vagas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Vagas'  is null.");
            }
            var vagas = await _context.Vagas.FindAsync(id);
            if (vagas != null)
            {
                _context.Vagas.Remove(vagas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VagasExists(int id)
        {
          return (_context.Vagas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
