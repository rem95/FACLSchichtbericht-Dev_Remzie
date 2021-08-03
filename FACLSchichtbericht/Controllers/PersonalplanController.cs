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
    public class PersonalplanController : Controller
    {
        private readonly FACL_DB_DevContext _context;

        public PersonalplanController(FACL_DB_DevContext context)
        {
            _context = context;
        }

        //#####################PRODUCTION############################
        //private readonly FACL_DB_ProductionContext _context;

        //public PersonalplanController(FACL_DB_ProductionContext context)
        //{
        //    _context = context;
        //}


        // GET: Personalplan
        public async Task<IActionResult> Index()
        {
            return View(await _context.Personalplan.ToListAsync());
        }

        // GET: Personalplan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalplanModel = await _context.Personalplan
                .FirstOrDefaultAsync(m => m.ID == id);
            if (personalplanModel == null)
            {
                return NotFound();
            }

            return View(personalplanModel);
        }

        // GET: Personalplan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personalplan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,PK,Nachname,Vorname,Gewerk,Jobtitel,Einsatzals,AG,Brandschutzhelfer,Ersthelfer,anwesend,mehrarbeitgenehmight,Bemerkung,erstelltam,erstelltvon,zuletztbearbeitetam,zuletztbearbeitetvon,BerichtBD420_ID,BerichtBD451_ID,BerichtBU320_ID,BerichtBU420_ID,datumgeplant,schichttyp")] PersonalplanModel personalplanModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalplanModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personalplanModel);
        }

        // GET: Personalplan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalplanModel = await _context.Personalplan.FindAsync(id);
            if (personalplanModel == null)
            {
                return NotFound();
            }
            return View(personalplanModel);
        }

        // POST: Personalplan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,PK,Nachname,Vorname,Gewerk,Jobtitel,Einsatzals,AG,Brandschutzhelfer,Ersthelfer,anwesend,mehrarbeitgenehmight,Bemerkung,erstelltam,erstelltvon,zuletztbearbeitetam,zuletztbearbeitetvon,BerichtBD420_ID,BerichtBD451_ID,BerichtBU320_ID,BerichtBU420_ID,datumgeplant,schichttyp")] PersonalplanModel personalplanModel)
        {
            if (id != personalplanModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalplanModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalplanModelExists(personalplanModel.ID))
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
            return View(personalplanModel);
        }

        // GET: Personalplan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalplanModel = await _context.Personalplan
                .FirstOrDefaultAsync(m => m.ID == id);
            if (personalplanModel == null)
            {
                return NotFound();
            }

            return View(personalplanModel);
        }

        // POST: Personalplan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalplanModel = await _context.Personalplan.FindAsync(id);
            _context.Personalplan.Remove(personalplanModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalplanModelExists(int id)
        {
            return _context.Personalplan.Any(e => e.ID == id);
        }
    }
}
