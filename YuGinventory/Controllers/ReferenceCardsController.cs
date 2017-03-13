using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YuGinventory.Models;

namespace YuGinventory.Controllers
{
    public class ReferenceCardsController : Controller
    {
        private readonly YuGinventoryContext _context;

        public ReferenceCardsController(YuGinventoryContext context)
        {
            _context = context;    
        }

        // GET: ReferenceCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReferenceCard.ToListAsync());
        }

        // GET: ReferenceCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceCard = await _context.ReferenceCard
                .SingleOrDefaultAsync(m => m.ID == id);
            if (referenceCard == null)
            {
                return NotFound();
            }

            return View(referenceCard);
        }

        // GET: ReferenceCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReferenceCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Type,Attack,Defense,Text,SetId")] ReferenceCard referenceCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(referenceCard);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referenceCard);
        }

        // GET: ReferenceCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceCard = await _context.ReferenceCard.SingleOrDefaultAsync(m => m.ID == id);
            if (referenceCard == null)
            {
                return NotFound();
            }
            return View(referenceCard);
        }

        // POST: ReferenceCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Type,Attack,Defense,Text,SetId")] ReferenceCard referenceCard)
        {
            if (id != referenceCard.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(referenceCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferenceCardExists(referenceCard.ID))
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
            return View(referenceCard);
        }

        // GET: ReferenceCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceCard = await _context.ReferenceCard
                .SingleOrDefaultAsync(m => m.ID == id);
            if (referenceCard == null)
            {
                return NotFound();
            }

            return View(referenceCard);
        }

        // POST: ReferenceCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var referenceCard = await _context.ReferenceCard.SingleOrDefaultAsync(m => m.ID == id);
            _context.ReferenceCard.Remove(referenceCard);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ReferenceCardExists(int id)
        {
            return _context.ReferenceCard.Any(e => e.ID == id);
        }
    }
}
