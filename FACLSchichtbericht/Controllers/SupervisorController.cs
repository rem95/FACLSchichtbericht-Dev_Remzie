using FACLSchichtbericht.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DataTables;
using System.Threading.Tasks;
using System.Net;

namespace FACLSchichtbericht.Controllers
{
    public class SupervisorController : Controller
    {
        private readonly FACL_DB_DevContext _context;

        public SupervisorController(FACL_DB_DevContext context)
        {
            _context = context;
        }

        // ##############PRODUCTION#####################
        //private readonly FACL_DB_ProductionContext _context;

        //public SupervisorController(FACL_DB_ProductionContext context)
        //{
        //    _context = context;
        //}



        public IActionResult Index()
        {
            return View();
        }


        //Editor Personalplan
        //[Route("api/staff")]


        [AllowAnonymous]
        [HttpGet]
        [HttpPost]
        public ActionResult EditorPersonalplan()
        {
            var dbType = Environment.GetEnvironmentVariable("DBTYPE");
            var dbConnection = Environment.GetEnvironmentVariable("DBCONNECTION");

            {
                using (var db = new Database("azure", "Server=tcp:facl-sqlserver.database.windows.net,1433;Initial Catalog=FACL_DB;Database=FACL_DB;Persist Security Info=False;User ID=admin-facl756;Password=452JshOah656;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Trusted_Connection=False;"))
                {
                    var response = new Editor(db, "Personalplan")
                        .Model<SvEditorPersonalplanModel>()
                        .Field(new Field("Bereich"))
                        .Field(new Field("schichttyp"))
                        .Field(new Field("datumgeplant"))
                        .Field(new Field("Einsatzals"))
                        .Field(new Field("anwesend"))
                        .Field(new Field("Bemerkung"))        
                        .TryCatch(false)
                        .Process(Request)
                        .Data();

                    return Json(response);
                }
            }

        }

        public async Task<IActionResult> GetDataPersonalplanAbgeschlossen()
        {
            return Ok(new
            {
                data = await _context.Personalplan.Select(p => new
                {
                    p.ID,
                    p.PK,
                    p.Nachname,
                    p.Vorname,
                    p.Gewerk,
                    p.Bereich,
                    p.Jobtitel,
                    p.Einsatzals,
                    p.AG,
                    p.Brandschutzhelfer,
                    p.Ersthelfer,
                    p.anwesend,
                    p.mehrarbeitgenehmight,
                    p.Bemerkung,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.datumgeplant,
                    p.schichttyp,
                    p.istabgeschlossen

                })
                .Where(p => p.istabgeschlossen == "true" )
                .Where(p => p.datumgeplant > DateTime.Now.AddMonths(-2))
                .ToListAsync()
            });

        }

        // GET: Get Data for Datatable Personaplan: 
        public async Task<IActionResult> GetDataPersonalplanOffen()
        {
            return Ok(new
            {
                data = await _context.Personalplan.Select(p => new
                {
                    p.ID,
                    p.PK,
                    p.Nachname,
                    p.Vorname,
                    p.Gewerk,
                    p.Bereich,
                    p.Jobtitel,
                    p.Einsatzals,
                    p.AG,
                    p.Brandschutzhelfer,
                    p.Ersthelfer,
                    p.anwesend,
                    p.mehrarbeitgenehmight,
                    p.Bemerkung,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.datumgeplant,
                    p.schichttyp,
                    p.istabgeschlossen

                })
                .Where(p => p.istabgeschlossen == "false" || p.istabgeschlossen == null  )
                .ToListAsync()
            });

        }

        //Post : Add Personalplaneinträge zu dem Bericht
        [HttpPost]
        public async Task<IActionResult> AddPersonalBerichtBD420(int? id, string schichttyp, DateTime schichtdatum  )
        {


                    var addpersonallist = await _context.Personalplan.Where(s => s.schichttyp.Equals(schichttyp))
                                                                        .Where(s => s.datumgeplant.Equals(schichtdatum))
                                                                        .ToListAsync();
                    foreach (var entry in addpersonallist)
                    {
                        entry.BerichtBD420_ID = id;
                         //entry.anwesend = "Ja";

                    }
                     _context.SaveChanges();

            //return RedirectToAction("EditBerichtBD420", new { id = id });
            return Ok();

        }
        [HttpPost]
        public async Task<IActionResult> AddPersonalBerichtBD451(int? id, string schichttyp, DateTime schichtdatum  )
        {


            var addpersonallist = await _context.Personalplan.Where(s => s.schichttyp.Equals(schichttyp))
                                                                .Where(s => s.datumgeplant.Equals(schichtdatum))
                                                                .ToListAsync();
            foreach (var entry in addpersonallist)
            {
                entry.BerichtBD451_ID = id;
                //entry.anwesend = "Ja";

            }
            _context.SaveChanges();

            //return RedirectToAction("EditBerichtBD420", new { id = id });
            return Ok();

        }
        [HttpPost]
        public async Task<IActionResult> AddPersonalBerichtBU320(int? id, string schichttyp, DateTime schichtdatum  )
        {


            var addpersonallist = await _context.Personalplan.Where(s => s.schichttyp.Equals(schichttyp))
                                                                .Where(s => s.datumgeplant.Equals(schichtdatum))
                                                                .ToListAsync();
            foreach (var entry in addpersonallist)
            {
                entry.BerichtBU320_ID = id;
                //entry.anwesend = "Ja";

            }
            _context.SaveChanges();

            //return RedirectToAction("EditBerichtBD420", new { id = id });
            return Ok();

        }

