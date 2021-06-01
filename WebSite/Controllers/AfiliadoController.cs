using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Business;
using WebSite.Entities.Models;

namespace WebSite.Controllers
{
    public class AfiliadoController : Controller
    {
        // GET: Afiliado
        public ActionResult Index()
        {
            var biz = new AfiliadoBiz();
            var model = biz.Listar();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Afiliado model)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                var biz = new AfiliadoBiz();
                biz.Agregar(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var biz = new AfiliadoBiz();
            var model = biz.TraerAfiliado(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Afiliado model)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                var biz = new AfiliadoBiz();
                biz.Actualizar(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(model);
            }
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var biz = new AfiliadoBiz();
            var model = biz.TraerAfiliado(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Afiliado model)
        {
            var biz = new AfiliadoBiz();
            biz.Eliminar(model);
            return RedirectToAction("Index");
        }
    }
}