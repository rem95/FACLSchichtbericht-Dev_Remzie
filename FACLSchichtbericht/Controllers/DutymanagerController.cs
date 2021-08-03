using FACLSchichtbericht.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Controllers
{
    public class DutymanagerController : Controller
    {

        private readonly FACL_DB_DevContext _context;

        public DutymanagerController(FACL_DB_DevContext context)
        {
            _context = context;
        }

        //nicht kommentiert bei deploy für production
        //private readonly FACL_DB_ProductionContext _context;

        //public DutymanagerController(FACL_DB_ProductionContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexOffeneBerichte()
        {

            var berichtBD420s = _context.BerichtBD420.ToList();
            var berichtBD451s = _context.BerichtBD451.ToList();
            var berichtBU320s = _context.BerichtBU320.ToList();
            var berichtBU420s = _context.BerichtBU420.ToList();


            //var offeneBerichte = from e in berichtBD420s
            //                     join d in berichtBD451s on e.Department_Id equals d.DepartmentId into table1
            //                     from d in table1.ToList()
            //                     join i in berichtBU320s on e.Incentive_Id equals i.IncentiveId into table2
            //                     from i in table2.ToList()
            //                     join f in berichtBU420s on e.Incentive_Id equals f.IncentiveId into table3 
            //                     from f in table3.ToList()
            //                     select new OffeneBerichteViewModel
            //                     {
            //                         berichtBD420 = e,
            //                         berichtBD451 = d,
            //                         berichtBU320 = i,
            //                         berichtBU420 = f
            //                     };
            //return View(offeneBerichte);
            return View();

        }

        public IActionResult IndexAbgeschlosseneBerichte()
        {
            return View();
        }

        public IActionResult IndexFreigegebeneBerichte()
        {
            return View();
        }

        public IActionResult IndexFreigegebeneOverview()
        {
            return View();
        }

        public IActionResult IndexPersonalplan()
        {
            return View();
        }

        //public IActionResult IndexActiontracker()
        //{
        //    return View();
        //}

        public IActionResult IndexBerichtBD420()
        {
            return View();
        }

        public IActionResult IndexBerichtBD420abgeschlossen()
        {
            return View();
        }

        public IActionResult IndexBerichtBD420offen()
        {
            return View();
        }

        public IActionResult IndexBerichtBD420freigegeben()
        {
            return View();
        }

        public IActionResult IndexOverview()
        {
            return View( _context.Overview.Where(x => x.istabgeschlossen != "true").ToList());
        }




        public ActionResult CreateOverview()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  CreateOverview( OverviewModel overview)
        {
            if (ModelState.IsValid)
            {
                overview.erstelltam = DateTime.Now;
                overview.erstelltvon = User.Identity.Name;
                _context.Add(overview);
                await _context.SaveChangesAsync();

            }
                return RedirectToAction(nameof(IndexOverview));



        }



        public async Task<IActionResult> EditOverview(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var editOverview = await _context.Overview.FindAsync(id);


            if (editOverview == null)
            {
                return NotFound();
            }

            var overview = _context.Overview.Find(id);
            DateTime overview_b_date = (DateTime)editOverview.berichtdatum;
            var overview_schichttyp = editOverview.schichttyp;

            List<BerichtBD420Model> berichtBD420s = _context.BerichtBD420.Where(
                x => x.schichttyp == overview_schichttyp).ToList();

            var b_date = (int)_context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(x => x.SupervisorIst);

            var b_schichttyp = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    ).FirstOrDefault();



            // schreibt die Zahlen aus den berichten in den Overview
            try
            {
                overview.BDSupervisorSoll = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorSoll) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorSoll);

                overview.BDSupervisorIst = _context.BerichtBD420.AsEnumerable().Where(
                    row => row.schichtdatum == overview_b_date && row.schichttyp == overview_schichttyp)
                    .Sum(row => row.SupervisorIst) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorIst);

                overview.BDSupervisorKrank = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorKrank) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorKrank);

                overview.BDSupervisorZusatz = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorZusatz) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorZusatz);

                overview.BDCheckerSoll = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CheckerSoll) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CheckerSoll);

                overview.BDCheckerIst = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CheckerIst) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CheckerIst);

                overview.BDCheckerKrank = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CheckerKrank) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CheckerKrank);

                overview.BDCheckerZusatz = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CheckerZusatz) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CheckerZusatz);

                

                overview.BDAufbauerSoll = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AufbauerSoll) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AufbauerSoll);
                overview.BDAufbauerIst = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AufbauerIst) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AufbauerIst);
                overview.BDAufbauerKrank = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AufbauerKrank) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AufbauerKrank);
                overview.BDAufbauerZusatz = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AufbauerZusatz) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AufbauerZusatz);

                overview.BDAbfertigerSoll = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerSoll) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerSoll);
                overview.BDAbfertigerIst = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerIst) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerIst);
                overview.BDAbfertigerKrank = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerKrank) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerKrank);
                overview.BDAbfertigerZusatz = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerZusatz) + _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerZusatz);

                overview.BUSupervisorSoll = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorSoll) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorSoll);
                overview.BUSupervisorIst = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorIst) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorIst);
                overview.BUSupervisorKrank = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorKrank) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorKrank);
                overview.BUSupervisorZusatz = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorZusatz) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.SupervisorZusatz);

                overview.BUTeamleadSoll = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.TeamleadSoll) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.TeamleadSoll);
                overview.BUTeamleadIst = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.TeamleadIst) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.TeamleadIst);
                overview.BUTeamleadKrank = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.TeamleadKrank) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.TeamleadKrank);
                overview.BUTeamleadZusatz = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.TeamleadZusatz) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.TeamleadZusatz);

                overview.BUPalettiererSoll = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PalettiererSoll) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PalettiererSoll);
                overview.BUPalettiererIst = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PalettiererIst) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PalettiererIst);
                overview.BUPalettiererKrank = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PalettiererKrank) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PalettiererKrank);
                overview.BUPalettiererZusatz = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PalettiererZusatz) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PalettiererZusatz);



                overview.BUAbfertigerSoll = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerSoll) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerSoll);
                overview.BUAbfertigerIst = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerIst) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerIst);
                overview.BUAbfertigerKrank = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerKrank) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerKrank);
                overview.BUAbfertigerZusatz = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerZusatz) + _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AbfertigerZusatz);

                //################Produktivität###################

                overview.BD420ULDMengeMenge = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMenge);
                overview.BD420ULDMengeStunden = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMAStunden);
                overview.BD420ULDMengeProdu = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeProdu);

                overview.BD420ULDKGMenge = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMenge);
                overview.BD420ULDKGStunden = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMAStunden);
                overview.BD420ULDKGProdu = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGProdu);

                overview.BD420BULKMengeMenge = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BulkMengeMenge);
                overview.BD420BulkMengeStunden = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BulkMengeMaStunden);
                overview.BD420BulkMengeProdu = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BulkMengeProdu);

                overview.BD451ULDMengeMenge = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMenge);
                overview.BD451ULDMengeStunden = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMAStunden);
                overview.BD451ULDMengeProdu = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeProdu);

                overview.BD451ULDKGMenge = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMenge);
                overview.BD451ULDKGStunden = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMAStunden);
                overview.BD451ULDKGProdu = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGProdu);
                
                overview.BD437ULDMengeMenge = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMenge);
                overview.BD437ULDMengeStunden = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeStunden);
                overview.BD437ULDMengeProdu = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeProdu);

                overview.BD437ULDKGMenge = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMenge);
                overview.BD437ULDKGStunden = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMenge);
                overview.BD437ULDKGProdu = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGProdu);

                overview.BU320AKHMengeMenge = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHMengeMenge);
                overview.BU320AKHMengeStunden = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHMengeMAStunden);
                overview.BU320AKHMengeProdu = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHMengeProdu);

                overview.BU320AKHKGMenge = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHKGMenge);
                overview.BU320AKHKGStunden = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHKGMAStunden);
                overview.BU320AKHKGProdu = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHKGProdu);

                overview.BU320BellyMengeMenge = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BellyMengeMenge);
                overview.BU320BellyMengeStunden = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BellyMengeMAStunden);
                overview.BU320BellyMengeProdu = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BellyMengeProdu);

                overview.BU420ULDMengeMenge = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMenge);
                overview.BU420ULDMengeStunden = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMAStunden);
                overview.BU420ULDMengeProdu = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeProdu);

                overview.BU420ULDKGMenge = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMenge);
                overview.BU420ULDKGStunden = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMAStunden);
                overview.BU420ULDKGProdu = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGProdu);

                overview.BU437ULDMengeMenge = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMenge);
                overview.BU437ULDMengeStunden = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeStunden);
                overview.BU437ULDMengeProdu = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeProdu);

                overview.BU437ULDKGMenge = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMenge);
                overview.BU437ULDKGStunden = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGStunden);
                overview.BU437ULDKGProdu = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGProdu);

                overview.TransportHRLMenge = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.HRLMenge);
                overview.TransportHRLStunden = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.HRLStunden);
                overview.TransportHRLProdu = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.HRLProdu);

                overview.TransportDIRMenge = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.DIRMenge);
                overview.TransportDIRStunden = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.DIRStunden);
                overview.TransportDIRProdu = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.DIRProdu);

                overview.TransportQuerMenge = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.QuerMenge);
                overview.TransportQuerStunden = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.QuerStunden);
                overview.TransportQuerProdu = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.QuerProdu);

                overview.TransportPerkoMenge = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PerkoMenge);
                overview.TransportPerkoStunden = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PerkoStunden);
                overview.TransportPerkoProdu = _context.BerichtTransport.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.PerkoProdu);

                overview.BU320AKHMengeMenge = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHMengeMenge);
                overview.BU320AKHMengeStunden = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHMengeMAStunden);
                overview.BU320AKHMengeProdu = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHMengeMAStunden);

                overview.BU320AKHKGMenge = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHKGMenge);
                overview.BU320AKHKGStunden = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHKGMAStunden);
                overview.BU320AKHKGProdu = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.AKHKGProdu);

                overview.BU320BellyMengeMenge = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BellyMengeMenge);
                overview.BU320BellyMengeStunden = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BellyMengeMAStunden);
                overview.BU320BellyMengeProdu = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.BellyMengeProdu);

                overview.BU420ULDMengeMenge = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMenge);
                overview.BU420ULDMengeStunden = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMAStunden);
                overview.BU420ULDMengeProdu = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeProdu);

                overview.BU420ULDKGMenge = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMenge);
                overview.BU420ULDKGStunden = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMAStunden);
                overview.BU420ULDKGProdu = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGProdu);

                overview.BU437ULDMengeMenge = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeMenge);
                overview.BU437ULDMengeStunden = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeStunden);
                overview.BU437ULDMengeProdu = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDMengeProdu);

                overview.BU437ULDKGMenge = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGMenge);
                overview.BU437ULDKGStunden = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGStunden);
                overview.BU437ULDKGProdu = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.ULDKGProdu);
                //###############################LEIHSCANNER###################
                overview.LeihscannerBD420 = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihscanner);
                overview.LeihscannerBD451 = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihscanner);
                overview.LeihscannerBU320 = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihscanner);
                overview.LeihscannerBU420 = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihscanner);
                overview.LeihscannerBD437 = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihscanner);
                overview.LeihscannerBU437 = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihscanner);

                overview.LeihstaplerBD420 = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihstapler);
                overview.LeihstaplerBD451 = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihstapler);
                overview.LeihstaplerBU320 = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihstapler);
                overview.LeihstaplerBU420 = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihstapler);
                overview.LeihstaplerBD437 = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihstapler);
                overview.LeihstaplerBU437 = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.Leihstapler);

                overview.CDSstandardBD420 = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSStandard);
                overview.CDSstandardBD451 = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSStandard);
                overview.CDSstandardBU320 = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSStandard);
                overview.CDSstandardBU420 = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSStandard);
                overview.CDSstandardBD437 = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSStandard);
                overview.CDSstandardBU437 = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSStandard);

                overview.CDSdgrBD420 = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSDGR);
                overview.CDSdgrBD451 = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSDGR);
                overview.CDSdgrBU320 = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSDGR);
                overview.CDSdgrBU420 = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSDGR);
                overview.CDSdgrBD437 = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSDGR);
                overview.CDSdgrBU437 = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).Sum(s => s.CDSDGR);

                overview.ArbeitsunfallBD420 = _context.BerichtBD420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).FirstOrDefault()?.Arbeitsunfall;
                overview.ArbeitsunfallBD451 = _context.BerichtBD451.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).FirstOrDefault()?.Arbeitsunfall;
                overview.ArbeitsunfallBU320 = _context.BerichtBU320.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).FirstOrDefault()?.Arbeitsunfall;
                overview.ArbeitsunfallBU420 = _context.BerichtBU420.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).FirstOrDefault()?.Arbeitsunfall;
                overview.ArbeitsunfallBD437 = _context.BerichtBD437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).FirstOrDefault()?.Arbeitsunfall;
                overview.ArbeitsunfallBU437 = _context.BerichtBU437.Where(
                    x => x.schichtdatum == overview_b_date
                    && x.schichttyp == overview_schichttyp).FirstOrDefault()?.Arbeitsunfall;


                _context.Update(overview);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OverviewExists(overview.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return View(editOverview);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditOverview(int? id, OverviewModel overview)
        {
            if (id != overview.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    var updateoverview = _context.Overview.FirstOrDefault(s => s.ID.Equals(id));
                    updateoverview.HDO = overview.HDO;
                    updateoverview.SchichtleiterLF = overview.SchichtleiterLF;
                    updateoverview.SchichtleiterPT = overview.SchichtleiterPT;
                    updateoverview.schichtbeurteilung = overview.schichtbeurteilung;
                    updateoverview.istfreigegeben = overview.istfreigegeben;
                    if(overview.istfreigegeben == "true"){
                        updateoverview.freigegebenam = DateTime.Now;
                    }
                    updateoverview.zuletztbearbeitetam = DateTime.Now;
                    updateoverview.zuletztbearbeitetvon = User.Identity.Name;
                    

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OverviewExists(overview.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexOverview));
            }
            return View(overview);
        }

        public async Task<IActionResult> EditBerichtBD420abgeschlossen(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var editBerichtBD420 = await _context.BerichtBD420.FindAsync(id);


            if (editBerichtBD420 == null)
            {
                return NotFound();
            }
            return View(editBerichtBD420);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBerichtBD420abgeschlossen(int id, [Bind("ID,Supervisor1,Supervisor2,Checker1,Checker2,Checker3,Checker4,Checker5,DGRChecker1,DGRChecker2,Frachtsicherung,LagerdatenChecker,QundS,Leihscanner,Leihstapler,CDSStandard,CDSDGR,Arbeitsunfall,SupervisorSoll,SupervisorIst,SupervisorKrank,SupervisorZusatz,CheckerSoll,CheckerIst,CheckerKrank,CheckerZusatz,AufbauerSoll,AufbauerIst,AufbauerKrank,AufbauerZusatz,AbfertigerIst,AbfertigerSoll,AbfertigerKrank,AbfertigerZusatz,AwaitingLCC,AwaitingLCCFast,AwaitingBulk,AwaitingBulkFast,Pending,PendingLCCFast,PendingBulk,PendingBulkFast,HalLCC,HalLCCFast,HalBulk,HalBulkFast,BDStartLCC,BDStartLCCFast,BDStartBulk,BDStartBulkFast,PbMiLCC,PbMiBulk,PbMiLoco,PbEiLCC,PbEiBulk,PbEiLoco,ULDMengeMenge,ULDMengeMAStunden,ULDMengeProdu,ULDKG,ULDKGMAStunden,ULDKGProdu,BulkMengeMenge,BulkMengeMaStunden,BulkMengeProdu,zuletztbearbeitetvon,zuletztbearbeitetam,istabgeschlossen,istfreigegeben,abgeschlossenvon,freigegebenvon,schichtdatum,schichtbeginn,schichtende,schichttyp,schichtbeurteilung,VormannLCAG,SchichtleiterLCAG,erstelltam,erstelltvon,abgeschlossenam,freigegebenam")] BerichtBD420Model berichtBD420)
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

        public async Task<IActionResult> GetDataFreigegebeneOverview()
        {
            return Ok(new
            {
                data = await _context.Overview.Select(p => new
                {
                    p.ID,
                    p.berichtdatum,
                    p.schichttyp,
                    p.schichtbeurteilung,

                })
                .Where(p => p.berichtdatum > DateTime.Now.AddMonths(-2))
                .ToListAsync()
            });

        }

        public async Task<IActionResult> GetDataPersonalplan()
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
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,
                    p.datumgeplant,
                    p.schichttyp

                })
                .Where(p => p.datumgeplant > DateTime.Now.AddMonths(-2))
                .ToListAsync()
            });

        }

        public async Task<IActionResult> GetDataActiontracker()
        {
            return Ok(new
            {
                data = await _context.Actiontracker.Select(p => new
                {
                    p.ID,
                    p.Datum,
                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.BerichtBD420_ID,
                    p.BerichtBD451_ID,
                    p.BerichtBU320_ID,
                    p.BerichtBU420_ID,


                })
                .Where(p => p.Datum > DateTime.Now.AddMonths(-2))
                .ToListAsync()
            });
        }

        public async Task<IActionResult> GetDataActiontrackerForOverview(int id )
        {
            return Ok(new
            {
                data = await _context.Actiontracker.Select(p => new
                {

                    p.Action,
                    p.Priorität,
                    p.Von,
                    p.Bis,
                    p.Beschreibung,
                    p.Maßnahme,
                    p.ID,
                    p.Datum,
                    p.istabgeschlossen,
                    p.Overview_ID


                })
                .Where(p => p.Overview_ID == id)
                .ToListAsync()
            });
        }

        public async Task<IActionResult> GetDataBerichtBD420offen()
        {
            return Ok(new
            {
                data = await _context.BerichtBD420.Select(p => new
                {
                    p.ID,
                    p.schichtdatum,
                    p.schichttyp,
                    p.istfreigegeben,
                    p.istabgeschlossen

                })
                .Where(p => p.istabgeschlossen == "false" && p.istfreigegeben == "false" )
                .ToListAsync()
            });
        }

        public async Task<IActionResult> GetDataBerichtBD420abgeschlossen()
        {
            return Ok(new
            {
                data = await _context.BerichtBD420.Select(p => new
                {
                    p.ID,
                    p.schichtdatum,
                    p.schichttyp,
                    p.istfreigegeben,
                    p.istabgeschlossen


                })
                .Where(p => p.istabgeschlossen == "true" &&  p.istfreigegeben == "false" )
                .Where(p => p.schichtdatum > DateTime.Now.AddMonths(-2))
                .ToListAsync()
            });
        }

        public async Task<IActionResult> GetDataBerichtBD420freigeben()
        {
            return Ok(new
            {
                data = await _context.BerichtBD420.Select(p => new
                {
                    p.ID,

                    p.erstelltam,
                    p.erstelltvon,
                    p.zuletztbearbeitetam,
                    p.zuletztbearbeitetvon,
                    p.istfreigegeben,
                    p.istabgeschlossen,
                    p.schichtdatum,
                    p.schichttyp

                })
                .Where(p => p.istabgeschlossen == "true" && p.istfreigegeben == "true")
                //.Where(p => p.schichtdatum >= DateTime.)
                .ToListAsync()
            });
        }



        //ActionTracker
        public async Task<IActionResult> IndexActiontracker()
        {
            return View(await _context.Actiontracker.Where(p => p.istabgeschlossen != "true").ToListAsync());
        }
        public async Task<IActionResult> IndexActiontrackerabgeschlossen()
        {

            return View(await _context.Actiontracker.Where(p => (p.istabgeschlossen == "true") && (p.Datum > DateTime.Now.AddMonths(-2))).ToListAsync());

        }
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
        public IActionResult CreateActiontracker()
        {
            return View();
        }
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
            
            return View(actiontrackerModel);
        }
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
        [HttpPost,]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteActiontracker(int id)
        {
            var actiontrackerModel = await _context.Actiontracker.FindAsync(id);
            _context.Actiontracker.Remove(actiontrackerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexActiontracker));
        }



        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnBereich()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Bereich").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnAction()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Action").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }
        [AllowAnonymous]
        public async Task<IActionResult> GetDataDrpDwnPrioritaet()
        {

            return Ok(await _context.Dropdownoptions.Where(x => x.Selectbezeichnung == "Prioritaet").Select(x => new
            {

                name = x.Optionbezeichnung
            }).ToListAsync());
        }

        private bool ActiontrackerModelExists(int id)
        {
            return _context.Actiontracker.Any(e => e.ID == id);
        }
        private bool BerichtBD420Exists(int id)
        {
            return _context.BerichtBD420.Any(e => e.ID == id);
        }
        private bool OverviewExists(int id)
        {
            return _context.Overview.Any(e => e.ID == id);
        }
    }
}
