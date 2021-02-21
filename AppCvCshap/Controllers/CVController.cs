using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppCvCshap.Controllers
{
    public class CVController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {   
            return View();
        }
        //CRUD
        public ActionResult CrearyModificarCV()
        {
            return View();
        }
    }
}