using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Entities;
using UruguayBus.conexiones;

namespace UruguayBus.Controllers
{
    public class HorariosController : Controller
    {
        ConexionesController api = new ConexionesController();
        // GET: HorariosController
        public ActionResult ListarHorarios()
        {
            var ret = api.getHorarios().Result;
            return View(ret);
        }

        // GET: HorariosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HorariosController/Create
        public ActionResult Create()
        {
            var v = api.getVhiculos().Result;
            var l = api.getlineaAll().Result;
            var c = api.getConductores().Result;
            ViewBag.VehiculoList = new SelectList(v, "idVehiculo", "matricula");
            ViewBag.lineaList = new SelectList(l, "idLinea", "nombre");
            ViewBag.conductoresList = new SelectList(c, "idUsuario", "FullName");
            return View();
        }
        
        // POST: HorariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DateTime hora, int idlinea, int idvehiculo, int idusuario)
        {
             var dt = new DtoHorario();
             dt.hora = hora;
             dt.idlinea = idlinea;
             dt.idvehiculo = idvehiculo;
             dt.idusuario = idusuario;
             api.addHorario(dt);
             return RedirectToAction("ListarHorarios");
        }

        // GET: HorariosController/Edit/5
        public ActionResult Edit(int id)
        {
            var h = api.getHorario(id).Result;
            var v = api.getVhiculos().Result;
            var l = api.getlineaAll().Result;
            var c = api.getConductores().Result;
            ViewBag.VehiculoList = new SelectList(v, "idVehiculo", "matricula",h.vehiculo.idVehiculo);
            ViewBag.lineaList = new SelectList(l, "idLinea", "nombre",h.linea.idLinea);
            ViewBag.conductoresList = new SelectList(c, "idUsuario", "FullName",h.usuario.idUsuario);
            return View(h);
        }

        // POST: HorariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Horario h,int idlinea, int idvehiculo, int idusuario)
        {
            api.UpdateHorario(h);
            api.UpdateLineaHorario(idlinea, h.idHorario);
            api.UpdateUsuarioHorario(idusuario, h.idHorario);
            api.UpdateVehiculoHorario(idvehiculo, h.idHorario);
            System.Threading.Thread.Sleep(1000);
            return RedirectToAction("ListarHorarios");
        }

        // GET: HorariosController/Delete/5
        public ActionResult Delete(int id)
        {
            var h = api.getHorario(id).Result;
            ViewBag.id = id;
            return View(h);
        }

        // POST: HorariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete2(int id)
        {
            api.DeleteHorario(id);
            System.Threading.Thread.Sleep(1000);
            return RedirectToAction("ListarHorarios");
        }
    }
}
