using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projecto_Esw.Data;
using Projecto_Esw.Models;

namespace Projecto_Esw.Controllers
{
    public class ReservaIdaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservaIdaController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ReservaIda
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ReservaIda.Include(r => r.Companhia).Include(r => r.TipoJato);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ReservaIda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservaIda = await _context.ReservaIda.SingleOrDefaultAsync(m => m.ReservaIdaId == id);
            if (reservaIda == null)
            {
                return NotFound();
            }

            return View(reservaIda);
        }

        // GET: ReservaIda/Create
        public IActionResult Create()
        {
            ViewData["CompanhiaId"] = new SelectList(_context.Companhia, "CompanhiaId", "Nome");
            ViewData["TipoJatoId"] = new SelectList(_context.Tipojato, "TipoJatoId", "Nome");
            return View();
        }

        // POST: ReservaIda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservaIdaId,CompanhiaId,DataPartida,Destino,HoraPartida,NumeroPessoas,Origem,TipoJatoId")] ReservaIda reservaIda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservaIda);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CompanhiaId"] = new SelectList(_context.Companhia, "CompanhiaId", "Nome", reservaIda.CompanhiaId);
            ViewData["TipoJatoId"] = new SelectList(_context.Tipojato, "TipoJatoId", "Nome", reservaIda.TipoJatoId);
            return View(reservaIda);
        }

        // GET: ReservaIda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservaIda = await _context.ReservaIda.SingleOrDefaultAsync(m => m.ReservaIdaId == id);
            if (reservaIda == null)
            {
                return NotFound();
            }
            ViewData["CompanhiaId"] = new SelectList(_context.Companhia, "CompanhiaId", "Nome", reservaIda.CompanhiaId);
            ViewData["TipoJatoId"] = new SelectList(_context.Tipojato, "TipoJatoId", "Nome", reservaIda.TipoJatoId);
            return View(reservaIda);
        }

        // POST: ReservaIda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservaIdaId,CompanhiaId,DataPartida,Destino,HoraPartida,NumeroPessoas,Origem,TipoJatoId")] ReservaIda reservaIda)
        {
            if (id != reservaIda.ReservaIdaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservaIda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaIdaExists(reservaIda.ReservaIdaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["CompanhiaId"] = new SelectList(_context.Companhia, "CompanhiaId", "Nome", reservaIda.CompanhiaId);
            ViewData["TipoJatoId"] = new SelectList(_context.Tipojato, "TipoJatoId", "Nome", reservaIda.TipoJatoId);
            return View(reservaIda);
        }

        // GET: ReservaIda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservaIda = await _context.ReservaIda.SingleOrDefaultAsync(m => m.ReservaIdaId == id);
            if (reservaIda == null)
            {
                return NotFound();
            }

            return View(reservaIda);
        }

        // POST: ReservaIda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservaIda = await _context.ReservaIda.SingleOrDefaultAsync(m => m.ReservaIdaId == id);
            _context.ReservaIda.Remove(reservaIda);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ReservaIdaExists(int id)
        {
            return _context.ReservaIda.Any(e => e.ReservaIdaId == id);
        }
    }
}
