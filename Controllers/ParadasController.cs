using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Newtonsoft.Json;

namespace UruguayBus.Controllers
{
    public class ParadasController : Controller
    {
        string Baseurl = "https://apprestproyectonet.azurewebsites.net/";
        // GET: ParadasController
        public async Task<ActionResult> ListarParadasAsync()
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
            return View(ret);
        }

        // GET: ParadasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ParadasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParadasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Parada p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    List<Parada> ret = new List<Parada>();
                    using (var client = new System.Net.Http.HttpClient())
                    {
                        client.BaseAddress = new Uri(Baseurl);
                        client.DefaultRequestHeaders.Accept.Clear();
                        // Agrega el header Accept: application/json para recibir la data como json  
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        var json = JsonConvert.SerializeObject(p);
                        var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                        var response = await client.PostAsync("api/Parada", stringContent);

                        return RedirectToAction("ListarParadas");
                    }
                }
                return View(p);
            }
            catch
            {
                return RedirectToAction("ListarParadas");
            }
        }

        // GET: ParadasController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            Parada ret = new Parada();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var id2 = id.ToString();
                var response = await client.GetAsync("api/Parada/" + id2);

                var aux = response.Content.ReadAsStringAsync().Result;
                // Lee el response y lo deserializa como un Product
                ret = JsonConvert.DeserializeObject<Parada>(aux);

                return View(ret);
            }
        }

        // POST: ParadasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Parada p)
        {
            try
            {
                List<Parada> ret = new List<Parada>();
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    // Agrega el header Accept: application/json para recibir la data como json  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var json = JsonConvert.SerializeObject(p);
                    var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                    var response = await client.PutAsync("api/Parada", stringContent);
                    Console.WriteLine(stringContent);
                    return RedirectToAction("ListarParadas");
                }
            }
            catch
            {
                return RedirectToAction("ListarParadas");
            }
        }

        // GET: ParadasController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            Parada ret = new Parada();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var id2 = id.ToString();
                var response = await client.GetAsync("api/Parada/" + id2);

                var aux = response.Content.ReadAsStringAsync().Result;
                // Lee el response y lo deserializa como un Product
                ret = JsonConvert.DeserializeObject<Parada>(aux);

                return View(ret);
            }
        }

        // POST: ParadasController/Delete/5
        public async Task<ActionResult> Delete2(int id)
        {
            try
            {
                List<Parada> ret = new List<Parada>();
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    // Agrega el header Accept: application/json para recibir la data como json  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var id2 = id.ToString();
                    var response = await client.DeleteAsync("api/Parada/" + id2);

                    return RedirectToAction("ListarParadas");
                }
            }
            catch
            {
                return RedirectToAction("ListarParadas");
            }
        }
    }
}
