using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Newtonsoft.Json;

namespace UruguayBus.Controllers
{
    public class ReporteController : Controller
    {
        string Baseurl = "https://apprestproyectonet.azurewebsites.net/";
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PasajesVendidos()
        {
            ViewBag.agroupLinea = null;
            ViewBag.agroupHorario = null;
            if (TempData["horarios"] == null || TempData["lineas"] == null)
            {

                ViewBag.agroupLinea = null;
                ViewBag.agroupHorario = null;
            }
            else
            {
                List<ReporteRet> ret = new List<ReporteRet>();
                List<ReporteRet> ret2 = new List<ReporteRet>();
                List<ReporteRet> ret3 = new List<ReporteRet>();
                ret = JsonConvert.DeserializeObject<List<ReporteRet>>((string)TempData["lineas"]);
                ret2 = JsonConvert.DeserializeObject<List<ReporteRet>>((string)TempData["horarios"]);
                ret3 = JsonConvert.DeserializeObject<List<ReporteRet>>((string)TempData["sinfiltro"]);


                ViewBag.agroupLinea = ret;
                ViewBag.agroupHorario = ret2;
                ViewBag.sinfiltro = ret3;
            }

            return View();
        }

        public async Task<IActionResult> FiltrarPasajes(DateTime fecha1,DateTime fecha2)
        {

            Reporte rep = new Reporte();
            rep.tipo = "Pasajes";
            rep.fecha1 = fecha1;
            rep.fecha2 = fecha2;
            rep.filtro = "Linea";
            List<ReporteRet> ret = new List<ReporteRet>();
            List<ReporteRet> ret2 = new List<ReporteRet>();
            List<ReporteRet> ret3 = new List<ReporteRet>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Filtrado por linea
                var json = JsonConvert.SerializeObject(rep);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response = await client.PostAsync("api/Viaje/Reportes", stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var aux = response.Content.ReadAsStringAsync().Result;
                    ret = JsonConvert.DeserializeObject<List<ReporteRet>>(aux);

                }
                TempData["lineas"] = JsonConvert.SerializeObject(ret);

                //Filtrado por Horario
                rep.filtro = "Horario";
                var json2 = JsonConvert.SerializeObject(rep);
                var stringContent2 = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response2 = await client.PostAsync("api/Viaje/Reportes", stringContent);
                if (response2.IsSuccessStatusCode)
                {
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<ReporteRet>>(aux2);

                }
                TempData["horarios"] = JsonConvert.SerializeObject(ret2);

                //Sin filtrado
                rep.filtro = "asdasdasd";
                var json3 = JsonConvert.SerializeObject(rep);
                var stringContent3 = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response3 = await client.PostAsync("api/Viaje/Reportes", stringContent);
                if (response3.IsSuccessStatusCode)
                {
                    var aux3 = response3.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret3 = JsonConvert.DeserializeObject<List<ReporteRet>>(aux3);

                }
                TempData["sinfiltro"] = JsonConvert.SerializeObject(ret3);
            }
            return View("PasajesVendidos");
        }

        public IActionResult EstadisticasViajes()
        {
            ViewBag.agroupLinea = null;
            ViewBag.agroupHorario = null;
            if (TempData["horariosRe"] == null || TempData["lineasRE"] == null)
            {

                ViewBag.agroupLinea = null;
                ViewBag.agroupHorario = null;
            }
            else
            {
                List<ReporteRet> ret = new List<ReporteRet>();
                List<ReporteRet> ret2 = new List<ReporteRet>();
                List<ReporteRet> ret3 = new List<ReporteRet>();
                List<ReporteRet> ret4 = new List<ReporteRet>();
                ret = JsonConvert.DeserializeObject<List<ReporteRet>>((string)TempData["lineasRE"]);
                ret2 = JsonConvert.DeserializeObject<List<ReporteRet>>((string)TempData["horariosRE"]);
                ret3 = JsonConvert.DeserializeObject<List<ReporteRet>>((string)TempData["sinfiltroRE"]);
                ret4 = JsonConvert.DeserializeObject<List<ReporteRet>>((string)TempData["desViajeRE"]);

                ViewBag.agroupLinea = ret;
                ViewBag.agroupHorario = ret2;
                ViewBag.sinfiltro = ret3;
                ViewBag.desViaje = ret4;
            }
            return View();
        }
        public async Task<IActionResult> FiltrarViajes(DateTime fecha1, DateTime fecha2)
        {

            Reporte rep = new Reporte();
            rep.tipo = "Viajes";
            rep.fecha1 = fecha1;
            rep.fecha2 = fecha2;
            rep.filtro = "Linea";
            List<ReporteRet> ret = new List<ReporteRet>();
            List<ReporteRet> ret2 = new List<ReporteRet>();
            List<ReporteRet> ret3 = new List<ReporteRet>();
            List<ReporteRet> ret4 = new List<ReporteRet>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Filtrado por linea
                var json = JsonConvert.SerializeObject(rep);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response = await client.PostAsync("api/Viaje/Reportes", stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var aux = response.Content.ReadAsStringAsync().Result;
                    ret = JsonConvert.DeserializeObject<List<ReporteRet>>(aux);

                }
                TempData["lineasRE"] = JsonConvert.SerializeObject(ret);

                //Filtrado por Horario
                rep.filtro = "Horario";
                var json2 = JsonConvert.SerializeObject(rep);
                var stringContent2 = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response2 = await client.PostAsync("api/Viaje/Reportes", stringContent);
                if (response2.IsSuccessStatusCode)
                {
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<ReporteRet>>(aux2);

                }
                TempData["horariosRE"] = JsonConvert.SerializeObject(ret2);

                //Sin filtrado
                rep.filtro = "asdasdasd";
                var json3 = JsonConvert.SerializeObject(rep);
                var stringContent3 = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response3 = await client.PostAsync("api/Viaje/Reportes", stringContent);
                if (response3.IsSuccessStatusCode)
                {
                    var aux3 = response3.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret3 = JsonConvert.DeserializeObject<List<ReporteRet>>(aux3);

                }
                TempData["sinfiltroRE"] = JsonConvert.SerializeObject(ret3);

                //Sin filtrado
                rep.tipo = "sadasddas";
                rep.filtro = "asdasdasd";
                var json4 = JsonConvert.SerializeObject(rep);
                var stringContent4 = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response4 = await client.PostAsync("api/Viaje/Reportes", stringContent);
                if (response4.IsSuccessStatusCode)
                {
                    var aux4 = response4.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret4 = JsonConvert.DeserializeObject<List<ReporteRet>>(aux4);

                }
                TempData["desViajeRE"] = JsonConvert.SerializeObject(ret4);
            }

            return View("EstadisticasViajes");
        }
    }
}
