using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Identity;
using Models.Entities;
using Newtonsoft.Json;
using UruguayBus.conexiones;

namespace UruguayBus.Controllers
{
    public class LineaController : Controller
    {
        // GET: LineaController
        string Baseurl = "https://apprestproyectonet.azurewebsites.net/";

        ConexionesController api = new ConexionesController();
        public async Task<ActionResult> ListarLineas()
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Hace la llamada a http://url-base-del-api/api/products/<id>
                var response = await client.GetAsync("api/Linea");

                // Si el servicio responde correctamente
                if (response.IsSuccessStatusCode)
                {
                    var aux = response.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret = JsonConvert.DeserializeObject<List<Linea>>(aux);
                }
            }
            return View(ret);
        }

        // GET: LineaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LineaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Linea l)
        {
            try
            {
                List<Linea> ret = new List<Linea>();
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    // Agrega el header Accept: application/json para recibir la data como json  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var json = JsonConvert.SerializeObject(l);
                    var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                    var response = await client.PostAsync("api/Linea", stringContent);

                    return RedirectToAction("ListarLineas");
                }
            }
            catch
            {
                return RedirectToAction("ListarLineas");
            }
        }
        public async Task<ActionResult> addParada(int id)
        {
            Parada ret = new Parada();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Hace la llamada a http://url-base-del-api/api/products/<id>
                var id2 = id.ToString();
                var response = await client.GetAsync("api/Linea/UltimaParada/" + id2);

                // Si el servicio responde correctamente
                if (response.IsSuccessStatusCode)
                {
                    var aux = response.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret = JsonConvert.DeserializeObject<Parada>(aux);
                }

                List<Parada> ret2 = new List<Parada>();
                {
                    var response2 = await client.GetAsync("api/Parada");

                    // Si el servicio responde correctamente
                    if (response2.IsSuccessStatusCode)
                    {
                        var aux = response2.Content.ReadAsStringAsync().Result;
                        // Lee el response y lo deserializa como un Product
                        ret2 = JsonConvert.DeserializeObject<List<Parada>>(aux);
                    }
                }
                var cont = 0;
                var au = false;
                if (ret != null)
                {
                    foreach (var item in ret2)
                    {
                        if (item.idParada == ret.idParada)
                        {
                            au = true;
                            break;
                        }
                        cont = cont + 1;
                    }
                    if (au)
                    {
                        ret2.RemoveAt(cont);
                    }
                }
                ViewBag.ParadasList = new SelectList(ret2, "idParada", "nombre");
                ViewBag.idlinea = id;
                ViewBag.paradaAnterior = ret;
                return View();
            }
        }

        public async Task<ActionResult> VerParadas(int id)
        {
            List<Parada> ret = new List<Parada>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Hace la llamada a http://url-base-del-api/api/products/<id>
                var id2 = id.ToString();
                var response = await client.GetAsync("api/Linea/Paradas/"+ id2);

                if (response.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux = response.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret = JsonConvert.DeserializeObject<List<Parada>>(aux);

                }
                var response2 = await client.GetAsync("api/Linea/" + id2);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    Linea ret2 = JsonConvert.DeserializeObject<Linea>(aux2);
                    ViewBag.paradaAnterior = ret2.ParadaAnterior;
                }
                ViewBag.paradas = ret;
                ViewBag.idLinea = id;
                return View(ret);
            }
        }

        public ActionResult VerPrecios(int id)
        {
                var ret = api.getPrecios(id);
                List<Precios> re2 = ret.Result;
                ViewBag.idParadaAnteriror = id;
                re2.Reverse();
                return View(re2);
            
        }

        public ActionResult addPrecios(int id)
        {
            ViewBag.idParadaAnteriror = id;
            return View();
        }

        public ActionResult addPrecios2(int idparadaAnterior,int precio, DateTime FechaCaducidad)
        {
            var ret = new DtoPrecio();
            ret.idparadaAnterior = idparadaAnterior;
            ret.precio = precio;
            ret.FechaCaducidad = FechaCaducidad;
            api.addPrecio(ret);
            var id2 = idparadaAnterior.ToString();
            return RedirectToAction("VerPrecios/" + id2);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> addParada2(string Tiempo, int Precio, string FechaDeCaducidad, int ParadaSiguiente, int idlinea)
        {
            try
            {
                List<Linea> ret = new List<Linea>();
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    // Agrega el header Accept: application/json para recibir la data como json  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    DTOaddParada dto = new DTOaddParada();
                    dto.idlinea = idlinea;
                    dto.idParada = ParadaSiguiente;
                    dto.tiempo = Tiempo;
                    dto.precio = Precio;
                    if(FechaDeCaducidad == null)
                    {
                        dto.fechacaducidad = "2026-10-23T10:16:40";
                        dto.tiempo = "2026-10-23T00:00:00";
                        dto.precio = 0;
                    }
                    else
                    {
                        dto.fechacaducidad = FechaDeCaducidad;
                    }
                    

                    var json = JsonConvert.SerializeObject(dto);
                    var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                    var response = await client.PostAsync("api/Linea/AddParada", stringContent);
                    var id2 = idlinea.ToString();

                    return RedirectToAction("ListarLineas");
                }
            }
            catch
            {
                return RedirectToAction("ListarLineas");
            }
        }

        private async void ParadasList(object selectedDepartment = null)
        {
            List<Parada> ret = new List<Parada>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Hace la llamada a http://url-base-del-api/api/products/<id>
                var response = await client.GetAsync("api/Parada");

                // Si el servicio responde correctamente
                if (response.IsSuccessStatusCode)
                {
                    var aux = response.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret = JsonConvert.DeserializeObject<List<Parada>>(aux);
                }
            }

            ViewBag.ParadasList = new SelectList(ret, "idParada", "nombre", selectedDepartment);
        }

        // GET: LineaController/Edit/5
        public ActionResult Edit(int id)
        {
            var ret = api.getLinea(id);
            Linea l = ret.Result;
            return View(l);
        }

        // POST: LineaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Linea l)
        {
            api.UpdateLineas(l);
            System.Threading.Thread.Sleep(1500);
            return RedirectToAction("ListarLineas");
        }

        // GET: LineaController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.id = id;
            var ret = api.getLinea(id);
            return View(ret.Result);
        }

        // POST: LineaController/Delete/5
        public ActionResult Delete2(int id)
        {
            api.DeleteLineas(id);
            System.Threading.Thread.Sleep(1500);
            return RedirectToAction("ListarLineas");
        }
    }
}