        [HttpPost]
        public async Task<IActionResult> AddPersonalBerichtBU420(int? id, string schichttyp, DateTime schichtdatum  )
        {


            var addpersonallist = await _context.Personalplan.Where(s => s.schichttyp.Equals(schichttyp))
                                                                .Where(s => s.datumgeplant.Equals(schichtdatum))
                                                                .ToListAsync();
            foreach (var entry in addpersonallist)
            {
                entry.BerichtBU420_ID = id;
                //entry.anwesend = "Ja";

            }
            _context.SaveChanges();

            //return RedirectToAction("EditBerichtBD420", new { id = id });
            return Ok();

        }
        [HttpPost]
        public async Task<IActionResult> AddPersonalBerichtTransport(int? id, string schichttyp, DateTime schichtdatum)
        {




            var addpersonallist = await _context.Personalplan.Where(s => s.schichttyp.Equals(schichttyp))
                                                                .Where(s => s.datumgeplant.Equals(schichtdatum))
                                                                .ToListAsync();
            foreach (var entry in addpersonallist)
            {
                entry.BerichtTransport_ID = id;
                //entry.anwesend = "Ja";



            }
            _context.SaveChanges();



            //return RedirectToAction("EditBerichtBD420", new { id = id });
            return Ok();



        }


        public async Task<IActionResult> GetDataPersonalplanBerichtBD420_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Personalplan.Select(p => new
                {
                    p.ID,
                    p.PK,
                    p.Nachname,
                    p.Vorname,
                    p.Gewerk,
                    p.Jobtitel,
                    p.Einsatzals,
                    p.AG,
                    p.Brandschutzhelfer,
                    p.Ersthelfer,
                    p.anwesend,
                    p.mehrarbeitgenehmight,
                    p.Bemerkung,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.datumgeplant,
                    p.schichttyp

                })
                .Where(p => p.BerichtBD420_ID == id)
                .ToListAsync()
            });

        }
        public async Task<IActionResult> GetDataPersonalplanBerichtBD451_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Personalplan.Select(p => new
                {
                    p.ID,
                    p.PK,
                    p.Nachname,
                    p.Vorname,
                    p.Gewerk,
                    p.Jobtitel,
                    p.Einsatzals,
                    p.AG,
                    p.Brandschutzhelfer,
                    p.Ersthelfer,
                    p.anwesend,
                    p.mehrarbeitgenehmight,
                    p.Bemerkung,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.datumgeplant,
                    p.schichttyp

                })
                .Where(p => p.BerichtBD451_ID == id)
                .ToListAsync()
            });

        }
        public async Task<IActionResult> GetDataPersonalplanBerichtBU320_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Personalplan.Select(p => new
                {
                    p.ID,
                    p.PK,
                    p.Nachname,
                    p.Vorname,
                    p.Gewerk,
                    p.Jobtitel,
                    p.Einsatzals,
                    p.AG,
                    p.Brandschutzhelfer,
                    p.Ersthelfer,
                    p.anwesend,
                    p.mehrarbeitgenehmight,
                    p.Bemerkung,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.datumgeplant,
                    p.schichttyp

                })
                .Where(p => p.BerichtBU320_ID == id)
                .ToListAsync()
            });

        }
        public async Task<IActionResult> GetDataPersonalplanBerichtBU420_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Personalplan.Select(p => new
                {
                    p.ID,
                    p.PK,
                    p.Nachname,
                    p.Vorname,
                    p.Gewerk,
                    p.Jobtitel,
                    p.Einsatzals,
                    p.AG,
                    p.Brandschutzhelfer,
                    p.Ersthelfer,
                    p.anwesend,
                    p.mehrarbeitgenehmight,
                    p.Bemerkung,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.datumgeplant,
                    p.schichttyp

                })
                .Where(p => p.BerichtBU420_ID == id)
                .ToListAsync()
            });

        }
        public async Task<IActionResult> GetDataPersonalplanBerichtTransport_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Personalplan.Select(p => new
                {
                    p.ID,
                    p.PK,
                    p.Nachname,
                    p.Vorname,
                    p.Gewerk,
                    p.Jobtitel,
                    p.Einsatzals,
                    p.AG,
                    p.Brandschutzhelfer,
                    p.Ersthelfer,
                    p.anwesend,
                    p.mehrarbeitgenehmight,
                    p.Bemerkung,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.datumgeplant,
                    p.schichttyp



                })
                .Where(p => p.BerichtTransport_ID == id)
                .ToListAsync()
            });



        }


        public async Task<IActionResult> GetDataActiontrackerBerichtBD420_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Actiontracker.Select(p => new
                {
                    p.ID,
                    p.UserName,
                    p.Datum,
                    p.Von,
                    p.Bis,
                    p.Action,
                    p.Priorität,
                    p.Bereich,
                    p.Beschreibung,
                    p.Maßnahme,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.Overview_ID


                })
                .Where(p => p.BerichtBD420_ID == id)
                .ToListAsync()
            });

        }
        public async Task<IActionResult> GetDataActiontrackerBerichtBD451_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Actiontracker.Select(p => new
                {
                    p.ID,
                    p.UserName,
                    p.Datum,
                    p.Von,
                    p.Bis,
                    p.Action,
                    p.Priorität,
                    p.Bereich,
                    p.Beschreibung,
                    p.Maßnahme,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.Overview_ID


                })
                .Where(p => p.BerichtBD451_ID == id)
                .ToListAsync()
            });

        }
        public async Task<IActionResult> GetDataActiontrackerBerichtBU320_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Actiontracker.Select(p => new
                {
                    p.ID,
                    p.UserName,
                    p.Datum,
                    p.Von,
                    p.Bis,
                    p.Action,
                    p.Priorität,
                    p.Bereich,
                    p.Beschreibung,
                    p.Maßnahme,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.Overview_ID


                })
                .Where(p => p.BerichtBU320_ID == id)
                .ToListAsync()
            });

        }
        public async Task<IActionResult> GetDataActiontrackerBerichtBU420_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Actiontracker.Select(p => new
                {
                    p.ID,
                    p.UserName,
                    p.Datum,
                    p.Von,
                    p.Bis,
                    p.Action,
                    p.Priorität,
                    p.Bereich,
                    p.Beschreibung,
                    p.Maßnahme,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,

                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.Overview_ID


                })
                .Where(p => p.BerichtBU420_ID == id)
                .ToListAsync()
            });

        }
        public async Task<IActionResult> GetDataActiontrackerBerichtTransport_ID(int? id)
        {
            return Ok(new
            {
                data = await _context.Actiontracker.Select(p => new
                {
                    p.ID,
                    p.UserName,
                    p.Datum,
                    p.Von,
                    p.Bis,
                    p.Action,
                    p.Priorität,
                    p.Bereich,
                    p.Beschreibung,
                    p.Maßnahme,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtTransport_ID,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.Overview_ID




                })
                .Where(p => p.BerichtTransport_ID == id)
                .ToListAsync()
            });



        }


        public async Task<IActionResult> IndexBerichtBD420()
        {
            return View(await _context.BerichtBD420.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }
        public async Task<IActionResult> IndexBerichtBD451()
        {
            return View(await _context.BerichtBD451.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }
        public async Task<IActionResult> IndexBerichtBU320()
        {
            return View(await _context.BerichtBU320.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }
        public async Task<IActionResult> IndexBerichtBU437()
        {
            return View(await _context.BerichtBU420.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }
        public async Task<IActionResult> IndexBerichtBU420()
        {
            return View(await _context.BerichtBU420.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }
        public async Task<IActionResult> IndexBerichtBD437()
        {
            return View(await _context.BerichtBD437.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }
        public async Task<IActionResult> IndexBerichtBCLPosition()
        {
            return View(await _context.BerichtBCLPosition.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }
        public async Task<IActionResult> IndexBerichtTransport()
        {
            return View(await _context.BerichtTransport.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }


        public async Task<IActionResult> IndexBerichtBD420abgeschlossen()
        {

            return View(await _context.BerichtBD420.Where(p => (p.istabgeschlossen == "true") && (p.schichtdatum > DateTime.Now.AddMonths(-2)) ).ToListAsync());

        }
        public async Task<IActionResult> IndexBerichtBD451abgeschlossen()
        {

            return View(await _context.BerichtBD451.Where(p => (p.istabgeschlossen == "true") && (p.schichtdatum > DateTime.Now.AddMonths(-2))).ToListAsync());

        }
        public async Task<IActionResult> IndexBerichtBU320abgeschlossen()
        {

            return View(await _context.BerichtBU320.Where(p => (p.istabgeschlossen == "true") && (p.schichtdatum > DateTime.Now.AddMonths(-2))).ToListAsync());

        }
        public async Task<IActionResult> IndexBerichtBU420abgeschlossen()
        {

            return View(await _context.BerichtBU420.Where(p => (p.istabgeschlossen == "true") && (p.schichtdatum > DateTime.Now.AddMonths(-2))).ToListAsync());

        }
        public async Task<IActionResult> IndexBerichtBU437abgeschlossen()
        {
            return View(await _context.BerichtBU437.Where(p => (p.istabgeschlossen == "true") && (p.schichtdatum > DateTime.Now.AddMonths(-2))).ToListAsync());

        }
        public async Task<IActionResult> IndexBerichtBD437abgeschlossen()
        {
            return View(await _context.BerichtBD437.Where(p => (p.istabgeschlossen == "true") && (p.schichtdatum > DateTime.Now.AddMonths(-2))).ToListAsync());

        }
        public  ActionResult IndexBerichtBCLabgeschlossen()
        {
            return View();
        }
        public async Task<IActionResult> IndexBerichtTransportabgeschlossen()
        {
            return View(await _context.BerichtTransport.Where(p => (p.istabgeschlossen == "true") && (p.schichtdatum > DateTime.Now.AddMonths(-2))).ToListAsync());
        }

        public ActionResult IndexPersonalplanabgeschlossen()
        {
            return View();

        }
        public async Task<IActionResult> IndexActiontrackerabgeschlossen()
        {

            return View(await _context.Actiontracker.Where(p => (p.istabgeschlossen == "true") && (p.Datum > DateTime.Now.AddMonths(-2))).ToListAsync());

        }


        public async Task<IActionResult> DetailsBerichtBD420(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBD420 = await _context.BerichtBD420
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBD420 == null)
            {
                return NotFound();
            }

            return View(berichtBD420);
        }
        public async Task<IActionResult> DetailsBerichtBD451(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBD451 = await _context.BerichtBD451
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBD451 == null)
            {
                return NotFound();
            }

            return View(berichtBD451);
        }
        public async Task<IActionResult> DetailsBerichtBU320(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBU320 = await _context.BerichtBU320
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBU320 == null)
            {
                return NotFound();
            }

            return View(berichtBU320);
        }
        public async Task<IActionResult> DetailsBerichtBU420(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBU420 = await _context.BerichtBD420
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBU420 == null)
            {
                return NotFound();
            }

            return View(berichtBU420);
        }
        public async Task<IActionResult> DetailsBerichtBCLPosition(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var berichtBerichtBCLPosition = await _context.BerichtBCLPosition
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBerichtBCLPosition == null)
            {
                return NotFound();
            }

            return View(berichtBerichtBCLPosition);
        }
        public async Task<IActionResult> DetailsBerichtTransport(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var berichtTransport = await _context.BerichtTransport
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtTransport == null)
            {
                return NotFound();
            }



            return View(berichtTransport);
        }


        public IActionResult CreateBerichtBD420()
        {
            return View();
        }
        public IActionResult CreateBerichtBD451()
        {
            return View();
        }
        public IActionResult CreateBerichtBU320()
        {
            return View();
        }
        public IActionResult CreateBerichtBU420()
        {
            return View();
        }

        public IActionResult CreateBerichtBCLPosition()
        {
            return View();
        }

        public IActionResult CreateBerichtTransport()
        {
            return View();
        }


        // POST: Supervisor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBerichtBD420([Bind("ID,Supervisor1,Supervisor2,Checker1,Checker2,Checker3,Checker4,Checker5,DGRChecker1,DGRChecker2,Frachtsicherung,LagerdatenChecker,QundS,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,CheckerSoll,CheckerIst,CheckerKrank,CheckerZusatz,AufbauerSoll,AufbauerIst,AufbauerKrank,AufbauerZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,AwaitingLCC,AwaitingLCCFast,AwaitingBulk,AwaitingBulkFast,Pending,PendingLCCFast,PendingBulk,PendingBulkFast,HalLCC,HalLCCFast,HalBulk,HalBulkFast,BDStartLCC,BDStartLCCFast,BDStartBulk,BDStartBulkFast,PbMiLCC,PbMiBulk,PbMiLoco,PbEiLCC,PbEiBulk,PbEiLoco,ULDMengeMenge,ULDMengeMAStunden,ULDMengeProdu,ULDKGMenge,ULDKGMAStunden,ULDKGProdu,BulkMengeMenge,BulkMengeMaStunden,BulkMengeProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,VormannLCAG,SchichtleiterLCAG,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBD420Model berichtBD420)
        {
            if (ModelState.IsValid)
            {
                _context.Add(berichtBD420);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexberichtBD420", "Supervisor");
            }
            return View(berichtBD420);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBerichtBD451([Bind("ID,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsunfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,CheckerSoll,CheckerIst,CheckerKrank,CheckerZusatz,AufbauerSoll,AufbauerIst,AufbauerKrank,AufbauerZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,AwaitingLoco,PendingLoco,HalLoco,BDStartLoco,ULDMengeMenge,ULDMengeMAStunden,ULDMengeProdu,ULDKGMenge,ULDKGMAStunden,ULDKGProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBD451Model berichtBD451)
        {
            if (ModelState.IsValid)
            {
                _context.Add(berichtBD451);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexberichtBD451", "Supervisor");
            }
            return View(berichtBD451);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBerichtBU320([Bind("ID,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsunfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,TeamleadSoll,TeamleadIst,TeamleadKrank,TeamleadZusatz,PalettiererSoll,PalettiererIst,PalettiererKrank,PalettiererZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,ULDMengeMenge,ULDMengeMAStunden,ULDMengeProdu,AKHKGMenge,AKHKGMAStunden,AKHKGProdu,BellyKG,BellyKGMAStunden,BellyKGProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBU320Model berichtBU320)
        {
            if (ModelState.IsValid)
            {
                _context.Add(berichtBU320);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexberichtBU320", "Supervisor");
            }
            return View(berichtBU320);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBerichtBU420([Bind("ID,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsunfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,TeamleadSoll,TeamleadIst,TeamleadKrank,TeamleadZusatz,PalettiererSoll,PalettiererIst,PalettiererKrank,PalettiererZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,ULDMengeMenge,ULDMengeMAStunden,ULDMengeProdu,ULDKGMenge,ULDKGMAStunden,ULDKGProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,VormannLCAG,SchichtleiterLCAG,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBU420Model berichtBU420)
        {
            if (ModelState.IsValid)
            {
                _context.Add(berichtBU420);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexberichtBU420", "Supervisor");
            }
            return View(berichtBU420);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBerichtBCLPosition(DateTime schichtdatum , string schichttyp  )
        {

            if (ModelState.IsValid)
            {
                var berichtBCLPosition = new BerichtBCLPositionModel()
                {
                    schichtdatum = schichtdatum,
                    schichttyp = schichttyp,
                    schichtbeurteilung = "Mittel",
                    erstelltam = DateTime.Now.ToString(),
                    erstelltvon = User.Identity.Name,

                };

                _context.Add(berichtBCLPosition);
                await _context.SaveChangesAsync();
                int berichtBCLPositionlastid = berichtBCLPosition.ID;


                var berichtBU437 = new BerichtBU437Model()
                {
                    schichtdatum = schichtdatum,
                    schichttyp = schichttyp,
                    erstelltam = DateTime.Now.ToString(),
                    erstelltvon = User.Identity.Name,
                };

               _context.Add(berichtBU437);
                await _context.SaveChangesAsync();
                int berichtBU437lastid = berichtBU437.ID;


                var berichtBD437 = new BerichtBD437Model()
                {
                    schichtdatum = schichtdatum,
                    schichttyp = schichttyp,
                    erstelltam = DateTime.Now.ToString(),
                    erstelltvon = User.Identity.Name,
                };
                _context.Add(berichtBD437);
                await _context.SaveChangesAsync();
                int berichtBD437lastid = berichtBD437.ID;


                var updateBCLPosition = new BerichtBCLPositionModel()
                {
                    BerichtBD437_ID = berichtBD437lastid,
                    BerichtBU437_ID =berichtBU437lastid,
                };
                _context.BerichtBCLPosition.Find(berichtBCLPositionlastid).BerichtBD437_ID = updateBCLPosition.BerichtBD437_ID;
                _context.BerichtBCLPosition.Find(berichtBCLPositionlastid).BerichtBU437_ID = updateBCLPosition.BerichtBU437_ID;

                await _context.SaveChangesAsync();


                return RedirectToAction("IndexBerichtBCLPosition", "Supervisor");
            }

            return View(schichtdatum.ToString(), schichttyp);

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBerichtTransport([Bind("ID,Leihscanner,Leihstapler,CDSStandard,CDSDgr,Arbeitsunfall,HRLSoll,HRLIst,HRLKrank,HRLZusatzleistung,DIRSool,DIRIst,DIRKrank,DIRZusatzleistung, QuerSoll,QuerIst,QuerKrank,QuerZusatzleistung,PerkoSoll,PerkoIst,PerkoKrank,PerkoZusatzleistung,HRLMenge,HRLStunden,HRLProdu,DIRMenge,DIRStunden,DIRProdu,QuerMenge,QuerStunden,QuerProdu,PerkoMenge,PerkoStunden,PerkoProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtTransportModel berichtTransport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(berichtTransport);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexberichtTransport", "Supervisor");
            }
            return View(berichtTransport);
        }

        // GET: Supervisor/EditBerichtBD420/5
        public async Task<IActionResult> EditBerichtBD420(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var editBerichtBD420 = await _context.BerichtBD420.FindAsync(id);

            if (editBerichtBD420.istabgeschlossen == "true")
            {
                return Forbid();

            }

            if (editBerichtBD420 == null)
            {
                return NotFound();
            }
            return View(editBerichtBD420);
        }
        public async Task<IActionResult> EditBerichtBD451(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var editBerichtBD451 = await _context.BerichtBD451.FindAsync(id);

            if (editBerichtBD451.istabgeschlossen == "true")
            {
                return Forbid();

            }

            if (editBerichtBD451 == null)
            {
                return NotFound();
            }
            return View(editBerichtBD451);
        }
        public async Task<IActionResult> EditBerichtBU320(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var editBerichtBU320 = await _context.BerichtBU320.FindAsync(id);

            if (editBerichtBU320.istabgeschlossen == "true")
            {
                return Forbid();

            }

            if (editBerichtBU320 == null)
            {
                return NotFound();
            }
            return View(editBerichtBU320);
        }
        public async Task<IActionResult> EditBerichtBU420(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var editBerichtBU420 = await _context.BerichtBU420.FindAsync(id);

            if (editBerichtBU420.istabgeschlossen == "true")
            {
                return Forbid();

            }

            if (editBerichtBU420 == null)
            {
                return NotFound();
            }
            return View(editBerichtBU420);
        }
        public async Task<IActionResult> EditBerichtBCLPosition(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var editBerichtBCLPosition = await _context.BerichtBCLPosition.FindAsync(id);

            if (editBerichtBCLPosition.istabgeschlossen == "true")
            {
                return Forbid();

            }

            if (editBerichtBCLPosition == null)
            {
                return NotFound();
            }
            return View(editBerichtBCLPosition);
        }
        public async Task<IActionResult> EditBerichtTransport(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }




            var editBerichtTransport = await _context.BerichtTransport.FindAsync(id);



            if (editBerichtTransport.istabgeschlossen == "true")
            {
                return Forbid();



            }



            if (editBerichtTransport == null)
            {
                return NotFound();
            }
            return View(editBerichtTransport);
        }
        public async Task<IActionResult> EditBerichtBD437()
        {
            return View();
        }

        public async Task<IActionResult> EditberichtBU437()
        {
            return View();
        }



        // POST: Supervisor/EditBerichtBD420/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBerichtBD420(int id, [Bind("ID,Supervisor1,Supervisor2,Checker1,Checker2,Checker3,Checker4,Checker5,DGRChecker1,DGRChecker2,Frachtsicherung,LagerdatenChecker,QundS,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsunfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,CheckerSoll,CheckerIst,CheckerKrank,CheckerZusatz,AufbauerSoll,AufbauerIst,AufbauerKrank,AufbauerZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,AwaitingLCC,AwaitingLCCFast,AwaitingBulk,AwaitingBulkFast,Pending,PendingLCCFast,PendingBulk,PendingBulkFast,HalLCC,HalLCCFast,HalBulk,HalBulkFast,BDStartLCC,BDStartLCCFast,BDStartBulk,BDStartBulkFast,PbMiLCC,PbMiBulk,PbMiLoco,PbEiLCC,PbEiBulk,PbEiLoco,ULDMengeMenge,ULDMengeMAStunden,ULDMengeProdu,ULDKGMenge,ULDKGMAStunden,ULDKGProdu,BulkMengeMenge,BulkMengeMaStunden,BulkMengeProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,VormannLCAG,SchichtleiterLCAG,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBD420Model berichtBD420)
        {
            if (id != berichtBD420.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(berichtBD420);
                    _context.Entry<BerichtBD420Model>(berichtBD420).Property(x => x.schichtdatum).IsModified = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtBD420.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBD420));
            }
            return View(berichtBD420);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBerichtBD451(int id, [Bind("ID,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsunfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,CheckerSoll,CheckerIst,CheckerKrank,CheckerZusatz,AufbauerSoll,AufbauerIst,AufbauerKrank,AufbauerZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,AwaitingLoco,PendingLoco,HalLoco,BDStartLoco,ULDMengeMenge,ULDMengeMAStunden,ULDMengeProdu,ULDKGMenge,ULDKGMAStunden,ULDKGProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBD451Model berichtBD451)
        {
            if (id != berichtBD451.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(berichtBD451);
                    _context.Entry<BerichtBD451Model>(berichtBD451).Property(x => x.schichtdatum).IsModified = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtBD451.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBD451));
            }
            return View(berichtBD451);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBerichtBU320(int id, [Bind("ID,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsunfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,TeamleadSoll,TeamleadIst,TeamleadKrank,TeamleadZusatz,PalettiererSoll,PalettiererIst,PalettiererKrank,PalettiererZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,AKHMengeMenge,AKHMengeMAStunden,AKHMengeProdu,AKHKGMenge,AKHKGMAStunden,AKHKGProdu,BellyMengeMenge,BellyMengeMAStunden,BellyMengeProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBU320Model berichtBU320)
        {
            if (id != berichtBU320.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(berichtBU320);
                    _context.Entry<BerichtBU320Model>(berichtBU320).Property(x => x.schichtdatum).IsModified = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtBU320.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBU320));
            }
            return View(berichtBU320);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBerichtBU420(int id, [Bind("ID,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsunfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,TeamleadSoll,TeamleadIst,TeamleadKrank,TeamleadZusatz,PalettiererSoll,PalettiererIst,PalettiererKrank,PalettiererZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,ULDMengeMenge,ULDMengeMAStunden,ULDMengeProdu,ULDKGMenge,ULDKGMAStunden,ULDKGProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBU420Model berichtBU420)
        {
            if (id != berichtBU420.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(berichtBU420);
                    _context.Entry<BerichtBU420Model>(berichtBU420).Property(x => x.schichtdatum).IsModified = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtBU420.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBU420));
            }
            return View(berichtBU420);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBerichtBCLPosition(int id, BerichtBCLPositionModel berichtBCLPosition)
        {

            if (id != berichtBCLPosition.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                try
                {
                    _context.Update(berichtBCLPosition);
                    _context.Entry<BerichtBCLPositionModel>(berichtBCLPosition).Property(x => x.schichtdatum).IsModified = false;
                    await _context.SaveChangesAsync();


                    var  berichtBD437 = new BerichtBD437Model() {

                        schichtdatum = berichtBCLPosition.schichtdatum
                        
                    };
                    _context.Update(berichtBD437);
                    await _context.SaveChangesAsync();


                    var berichtBU437 = new BerichtBU437Model()
                    {

                        schichtdatum = berichtBCLPosition.schichtdatum

                    };
                    _context.Update(berichtBD437);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBCLPositionExists(berichtBCLPosition.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBCLPosition));

            }

            return View(berichtBCLPosition);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBerichtTransport(int id, [Bind("ID,Leihscanner,Leihstapler,CDSStandard,CDSDgr,Arbeitsunfall,HRLSoll,HRLIst,HRLKrank,HRLZusatzleistung,DIRSool,DIRIst,DIRKrank,DIRZusatzleistung, QuerSoll,QuerIst,QuerKrank,QuerZusatzleistung,PerkoSoll,PerkoIst,PerkoKrank,PerkoZusatzleistung,HRLMenge,HRLStunden,HRLProdu,DIRMenge,DIRStunden,DIRProdu,QuerMenge,QuerStunden,QuerProdu,PerkoMenge,PerkoStunden,PerkoProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtTransportModel berichtTransport)
        {
            if (id != berichtTransport.ID)
            {
                return NotFound();
            }



            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(berichtTransport);
                    _context.Entry<BerichtTransportModel>(berichtTransport).Property(x => x.schichtdatum).IsModified = false;



                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtTransport.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtTransport));
            }
            return View(berichtTransport);
        }


        public async Task<IActionResult> AbschließenBerichtBD420(int id, [Bind("ID,abgeschlossenam,abgeschlossenvon,istabgeschlossen")] BerichtBD420Model berichtBD420)
        {
            if (id != berichtBD420.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

               
                
                try
                {

                    var BerichtBD420Model = _context.BerichtBD420
                    .FirstOrDefault(s => s.ID.Equals(id));
                    BerichtBD420Model.abgeschlossenam = berichtBD420.abgeschlossenam;
                    BerichtBD420Model.abgeschlossenvon = berichtBD420.abgeschlossenvon;
                    BerichtBD420Model.istabgeschlossen = berichtBD420.istabgeschlossen;
                    await _context.SaveChangesAsync();

                    var actiontrackerlist =  _context.Actiontracker.Where(s => s.BerichtBD420_ID.Equals(id)).ToList();
                    foreach ( var entry in actiontrackerlist)
                    {
                        entry.istabgeschlossen = "true";
                        
                    }
                    _context.SaveChanges();
                    var personalplanlist = _context.Personalplan.Where(s => s.BerichtBD420_ID.Equals(id)).ToList();
                    foreach (var personalplanentry in personalplanlist)
                    {
                        personalplanentry.istabgeschlossen = "true";

                    }
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtBD420.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBD420));
            }
            return View(berichtBD420);
        }
        public async Task<IActionResult> AbschließenBerichtBD451(int id, [Bind("ID,abgeschlossenam,abgeschlossenvon,istabgeschlossen")] BerichtBD451Model berichtBD451)
        {
            if (id != berichtBD451.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {



                try
                {

                    var BerichtBD451Model = _context.BerichtBD451
                    .FirstOrDefault(s => s.ID.Equals(id));
                    BerichtBD451Model.abgeschlossenam = berichtBD451.abgeschlossenam;
                    BerichtBD451Model.abgeschlossenvon = berichtBD451.abgeschlossenvon;
                    BerichtBD451Model.istabgeschlossen = berichtBD451.istabgeschlossen;
                    await _context.SaveChangesAsync();

                    var actiontrackerlist = _context.Actiontracker.Where(s => s.BerichtBD451_ID.Equals(id)).ToList();
                    foreach (var entry in actiontrackerlist)
                    {
                        entry.istabgeschlossen = "true";

                    }
                    _context.SaveChanges();
                    var personalplanlist = _context.Personalplan.Where(s => s.BerichtBD451_ID.Equals(id)).ToList();
                    foreach (var personalplanentry in personalplanlist)
                    {
                        personalplanentry.istabgeschlossen = "true";

                    }
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD451Exists(berichtBD451.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBD451));
            }
            return View(berichtBD451);
        }
        public async Task<IActionResult> AbschließenBerichtBU320(int id, [Bind("ID,abgeschlossenam,abgeschlossenvon,istabgeschlossen")] BerichtBU320Model berichtBU320)
        {
            if (id != berichtBU320.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {



                try
                {

                    var BerichtBU320Model = _context.BerichtBU320
                    .FirstOrDefault(s => s.ID.Equals(id));
                    BerichtBU320Model.abgeschlossenam = berichtBU320.abgeschlossenam;
                    BerichtBU320Model.abgeschlossenvon = berichtBU320.abgeschlossenvon;
                    BerichtBU320Model.istabgeschlossen = berichtBU320.istabgeschlossen;
                    await _context.SaveChangesAsync();

                    var actiontrackerlist = _context.Actiontracker.Where(s => s.BerichtBU320_ID.Equals(id)).ToList();
                    foreach (var entry in actiontrackerlist)
                    {
                        entry.istabgeschlossen = "true";

                    }
                    _context.SaveChanges();
                    var personalplanlist = _context.Personalplan.Where(s => s.BerichtBU320_ID.Equals(id)).ToList();
                    foreach (var personalplanentry in personalplanlist)
                    {
                        personalplanentry.istabgeschlossen = "true";

                    }
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtBU320.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBU320));
            }
            return View(berichtBU320);
        }
        public async Task<IActionResult> AbschließenBerichtBU420(int id, [Bind("ID,abgeschlossenam,abgeschlossenvon,istabgeschlossen")] BerichtBU420Model berichtBU420)
        {
            if (id != berichtBU420.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {



                try
                {

                    var BerichtBU420Model = _context.BerichtBU420
                    .FirstOrDefault(s => s.ID.Equals(id));
                    BerichtBU420Model.abgeschlossenam = berichtBU420.abgeschlossenam;
                    BerichtBU420Model.abgeschlossenvon = berichtBU420.abgeschlossenvon;
                    BerichtBU420Model.istabgeschlossen = berichtBU420.istabgeschlossen;
                    await _context.SaveChangesAsync();

                    var actiontrackerlist = _context.Actiontracker.Where(s => s.BerichtBU420_ID.Equals(id)).ToList();
                    foreach (var entry in actiontrackerlist)
                    {
                        entry.istabgeschlossen = "true";

                    }
                    _context.SaveChanges();
                    var personalplanlist = _context.Personalplan.Where(s => s.BerichtBU420_ID.Equals(id)).ToList();
                    foreach (var personalplanentry in personalplanlist)
                    {
                        personalplanentry.istabgeschlossen = "true";

                    }
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtBU420.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtBU420));
            }
            return View(berichtBU420);
        }
        public async Task<IActionResult> AbschließenBerichtTransport(int id, [Bind("ID,abgeschlossenam,abgeschlossenvon,istabgeschlossen")] BerichtTransportModel berichtTransport)
        {
            if (id != berichtTransport.ID)
            {
                return NotFound();
            }



            if (ModelState.IsValid)
            {





                try
                {



                    var BerichtTransportModel = _context.BerichtTransport
                    .FirstOrDefault(s => s.ID.Equals(id));
                    BerichtTransportModel.abgeschlossenam = berichtTransport.abgeschlossenam;
                    BerichtTransportModel.abgeschlossenvon = berichtTransport.abgeschlossenvon;
                    BerichtTransportModel.istabgeschlossen = berichtTransport.istabgeschlossen;
                    await _context.SaveChangesAsync();



                    var actiontrackerlist = _context.Actiontracker.Where(s => s.BerichtTransport_ID.Equals(id)).ToList();
                    foreach (var entry in actiontrackerlist)
                    {
                        entry.istabgeschlossen = "true";



                    }
                    _context.SaveChanges();
                    var personalplanlist = _context.Personalplan.Where(s => s.BerichtTransport_ID.Equals(id)).ToList();
                    foreach (var personalplanentry in personalplanlist)
                    {
                        personalplanentry.istabgeschlossen = "true";



                    }
                    _context.SaveChanges();



                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BerichtBD420Exists(berichtTransport.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBerichtTransport));
            }
            return View(berichtTransport);
        }




        public async Task<IActionResult> DeleteBerichtBD420(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBD420 = await _context.BerichtBD420
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBD420 == null)
            {
                return NotFound();
            }

            return View(berichtBD420);
        }
        public async Task<IActionResult> DeleteBerichtBD451(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBD451 = await _context.BerichtBD451
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBD451 == null)
            {
                return NotFound();
            }

            return View(berichtBD451);
        }
        public async Task<IActionResult> DeleteBerichtBU320(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBU320 = await _context.BerichtBU320
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBU320 == null)
            {
                return NotFound();
            }

            return View(berichtBU320);
        }
        public async Task<IActionResult> DeleteBerichtBU420(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBU420 = await _context.BerichtBU420
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBU420 == null)
            {
                return NotFound();
            }

            return View(berichtBU420);
        }
        public async Task<IActionResult> DeleteBerichtBCLPosition(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var berichtBCLPosition = await _context.BerichtBCLPosition
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtBCLPosition == null)
            {
                return NotFound();
            }

            return View(berichtBCLPosition);
        }
        public async Task<IActionResult> DeleteBerichtTransport(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var berichtTransport = await _context.BerichtTransport
                .FirstOrDefaultAsync(m => m.ID == id);
            if (berichtTransport == null)
            {
                return NotFound();
            }



            return View(berichtTransport);
        }



        // POST: BerichtBD420/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBerichtBD420(int id)
        {
            var berichtBD420 = await _context.BerichtBD420.FindAsync(id);
            _context.BerichtBD420.Remove(berichtBD420);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBerichtBD420));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBerichtBD451(int id)
        {
            var berichtBD451 = await _context.BerichtBD451.FindAsync(id);
            _context.BerichtBD451.Remove(berichtBD451);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBerichtBD451));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBerichtBU320(int id)
        {
            var berichtBU320 = await _context.BerichtBU320.FindAsync(id);
            _context.BerichtBU320.Remove(berichtBU320);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBerichtBU320));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBerichtBU420(int id)
        {
            var berichtBU420 = await _context.BerichtBU420.FindAsync(id);
            _context.BerichtBU420.Remove(berichtBU420);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBerichtBU420));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBerichtBCLPosition(int id)
        {
            var berichtBCLPosition = await _context.BerichtBCLPosition.FindAsync(id);
            _context.BerichtBCLPosition.Remove(berichtBCLPosition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBerichtBU420));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBerichtTransport(int id)
        {
            var berichtTransport = await _context.BerichtTransport.FindAsync(id);
            _context.BerichtTransport.Remove(berichtTransport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBerichtTransport));
        }

        // POST: BerichtBD420/Delete/5 
        // Verwaist ?????
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var berichtBD420 = await _context.BerichtBD420.FindAsync(id);
            _context.BerichtBD420.Remove(berichtBD420);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBerichtBD420));
        }

        private bool BerichtBD420Exists(int id)
        {
            return _context.BerichtBD420.Any(e => e.ID == id);
        }
        private bool BerichtBD451Exists(int id)
        {
            return _context.BerichtBD451.Any(e => e.ID == id);
        }
        private bool BerichtBU320Exists(int id)
        {
            return _context.BerichtBU320.Any(e => e.ID == id);
        }
        private bool BerichtBU420Exists(int id)
        {
            return _context.BerichtBU420.Any(e => e.ID == id);
        }
        private bool BerichtBU437Exists(int id)
        {
            return _context.BerichtBU437.Any(e => e.ID == id);

        }
        private bool BerichtBD437Exists(int id)
        {
            return _context.BerichtBD437.Any(e => e.ID == id);
        }
        private bool BerichtBCLPositionExists(int id)
        {
            return _context.BerichtBD437.Any(e => e.ID == id);
        }

        // GET: Actiontracker
        public async Task<IActionResult> IndexActiontracker()
        {
            return View(await _context.Actiontracker.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }

        // GET: Actiontracker/Details/5
        public async Task<IActionResult> DetailsActiontracker(int? id)
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
        public IActionResult CreateActiontracker()
        {
            return View();
        }

        // POST: Actiontracker/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateActiontracker([Bind("ID,UserName,Datum,Von,Bis,Action,Priorität,Bereich,Beschreibung,Maßnahme,erstelltam,erstelltvon,zuletztbearbeitetam,zuletztbearbeitetvon,istabgeschlossen,BerichtBD420_ID,BerichtBD451_ID,BerichtBU320_ID,BerichtBU420_ID,Overview_ID")] ActiontrackerModel actiontrackerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actiontrackerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexActiontracker));
            }
            return View(actiontrackerModel);
        }

        // GET: Actiontracker/Edit/5
        public async Task<IActionResult> EditActiontracker(int? id)
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
            var abgeschlossen = await _context.Actiontracker.FindAsync(id);
            if (abgeschlossen.istabgeschlossen == "true")
            {
                return Forbid();
            }
            return View(actiontrackerModel);
        }

        // POST: Actiontracker/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditActiontracker(int id, [Bind("ID,UserName,Datum,Von,Bis,Action,Priorität,Bereich,Beschreibung,Maßnahme,erstelltam,erstelltvon,zuletztbearbeitetam,zuletztbearbeitetvon,istabgeschlossen,BerichtBD420_ID,BerichtBD451_ID,BerichtBU320_ID,BerichtBU420_ID,Overview_ID")] ActiontrackerModel actiontrackerModel)
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
                return RedirectToAction(nameof(IndexActiontracker));
            }
            return View(actiontrackerModel);
        }

        // GET: Actiontracker/Delete/5
        public async Task<IActionResult> DeleteActiontracker(int? id)
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
        [HttpPost, ]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteActiontracker(int id)
        {
            var actiontrackerModel = await _context.Actiontracker.FindAsync(id);
            _context.Actiontracker.Remove(actiontrackerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexActiontracker));
        }

        private bool ActiontrackerModelExists(int id)
        {
            return _context.Actiontracker.Any(e => e.ID == id);
        }

        // GET: Personalplan
        public  ActionResult IndexPersonalplan()
        {
            return View();

            //return View(await _context.Personalplan.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }

        // GET: Personalplan/Details/5
        public async Task<IActionResult> DetailsPersonalplan(int? id)
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
        public IActionResult CreatePersonalplan()
        {
            return View();
        }

        // POST: Personalplan/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePersonalplan([Bind("ID,PK,Nachname,Vorname,Gewerk,Bereich,Jobtitel,Einsatzals,AG,Brandschutzhelfer,Ersthelfer,anwesend,mehrarbeitgenehmight,Bemerkung,erstelltam,erstelltvon,zuletztbearbeitetam,zuletztbearbeitetvon,BerichtBD420_ID,BerichtBD451_ID,BerichtBU320_ID,BerichtBU420_ID,datumgeplant,schichttyp,istabgeschlossen")] PersonalplanModel personalplanModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalplanModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexPersonalplan));
            }
            return View(personalplanModel);
        }

        // GET: Personalplan/Edit/5
        public async Task<IActionResult> EditPersonalplan(int? id)
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

            var abgeschlossen = await _context.Personalplan.FindAsync(id);
            if (abgeschlossen.istabgeschlossen == "true")
            {
                return Forbid();
            }
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            return View(personalplanModel);
        }

        // POST: Personalplan/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPersonalplan(int id, [Bind("ID,PK,Nachname,Vorname,Gewerk,Bereich,Jobtitel,Einsatzals,AG,Brandschutzhelfer,Ersthelfer,anwesend,mehrarbeitgenehmight,Bemerkung,erstelltam,erstelltvon,zuletztbearbeitetam,zuletztbearbeitetvon,BerichtBD420_ID,BerichtBD451_ID,BerichtBU320_ID,BerichtBU420_ID,datumgeplant,schichttyp,istabgeschlossen")] PersonalplanModel personalplanModel, string returnUrl)
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
                return Redirect(returnUrl);
            }
            return View(personalplanModel);
        }

        // GET: Personalplan/Delete/5
        public async Task<IActionResult> DeletePersonalplan(int? id)
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
        [HttpPost, ]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePersonalplan(int id)
        {
            var personalplanModel = await _context.Personalplan.FindAsync(id);
            _context.Personalplan.Remove(personalplanModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexPersonalplan));
        }

        private bool PersonalplanModelExists(int id)
        {
            return _context.Personalplan.Any(e => e.ID == id);
        }

        //Get Dropdown Schichttyp
        [AllowAnonymous]
        public async Task<IActionResult> GetDataschichttyp()
        {
            
            return Ok( await _context.Schichttyp.Select(x => new
            {
                
                name = x.Bezeichnung
            }).ToListAsync());
        }

        //Get Dropdown Gewerk
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnGewerk()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Gewerk").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }

        //Get Dropdown Bereich
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnBereich()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Bereich").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }
        //Get Dropdown einsatzals
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnEinsatzals()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Einsatzals").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnJobtitel()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Jobtitel").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }

        //Get Dropdown AG
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnAg()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "AG").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }
        //Get Dropdown Action
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnAction()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Action").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }
        //Get Dropdown Prioritaet
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnPrioritaet()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Prioritaet").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }

        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnSchichtleiter()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Schichtleiter").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }

        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnHDO()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "HDO").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }

    }
}
