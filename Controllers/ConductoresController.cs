using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Share.Entities;
using UruguayBus.conexiones;

namespace UruguayBus.Controllers
{
    public class ConductoresController : Controller
    {
        // GET: ConductoresController
        ConexionesController api = new ConexionesController();
        public ActionResult ListarConductores()
        {
            var ret = api.getConductores().Result;
            return View(ret);
        }

        // GET: ConductoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConductoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConductoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConductoresController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.id = id;
            return View();
        }

        // POST: ConductoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(String idusuario, String fechalibreta)
        {
            try
            {
                DtoRoles r = new DtoRoles();
                r.idusuario = idusuario;
                r.fechaLibreta = fechalibreta;
                r.rol = "Conductor";
                api.CambiarRol(r);
                return RedirectToAction("ListarConductores");
            }
            catch
            {
                return RedirectToAction("ListarConductores");
            }
        }

        // GET: ConductoresController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.id = id;
            return View();
        }

        // POST: ConductoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(String idusuario)
        {
            try
            {
                DtoRoles r = new DtoRoles();
                r.idusuario = idusuario;
                r.fechaLibreta = "2019-01-06T07:16:40";
                r.rol = "User";
                api.CambiarRol(r);
                return RedirectToAction("ListarConductores");
            }
            catch
            {
                return RedirectToAction("ListarConductores");
            }
        }
    }
}
