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
    public class DestinoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DestinoController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Destino
        public async Task<IActionResult> Index()
        {
            return View(await _context.Destino.ToListAsync());
        }

        // GET: Destino/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destino = await _context.Destino.SingleOrDefaultAsync(m => m.DestinoId == id);
            if (destino == null)
            {
                return NotFound();
            }

            return View(destino);
        }

        // GET: Destino/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Destino/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DestinoId,Nome")] Destino destino)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destino);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(destino);
        }

        // GET: Destino/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destino = await _context.Destino.SingleOrDefaultAsync(m => m.DestinoId == id);
            if (destino == null)
            {
                return NotFound();
            }
            return View(destino);
        }

        // POST: Destino/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DestinoId,Nome")] Destino destino)
        {
            if (id != destino.DestinoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destino);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestinoExists(destino.DestinoId))
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
            return View(destino);
        }

        // GET: Destino/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destino = await _context.Destino.SingleOrDefaultAsync(m => m.DestinoId == id);
            if (destino == null)
            {
                return NotFound();
            }

            return View(destino);
        }

        // POST: Destino/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var destino = await _context.Destino.SingleOrDefaultAsync(m => m.DestinoId == id);
            _context.Destino.Remove(destino);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DestinoExists(int id)
        {
            return _context.Destino.Any(e => e.DestinoId == id);
        }
    }
}
