using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FACLSchichtbericht.Models;

namespace FACLSchichtbericht.Controllers
{
    public class ActiontrackerController : Controller
    {
        private readonly FACL_DB_DevContext _context;

        public ActiontrackerController(FACL_DB_DevContext context)
        {
            _context = context;
        }

        //############################Production#########################
        //private readonly FACL_DB_ProductionContext _context;

        //public ActiontrackerController(FACL_DB_ProductionContext context)
        //{
        //    _context = context;
        //}


        // GET: Actiontracker
        public async Task<IActionResult> Index()
        {
            return View(await _context.Actiontracker.ToListAsync());
        }

        // GET: Actiontracker/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actiontrackerModel = await _context.Actiontracker
                .FirstOrDefaultAsync(m => m.ID == id);
            if (actiontrackerModel == null)
            {
                return NotFound();
            }

            return View(actiontrackerModel);
        }

        // GET: Actiontracker/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actiontracker/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserName,Datum,Von,Bis,Action,Priorität,Bereich,Beschreibung,Maßnahme,erstelltam,erstelltvon,zuletztbearbeitetam,zuletztbearbeitetvon,BerichtBD420_ID,BerichtBD451_ID,BerichtBU320_ID,BerichtBU420_ID,Overview_ID")] ActiontrackerModel actiontrackerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actiontrackerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actiontrackerModel);
        }

        // GET: Actiontracker/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actiontrackerModel = await _context.Actiontracker.FindAsync(id);
            if (actiontrackerModel == null)
            {
                return NotFound();
            }
            return View(actiontrackerModel);
        }

        // POST: Actiontracker/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserName,Datum,Von,Bis,Action,Priorität,Bereich,Beschreibung,Maßnahme,erstelltam,erstelltvon,zuletztbearbeitetam,zuletztbearbeitetvon,BerichtBD420_ID,BerichtBD451_ID,BerichtBU320_ID,BerichtBU420_ID,Overview_ID")] ActiontrackerModel actiontrackerModel)
        {
            if (id != actiontrackerModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actiontrackerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActiontrackerModelExists(actiontrackerModel.ID))
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
            return View(actiontrackerModel);
        }

        // GET: Actiontracker/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actiontrackerModel = await _context.Actiontracker
                .FirstOrDefaultAsync(m => m.ID == id);
            if (actiontrackerModel == null)
            {
                return NotFound();
            }

            return View(actiontrackerModel);
        }

        // POST: Actiontracker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actiontrackerModel = await _context.Actiontracker.FindAsync(id);
            _context.Actiontracker.Remove(actiontrackerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActiontrackerModelExists(int id)
        {
            return _context.Actiontracker.Any(e => e.ID == id);
        }
    }
}
