using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Entities;
using Models.Enums;
using UruguayBus.conexiones;
using UruguayBus.Data;

namespace UruguayBus.Controllers
{
    public class ViajeController : Controller
    {
        ConexionesController api = new ConexionesController();
        [BindProperty]
        public List<Dia> Selected { get; set; }
        // GET: ViajeController
        public ActionResult ListarViajes()
        {
            var ret = api.getViajes().Result;
            return View(ret);
        }

        // GET: ViajeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViajeController/Create
        public ActionResult Create()
        {
            var h = api.getHorarios().Result;
            var aux = new List<int>();
            var aux2 = 0;
            var aux3 = new List<Horario>();
            foreach (Horario element in h)
            {
               aux3.Add(element);
            }

            foreach (Horario element in h)
            {
                if(element.Viaje)
                {
                    aux.Add(aux2);
                }
                aux2 = aux2 + 1;
            }
            foreach (int element in aux)
            {
                aux3.RemoveAt(element);
            }

            var d = new List<Dia>();
            var d1 = new Dia();

            d1.idDia = 1;
            d1.nombre = "Lunes";
            d.Add(d1);

            var d2 = new Dia();
            d2.idDia = 2;
            d2.nombre = "Martes";
            d.Add(d2);

            var d3 = new Dia();
            d3.idDia = 3;
            d3.nombre = "Miercoles";
            d.Add(d3);

            var d4 = new Dia();
            d4.idDia = 4;
            d4.nombre = "Jueves";
            d.Add(d4);

            var d5 = new Dia();
            d5.idDia = 5;
            d5.nombre = "Viernes";
            d.Add(d5);

            var d6 = new Dia();
            d6.idDia = 6;
            d6.nombre = "Sabado";
            d.Add(d6);

            var d7 = new Dia();
            d7.idDia = 7;
            d7.nombre = "Domingo";
            d.Add(d6);

            ViewBag.HorariosList = new SelectList(aux3, "idHorario", "FullName");
            ViewBag.DiasList = new MultiSelectList(d, "idDia", "nombre");
            return View();
        }

        Temp T = Temp.Instance;
        [HttpPost]
        public void updateSelec([FromBody]string v)
        {
            var d = new List<Dia>();
            if(T.Selected != null)
            Selected = T.Selected;

            var d1 = new Dia();
            d1.idDia = 1;
            d1.nombre = "Lunes";
            d.Add(d1);

            var d2 = new Dia();
            d2.idDia = 2;
            d2.nombre = "Martes";
            d.Add(d2);

            var d3 = new Dia();
            d3.idDia = 3;
            d3.nombre = "Miercoles";
            d.Add(d3);

            var d4 = new Dia();
            d4.idDia = 4;
            d4.nombre = "Jueves";
            d.Add(d4);

            var d5 = new Dia();
            d5.idDia = 5;
            d5.nombre = "Viernes";
            d.Add(d5);

            var d6 = new Dia();
            d6.idDia = 6;
            d6.nombre = "Sabado";
            d.Add(d6);

            var d7 = new Dia();
            d7.idDia = 7;
            d7.nombre = "Domingo";
            d.Add(d6);

            int aux = 0;
            bool a = true;
            foreach (Dia element in Selected)
            {
                if (element.nombre == v)
                {
                    a = false;
                }
                else
                    aux = aux + 1;
            }
            if (!a)
            {
               T.Selected.RemoveAt(aux);
            }
            if (T.Selected != null)
                Selected = T.Selected;
            if (a)
            {
                foreach (Dia element2 in d)
                   if (v == element2.nombre)
                   {
                        Selected.Add(element2);
                        T.Selected = Selected;
                   }
            }
             

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DateTime fechaInicial, DateTime fechaFinal, int idHorario)
        {

            if (idHorario == 0)
            {
                ModelState.AddModelError("horario", "Debe seleccionar un horario");
            }

            var dto = new DtoViaje();
            dto.fechaInicial = fechaInicial;
            dto.fechaFinal = fechaFinal;
            dto.DiasViaje = T.Selected;
            dto.idHorario = idHorario;
            if (idHorario != 0 && T.Selected.Count != 0)
            {
                api.addViaje(dto);
                return RedirectToAction("ListarViajes");
            }
            else return RedirectToAction("Create");
        }

        // GET: ViajeController/Edit/5
        public ActionResult Edit(int id)
        {
            var v = api.getViaje(id).Result;
            var h = api.getHorarios().Result;
            ViewBag.VehiculoList = new SelectList(h, "idHorario", "FullName", v.Horario.idHorario);
            return View(v);
        }

        // POST: ViajeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Viaje v)
        {
            api.UpdateViaje(v);
            System.Threading.Thread.Sleep(1000);
            return RedirectToAction("ListarViajes");
        }

        // GET: ViajeController/Delete/5
        public ActionResult Delete(int id)
        {
            var v = api.getViaje(id).Result;
            ViewBag.id = id;
            return View(v);
        }

        // POST: ViajeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete2(int id)
        {
            api.DeleteViaje(id);
            System.Threading.Thread.Sleep(1000);
            return RedirectToAction("ListarViajes");
        }
    }
}
