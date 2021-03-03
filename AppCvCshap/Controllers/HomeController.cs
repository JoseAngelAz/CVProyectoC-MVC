using AppCvCshap.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;

namespace AppCvCshap.Controllers
{
    public class HomeController : Controller
    {
        string msg;
        //CRUD DESDE EL HOME
        public ActionResult CreateOrModifyCV(int? id)
        {
            if (id > 0)
            {
                using (var context = new Contexto())
                {
                    var model = context.CVsharp.Find(id);
                    return View(model);
                }
            }
            else
            {
                CV cv = new CV();
                return View(cv);
            }
        }
        
        //GUARDAR IMAGEN
        public ActionResult ImageUpload(HttpPostedFileBase fotito)
        {
            if (fotito != null)
            {
                using (var context = new Contexto())
                {
                   // var model = context.datos_personales.Where(c=> c.Id == fotito)
                    return View();
                    
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateOrModifyCV(CV modelcv)
        {
            
            if (ModelState.IsValid)
            {   //si es valido
                bool isnew = modelcv.idCv == 0 ? true : false;
                if (isnew)
                {
                    using (var context = new Contexto())
                    {
                        context.CVsharp.Add(modelcv);
                        context.SaveChanges();
                    }
                    return View("Correcto");
                }
                else {
                    using (var context = new Contexto())
                    {   //UPDATE
                        var data = context.CVsharp.Where(x => x.idCv == modelcv.idCv).FirstOrDefault();
                        //datos personales
                        data.nombre = modelcv.nombre;
                        data.apellido = modelcv.apellido;
                        data.edad = modelcv.edad;
                        data.email = modelcv.email;
                        data.telefono = modelcv.telefono;
                        data.direccion = modelcv.direccion;
                        data.dui = modelcv.dui;
                        data.nit = modelcv.nit;
                        data.PaginaWeb  = modelcv.PaginaWeb;
                        //curos
                        data.Curso = modelcv.Curso;
                        data.DescripcionCurso = modelcv.DescripcionCurso;
                        //educacion
                        data.LugarEducacion = modelcv.LugarEducacion;
                        data.descripcion_educacion = modelcv.descripcion_educacion;
                        //competencias profesionales
                        data.competenciasProfesionales = modelcv.competenciasProfesionales;
                        //experiencia laboral
                        data.Cargo_exp = modelcv.Cargo_exp;
                        data.Descripcion_exp = modelcv.Descripcion_exp;
                        //formacion tecnica
                        data.FormacionTecnica = modelcv.FormacionTecnica;
                        data.DescripcionFT = modelcv.DescripcionFT;
                        //referencias personales
                        data.ref_PERSONAL_UNO = modelcv.ref_PERSONAL_UNO;
                        data.telefono_ref_PERSONAL_uno = modelcv.telefono_ref_PERSONAL_uno;
                        
                        data.ref_PERSONAL_DOS = modelcv.ref_PERSONAL_DOS;
                        data.telefono_ref_PERSONAL_dos = modelcv.telefono_ref_PERSONAL_dos;
                        //referencias profesionales
                        data.ref_prof_uno = modelcv.ref_prof_uno;
                        data.telefono_uno_profesional = modelcv.telefono_uno_profesional;
                        
                        data.ref_prof_dos = modelcv.ref_prof_dos;
                        data.telefono_dos_profesional = modelcv.telefono_dos_profesional;

                        //objetivo del CV#
                        data.objetivoCV = modelcv.objetivoCV;
                        context.SaveChanges();
                    }
                }
                return View("Correcto");
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
                //var data = context.CVsharp.Last();
                var data = context.CVsharp.ToList();
                ViewBag.Datos = data;

                return View(data);
            }
        }
        //Conslultar datosBYID
        public ActionResult ShowCVById(int? id)
        {
            using (var context = new Contexto())
            {
                var cvsharp = context.CVsharp.Where(x => x.idCv == id).ToList();
                ViewBag.Datos = cvsharp;
                return View();
                
            }
        }
        //ELIMINAR CV
        public ActionResult DeleteCV(int idCv)
        {
            using(var context = new Contexto())
            {
                var data = context.CVsharp.Where(c => c.idCv == idCv).FirstOrDefault();
                context.CVsharp.Remove(data);
                context.SaveChanges();
                return View();
            }
        }
        //ELIMINAR CV por ID
        public ActionResult DeleteCVById(int id)
        {
            using (var context = new Contexto())
            {
                var data = context.CVsharp.Find(id);
                context.CVsharp.Remove(data);
                context.SaveChanges();
                return View("Index");
            }
        }
        //EXPORTAR COMO PDF por ID
        public ActionResult ExportarCVPDFById(int? id)
        {
            using (var context = new Contexto())
            {
                var cv = context.CVsharp.Where(x => x.idCv == id).ToList();
                //se envia a la vista
                ViewBag.cv = cv;
            }
            //hacia donde se envia la vista del PDF
            return new ViewAsPdf("CV_PDF")
            {
                //PageSize = Rotativa.Options.Size.A4,
                //PageMargins = new Rotativa.Options.Margins(10, 15, 10, 15),
                FileName = "CV#.pdf"
            };
        }
        //EXPORTAR COMO PDF
        public ActionResult ExportarCVPDF(int id)
        {
            using(var context = new Contexto())
            {
                var lista = context.CVsharp.Find(id);
                //se envia a la vista
                ViewBag.lista = lista;
            }
            //hacia donde se envia la vista del PDF
            return new ViewAsPdf("CV_PDF")
            {
                PageSize = Rotativa.Options.Size.A4,
                PageMargins = new Rotativa.Options.Margins(10, 15, 10, 15),
                FileName = "CV#.pdf"
            };
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
