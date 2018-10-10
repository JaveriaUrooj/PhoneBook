using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using PhoneBook1.Models;

namespace PhoneBook1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
            List<Person> list = db.People.ToList();
            List<PersonViewModel> viewlist = new List<PersonViewModel>();
            foreach(Person p in list)
            {
                PersonViewModel obj = new PersonViewModel();
                obj.personId = p.PersonId;
                obj.FirstName = p.FirstName;
                obj.MiddleName = p.MiddleName;
                obj.LastName = p.LastName;
                obj.DteOfBirth = p.DateOfBirth;
                obj.AddedOn = p.AddedOn;
                obj.AdddedBy = p.AddedBy;
                obj.HomeAddress = p.HomeAddress;
                obj.HomeCity = p.HomeCity;
                obj.FacBookAccountId = p.FaceBookAccountId;
                obj.UpdateOn = p.UpdateOn;
                obj.ImagePath = p.ImagePath;
                obj.LinkedInId = p.LinkedInId;
                obj.TwitterId = p.TwitterId;
                obj.EmailId = p.EmailId;

                viewlist.Add(obj);

            }
            return View(viewlist);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person collection)
        {
            try
            {
                PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
                Person obj = new Person();
                obj.PersonId = collection.PersonId;
                obj.FirstName = collection.FirstName;
                obj.MiddleName = collection.MiddleName;
                obj.LastName = collection.LastName;
                obj.DateOfBirth = collection.DateOfBirth;
                obj.AddedOn = collection.AddedOn;
                obj.AddedBy = collection.AddedBy;
                obj.HomeAddress = collection.HomeAddress;
                obj.HomeCity = collection.HomeCity;
                obj.FaceBookAccountId = collection.FaceBookAccountId;
                obj.UpdateOn = collection.UpdateOn;
                obj.ImagePath = collection.ImagePath;
                obj.LinkedInId = collection.LinkedInId;
                obj.TwitterId = collection.TwitterId;
                obj.EmailId = collection.EmailId;
                obj.AddedBy = User.Identity.GetUserId();
                db.People.Add(obj);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Person collection)
        {
            try
            {
                //PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
                //Person obj = db.People.Find(id);
                
                
                //db.People.Remove(obj);
                //db.SaveChanges();

                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
