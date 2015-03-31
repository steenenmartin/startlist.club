﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using FlightJournal.Web.Models;

namespace FlightJournal.Web.Controllers
{
    [Authorize(Roles = "Administrator,Manager,Editor")]
    public class LocationController : Controller
    {
        private FlightContext db = new FlightContext();

        //
        // GET: /Location/

        public ViewResult Index()
        {
            return View(db.Locations.OrderBy(t=>t.Name).ToList());
        }

        //
        // GET: /Location/Details/5

        public ViewResult Details(int id)
        {
            Location location = db.Locations.Find(id);
            return View(location);
        }

        //
        // GET: /Location/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Location/Create

        [HttpPost]
        public ActionResult Create(Location location)
        {
            if (ModelState.IsValid)
            {
                db.Locations.Add(location);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(location);
        }
        
        //
        // GET: /Location/Edit/5
 
        public ActionResult Edit(int id)
        {
            Location location = db.Locations.Find(id);
            return View(location);
        }

        //
        // POST: /Location/Edit/5

        [HttpPost]
        public ActionResult Edit(Location location)
        {
            if (ModelState.IsValid)
            {
                db.Entry(location).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(location);
        }

        //
        // GET: /Location/Delete/5
 
        public ActionResult Delete(int id)
        {
            Location location = db.Locations.Find(id);

            if (db.Flights.Any(f => f.StartedFromId == id || f.LandedOnId == id))
            {
                return View("DeleteLocked",location);
            }

            return View(location);
        }

        //
        // POST: /Location/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Location location = db.Locations.Find(id);
            db.Locations.Remove(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}