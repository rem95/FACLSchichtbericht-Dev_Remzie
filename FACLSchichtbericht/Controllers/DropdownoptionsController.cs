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
    public class DropdownoptionsController : Controller
    {
        private readonly FACL_DB_DevContext _context;

        public DropdownoptionsController(FACL_DB_DevContext context)
        {
            _context = context;
        }

        //#############PRODUCTION###############

        //private readonly FACL_DB_ProductionContext _context;

        //public DropdownoptionsController(FACL_DB_ProductionContext context)
        //{
        //    _context = context;
        //}


        // GET: Dropdownoptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dropdownoptions.ToListAsync());
        }

        // GET: Dropdownoptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dropdownoptionsModel = await _context.Dropdownoptions
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dropdownoptionsModel == null)
            {
                return NotFound();
            }

            return View(dropdownoptionsModel);
        }

        // GET: Dropdownoptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dropdownoptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,value,Selectbezeichnung,Optionbezeichnung")] DropdownoptionsModel dropdownoptionsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dropdownoptionsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dropdownoptionsModel);
        }

        // GET: Dropdownoptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dropdownoptionsModel = await _context.Dropdownoptions.FindAsync(id);
            if (dropdownoptionsModel == null)
            {
                return NotFound();
            }
            return View(dropdownoptionsModel);
        }

        // POST: Dropdownoptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,value,Selectbezeichnung,Optionbezeichnung")] DropdownoptionsModel dropdownoptionsModel)
        {
            if (id != dropdownoptionsModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dropdownoptionsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DropdownoptionsModelExists(dropdownoptionsModel.ID))
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
            return View(dropdownoptionsModel);
        }

        // GET: Dropdownoptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dropdownoptionsModel = await _context.Dropdownoptions
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dropdownoptionsModel == null)
            {
                return NotFound();
            }

            return View(dropdownoptionsModel);
        }

        // POST: Dropdownoptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dropdownoptionsModel = await _context.Dropdownoptions.FindAsync(id);
            _context.Dropdownoptions.Remove(dropdownoptionsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DropdownoptionsModelExists(int id)
        {
            return _context.Dropdownoptions.Any(e => e.ID == id);
        }
    }
}
