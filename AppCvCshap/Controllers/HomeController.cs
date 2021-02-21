using AppCvCshap.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppCvCshap.Controllers
{
    public class HomeController : Controller
    {
        string msg;
        //CRUD DESDE EL HOME
        public ActionResult CreateOrModifyCV()
        {
            CV cv = new CV();
            return View(cv);
        }
        
        //GUARDAR IMAGEN
        public ActionResult ImageUpload(HttpPostedFileBase fotito)
        {
            if (fotito != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                   
                    
                }
            }

        }

        [HttpPost]
        public ActionResult CreateOrModifyCV(CV modelcv)
        {
            if (ModelState.IsValid)
            {
                using (var context = new Contexto())
                {
                    msg = "Correcto";
                    context.CVsharp.Add(modelcv);
                    context.SaveChanges();
                }
                return View(msg);
            }
            else
            {
                return View(modelcv);
            }
        }
        //Conslultar datos
        public ActionResult ShowCV()
        {
            using (var context = new Contexto())
            {
                var data = context.CVsharp.ToList();
                ViewBag.Datos = data;
                return View(data);
            }
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: About
        public ActionResult About()
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
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
