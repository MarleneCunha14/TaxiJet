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
    public class HelpReservaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HelpReservaController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: HelpReserva
        public async Task<IActionResult> Index()
        {
            return View(await _context.HelpReserva.ToListAsync());
        }

        // GET: HelpReserva/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpReserva = await _context.HelpReserva.SingleOrDefaultAsync(m => m.HelpReservaId == id);
            if (helpReserva == null)
            {
                return NotFound();
            }

            return View(helpReserva);
        }

        // GET: HelpReserva/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HelpReserva/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HelpReservaId")] HelpReserva helpReserva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(helpReserva);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(helpReserva);
        }

        // GET: HelpReserva/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpReserva = await _context.HelpReserva.SingleOrDefaultAsync(m => m.HelpReservaId == id);
            if (helpReserva == null)
            {
                return NotFound();
            }
            return View(helpReserva);
        }

        // POST: HelpReserva/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HelpReservaId")] HelpReserva helpReserva)
        {
            if (id != helpReserva.HelpReservaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(helpReserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HelpReservaExists(helpReserva.HelpReservaId))
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
            return View(helpReserva);
        }

        // GET: HelpReserva/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpReserva = await _context.HelpReserva.SingleOrDefaultAsync(m => m.HelpReservaId == id);
            if (helpReserva == null)
            {
                return NotFound();
            }

            return View(helpReserva);
        }

        // POST: HelpReserva/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var helpReserva = await _context.HelpReserva.SingleOrDefaultAsync(m => m.HelpReservaId == id);
            _context.HelpReserva.Remove(helpReserva);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool HelpReservaExists(int id)
        {
            return _context.HelpReserva.Any(e => e.HelpReservaId == id);
        }
    }
}
