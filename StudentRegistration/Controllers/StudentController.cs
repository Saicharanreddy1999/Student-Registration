using StudentRegistration.Models;
using StudentRegistration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegistration.Controllers
{
    public class StudentController : Controller
    {
        private IStudentData db;

        // GET: Student
        public StudentController(IStudentData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegDetails details)
        {
            if (ModelState.IsValid)
            {

                db.Add(details);
                return RedirectToAction("Index", "Student");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RegDetails details)
        {
            if (ModelState.IsValid)
            {
                db.Update(details);
                return RedirectToAction("Index",new { id=details.Id});
            }
            return View(details);
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var model=db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}