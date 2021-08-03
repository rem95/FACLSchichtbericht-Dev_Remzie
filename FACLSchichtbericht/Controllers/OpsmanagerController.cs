using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FACLSchichtbericht.Models;
using Microsoft.EntityFrameworkCore;

using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace FACLSchichtbericht.Controllers
{
    public class OpsmanagerController : Controller
    {

        [Obsolete]
        public IHostingEnvironment hostingEnv;



        private readonly FACL_DB_DevContext _context;

        [Obsolete]
        public OpsmanagerController(FACL_DB_DevContext context, IHostingEnvironment env)
        {
            _context = context;
            hostingEnv = env;
        }

        // ##################PRODUCTION###########################
        //private readonly FACL_DB_ProductionContext _context;

        //[Obsolete]

        //public OpsmanagerController(FACL_DB_ProductionContext context, IHostingEnvironment env)
        //{
        //    _context = context;
        //    hostingEnv = env;
        //}


        public IActionResult Index()
        {
            return View();
        }

        //GET: Personalplan 
        public async Task<ActionResult> IndexPersonalplan()
        {
            return View(await _context.Personalplan.Where(p => p.istabgeschlossen != "false").ToListAsync());
           
        }

        //GET: ImportPersonaplan
        public IActionResult ImportPersonalplan()
        {
            return View();
        }

        // POST Import personalplan
        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> ImportPersonalplan(IList<IFormFile> files, String jsonString)
        {
            // Variableninitialisierung
            long size = 0;
            DateTime outObjectdate = DateTime.ParseExact(jsonString, "yyyy-MM-dd", CultureInfo.CurrentCulture);
            List<PersonalplanModel> list = new List<PersonalplanModel>();
            String[][] lines = null;
            DateTime aDate = DateTime.Now;
            String hochgelades_Datum = jsonString.Substring(5, 2) + "." + jsonString.Substring(5, 2) + "." + jsonString.Substring(0, 4);

            var filename = "";
            //unbearbeitet Personalplaneinträge vorher löschen
            try
            {
                var personalplans = _context.Personalplan.Where(x => x.istabgeschlossen == null && x.istabgeschlossen != "true").ToList(); ;
                // Use Remove Range function to delete all records at once
                _context.Personalplan.RemoveRange(personalplans);
                // Save changes
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return Json(error.ToString());
            }


            foreach (var file in files)
            {
                // Web verzeichnis aufrufen
                filename = ContentDispositionHeaderValue
                                .Parse(file.ContentDisposition)
                                .FileName
                                .Trim('"');

                filename = hostingEnv.WebRootPath + $@"\Storage\{filename}";
                size += file.Length;

                Console.WriteLine("Dateigroesse " + size);

                /// in Web Verzeichnis speichern
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                    fs.Close();
                }


                try
                {
                    StreamReader reader = new StreamReader(filename, Encoding.GetEncoding(28591), true); // 28591 UTF Kodierung
                    String datastream = reader.ReadToEnd();


                    lines = datastream.Split('\n')         // Zeilenweise trennen
                                .Select(p => p.Split(';')) // nach Semikolon trennen
                                .ToArray();

                    for (int i = 0; i < lines.Length - 1; i++)
                    {
                        if (i == 0)  // erste Zeile ueberspringen
                        { }
                        else
                        {
                            // in die Liste speichern
                            list.Add(new PersonalplanModel()
                            {
                                PK = lines[i][0],
                                Nachname = lines[i][1],
                                Vorname = lines[i][2],
                                Gewerk = lines[i][3],
                                Jobtitel = lines[i][4],
                                Bereich = lines[i][5],
                                Einsatzals = lines[i][6],
                                AG = lines[i][7],
                                Brandschutzhelfer = lines[i][8] ,
                                Ersthelfer = lines[i][9],
                                datumgeplant = new DateTime    (Int32.Parse(lines[i][10].Substring(6, 4)),
                                                                Int32.Parse(lines[i][10].Substring(3, 2)),
                                                                Int32.Parse(lines[i][10].Substring(0, 2))
                                                                ),
                                //datumgeplant = DateTime.ParseExact(lines[i][10]  , "yyyy-MM-dd", CultureInfo.CurrentCulture),
                                schichttyp = lines[i][11],
                                anwesend = lines[i][12],
                                mehrarbeitgenehmight = lines[i][13],
                                Bemerkung = lines[i][14],
                                erstelltam = hochgelades_Datum,
                                erstelltvon = User.Identity.Name,
                                //datumgeplant = lines[i][13],


                            });
                        }
                    }


                    reader.Close(); // Ressource freigeben
                }

                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("Datei nicht gefunden");
                }

                catch (NullReferenceException)
                {
                    Console.WriteLine("Datei ist leer");
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("ueberlauf");
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("ueberlauf");
                }

                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Nicht genug Arbeitsspeicher");
                }

            }

            _context.Personalplan.AddRange(list);
            await _context.SaveChangesAsync();
            System.IO.File.Delete(filename); // Datei aus Web-Verzeichnis wieder löschen

            return Json("Datei erfolgreich hochgeladen");

        }

        // GET: Dropdownoptions
        public async Task<IActionResult> IndexDropdownoption()
        {
            return View(await _context.Dropdownoptions.ToListAsync());
        }

        // GET: Dropdownoptions/DetailsDropdownoption/5
        public async Task<IActionResult> DetailsDropdownoption(int? id)
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

        // GET: Dropdownoptions/CreateDropdownoption
        public IActionResult CreateDropdownoption()
        {
            return View();
        }

        // POST: Dropdownoptions/CreateDropdownoption

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDropdownoption([Bind("ID,value,Selectbezeichnung,Optionbezeichnung")] DropdownoptionsModel dropdownoptionsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dropdownoptionsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexDropdownoption));
            }
            return View(dropdownoptionsModel);
        }

        // GET: Dropdownoptions/EditDropdownoption/5
        public async Task<IActionResult> EditDropdownoption(int? id)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditDropdownoption(int id, [Bind("ID,value,Selectbezeichnung,Optionbezeichnung")] DropdownoptionsModel dropdownoptionsModel)
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
                return RedirectToAction(nameof(IndexDropdownoption));
            }
            return View(dropdownoptionsModel);
        }

        // GET: Dropdownoptions/Delete/5
        public async Task<IActionResult> DeleteDropdownoption(int? id)
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
        [HttpPost, ActionName("DeleteDropdownoption")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dropdownoptionsModel = await _context.Dropdownoptions.FindAsync(id);
            _context.Dropdownoptions.Remove(dropdownoptionsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexDropdownoption));
        }

        private bool DropdownoptionsModelExists(int id)
        {
            return _context.Dropdownoptions.Any(e => e.ID == id);
        }

    }
}
