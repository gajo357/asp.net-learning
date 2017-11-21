using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Treehouse.FitnessFrog.Data;
using Treehouse.FitnessFrog.Models;

namespace Treehouse.FitnessFrog.Controllers
{
    public class EntriesController : Controller
    {
        private EntriesRepository _entriesRepository = null;

        public EntriesController()
        {
            _entriesRepository = new EntriesRepository();
        }

        public ActionResult Index()
        {
            List<Entry> entries = _entriesRepository.GetEntries();

            // Calculate the total activity.
            double totalActivity = entries
                .Where(e => e.Exclude == false)
                .Sum(e => e.Duration);

            // Determine the number of days that have entries.
            int numberOfActiveDays = entries
                .Select(e => e.Date)
                .Distinct()
                .Count();

            ViewBag.TotalActivity = totalActivity;
            ViewBag.AverageDailyActivity = (totalActivity / (double)numberOfActiveDays);

            return View(entries);
        }

        public ActionResult Add()
        {
            var entry = new Entry()
            {
                Date = DateTime.Today
            };

            SelectActivitiesList();

            return View(entry); 
        }

        [ActionName(nameof(Add))]
        [HttpPost]
        public ActionResult AddPost(Entry entry)
        {
            if(ModelState.IsValid)
            {
                _entriesRepository.AddEntry(entry);

                SetTempDataMessage("Your data was successfully added!");
                return RedirectToAction(nameof(Index));
            }

            SelectActivitiesList();

            return View(entry);
        }

        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var entry = _entriesRepository.GetEntry(id.Value);
            if(entry == null)
            {
                return HttpNotFound();
            }

            SelectActivitiesList();

            return View(entry);
        }

        [HttpPost]
        public ActionResult Edit(Entry entry)
        {
            if (ModelState.IsValid)
            {
                _entriesRepository.UpdateEntry(entry);

                SetTempDataMessage("Your data was successfully edited!");
                return RedirectToAction(nameof(Index));
            }

            SelectActivitiesList();

            return View(entry);
        }

        public ActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var entry = _entriesRepository.GetEntry(id.Value);
            if (entry == null)
            {
                return HttpNotFound();
            }

            SelectActivitiesList();

            return View(entry);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _entriesRepository.DeleteEntry(id);

            SetTempDataMessage("Your data was successfully deleted!");
            return RedirectToAction(nameof(Index));
        }

        private void SetTempDataMessage(string message)
        {
            TempData["Message"] = message;
        }

        private void SelectActivitiesList()
        {
            ViewBag.ActivitiesSelectItemList = new SelectList(Data.Data.Activities, nameof(Activity.Id), nameof(Activity.Name));
        }
    }
}