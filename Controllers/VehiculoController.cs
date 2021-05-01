using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Identity;
using Models.Entities;
using Newtonsoft.Json;
using UruguayBus.Areas.Identity.Data;
using UruguayBus.conexiones;

namespace UruguayBus.Controllers
{
    [Authorize("admin")]
    public class VehiculoController : Controller
    {
        
        string Baseurl = "https://apprestproyectonet.azurewebsites.net/";
        // GET: VehiculoController
        ConexionesController api = new ConexionesController();

        public async Task<ActionResult> ListarVehiculosAsync()
        {
            var ret = await api.getVhiculos();
            return View(ret);
        }

        // GET: VehiculoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehiculoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehiculoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Vehiculo v)
        {
            try
            {
                List<Vehiculo> ret = new List<Vehiculo>();
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    // Agrega el header Accept: application/json para recibir la data como json  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var json = JsonConvert.SerializeObject(v);
                    var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json"); 

                    var response = await client.PostAsync("api/Vehiculo", stringContent);

                    return RedirectToAction("ListarVehiculos");
                }
            }
            catch
            {
                return RedirectToAction("ListarVehiculos");
            }
        }

        // GET: VehiculoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            Vehiculo ret = new Vehiculo();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var id2 = id.ToString();
                var response = await client.GetAsync("api/Vehiculo/" + id2);

                var aux = response.Content.ReadAsStringAsync().Result;
                // Lee el response y lo deserializa como un Product
                ret = JsonConvert.DeserializeObject<Vehiculo>(aux);

                return View(ret);
            }
        }

        // POST: VehiculoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Vehiculo v)
        {
            try
            {
                List<Vehiculo> ret = new List<Vehiculo>();
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    // Agrega el header Accept: application/json para recibir la data como json  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var json = JsonConvert.SerializeObject(v);
                    var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                    var response = await client.PutAsync("api/Vehiculo", stringContent);

                    return RedirectToAction("ListarVehiculos");
                }
            }
            catch
            {
                return RedirectToAction("ListarVehiculos");
            }
        }

        // GET: VehiculoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            Vehiculo ret = new Vehiculo();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var id2 = id.ToString();
                var response = await client.GetAsync("api/Vehiculo/"+id2);

                var aux = response.Content.ReadAsStringAsync().Result;
                // Lee el response y lo deserializa como un Product
                ret = JsonConvert.DeserializeObject<Vehiculo>(aux);

                return View(ret);
            }
        }

        // get: VehiculoController/Delete2/5
        public async Task<ActionResult> Delete2(int id)
        {
            try
            {
                List<Vehiculo> ret = new List<Vehiculo>();
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    // Agrega el header Accept: application/json para recibir la data como json  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var id2 = id.ToString();
                    var response = await client.DeleteAsync("api/Vehiculo/"+id2);

                    return RedirectToAction("ListarVehiculos");
                }
            }
            catch
            {
                return RedirectToAction("ListarVehiculos");
            }
        }
    }
}
