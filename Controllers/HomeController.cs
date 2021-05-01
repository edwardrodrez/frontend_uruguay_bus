using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Models.Entities;
using Models.Enums;
using Newtonsoft.Json;
using UruguayBus.conexiones;
using UruguayBus.Data;
using UruguayBus.Models;

namespace UruguayBus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ConexionesController api = new ConexionesController();
        string Baseurl = "https://apprestproyectonet.azurewebsites.net/";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ComprarPasaje()
        {
            var paradas = api.GetParadas().Result;
            ViewBag.ListaParadas = new SelectList(paradas, "idParada","nombre");
            List<string> tioposDeDocumento= new List<string> (){ "CI","OTRO"};
            ViewBag.listTipoDocumento = new SelectList(tioposDeDocumento);
            return View();
        }
        public  IActionResult SeleccionarViaje(DateTime fecha,int origen,int fin)
        {
       
            ViewBag.origen = origen;
            ViewBag.fin = fin;
            ViewBag.fecha = fecha;
         
            TempData["origen"] = origen;
            TempData["fin"] = fin;
            TempData["fecha"] = fecha;
            TempData["idAsiento"]=0;
            DtoViajePasaje dt = new DtoViajePasaje
            {
                origen = origen,
                fin = fin,
                fecha = fecha
                
            };
            var viajes =  api.ViajesPasaje(dt).Result;

            ViewBag.viajes = viajes;
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        Temp t = Temp.Instance;
        [HttpPost]
        public IActionResult process_payment(String token, int installments, String payment_method_id, String issuer_id)
        {
            int idUsuario = 0;
            if (t.Usauario != null){
            idUsuario = int.Parse(t.Usauario.Id);
            }
            else
            {
                return View("ComprarPasaje");
            }
            DtoComprarPasaje env = new DtoComprarPasaje
            {
                destino = (int)TempData["fin"],
                origen = (int)TempData["origen"],
                fecha = (DateTime)TempData["fecha"],
                idusuario = idUsuario,
                idviaje = (int)TempData["idViaje"],
                transaction_amount = TempData["precio"].ToString(),
                installments = installments,
                issuer_id = issuer_id,
                payment_method_id = payment_method_id,
                plataforma = "web",
                token = token,
                idAsiento = (int)TempData["idAsiento"]
            };
            TempData["bol"] = api.ComprarPasaje(env).Result;

            return RedirectToAction("datos");
        }

        public IActionResult datos()
        {
            return View();
        }
        [HttpPost]

        public void SetTempData([FromBody] String tempDataValue)
        {
            // Set your TempData key to the value passed in
            int va = Int32.Parse( tempDataValue);
            TempData["idAsiento"] = va;
        }
        public async Task<IActionResult> VehiculosPorParada(int id)
        {


            DtoProximoVehiculo dto = new DtoProximoVehiculo();
            List<DtoProximoVehiculoRet> ret = new List<DtoProximoVehiculoRet>();
            dto.idUsuario = 1;
            dto.idParada = id;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(dto);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PostAsync("api/Viaje/ProximosVehiculos/", stringContent);

                // Si el servicio responde correctamente
                if (response.IsSuccessStatusCode)
                {
                    var aux = response.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret = JsonConvert.DeserializeObject<List<DtoProximoVehiculoRet>>(aux);
                }
            }

            ViewBag.vehiculos = ret;
            return View();
        }

        public async Task<IActionResult> ProximidadVehiculos()

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
            ViewBag.paradas = ret;


            return View();
        }
    }

}


