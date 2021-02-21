using AppCvCshap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppCvCshap.Controllers
{
    public class CVController : Controller
    {
        string msg;

        // GET: Index
        public ActionResult Index()
        {   
            return View();
        }
        //CRUD
        public ActionResult CrearyModificarCV()
        {
            CV cv = new CV();
            return View(cv);
        }
        
        [HttpPost]
        public ActionResult CrearyModificarCV(CV modelcv)
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
        public ActionResult MostrarCV()
        {
            using(var context = new Contexto())
            {
                var data = context.CVsharp.ToList();
                ViewBag.Datos = data;
                return View(data);
            }
        }
    }
}