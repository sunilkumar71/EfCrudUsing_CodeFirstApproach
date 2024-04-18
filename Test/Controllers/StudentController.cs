using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class StudentController : Controller
    {
        StudentDbContect Db = new StudentDbContect();
        #region index
        public ActionResult Index()
        {
             var std = Db.Students.ToList();
            //Student stu = Db.Students.;

            return View(std);
        }
        #endregion

        #region Add Student
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Create(Student std)
        {
            try
            {
                Db.Students.Add(std);
                Db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            
                return RedirectToAction("Index");
         }
        #endregion

        #region details
        public ActionResult Details(int id)
        {
            
            var std = Db.Students.Where(x=>x.Id==id).FirstOrDefault();

            return View(std);
        }
        #endregion

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = Db.Students.Where(x => x.Id == id).FirstOrDefault();
            return View(std);
            //
            //
        }

        [HttpPost]
        public RedirectToRouteResult Edit(Student st )
        {
            Db.Students.AddOrUpdate(st);
            Db.SaveChanges();
            return  RedirectToAction("Index");
        }

        
        public ActionResult Delete(int? id)
        {
           var std= Db.Students.Where(x=>x.Id==id).FirstOrDefault();
            return View(std);
        }

        [HttpPost]

        public RedirectToRouteResult Delete(Student std)
        {
            Db.Entry(std).State = EntityState.Deleted;
           //Db.Students.Remove(Id);
            Db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        


    }
}