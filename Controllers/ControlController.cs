using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Models.Entities;
using Newtonsoft.Json;
using Share.Entities;
using UruguayBus.Areas.Identity.Data;
using UruguayBus.conexiones;
using UruguayBus.Data;
using UruguayBus.Hubs;

namespace UruguayBus.Controllers
{
    public class ControlController : Controller
    {
        ConexionesController api = new ConexionesController();

        string Baseurl = "https://apprestproyectonet.azurewebsites.net/";
        private IHubContext<ChatHub> HubContext
        { get; set; }
        public ControlController(IHubContext<ChatHub> hubcontext)
        {
            this.HubContext = hubcontext;


        }
        public string LabelText { get; set; } = "No hay Registro";

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task SiguienteParadaAsync(int id)
        {
            List<string> notificaciones = new List<string>();
            string ret = api.SiguienteParada(id).Result;
            notificaciones.Add(ret);
            TempData["notificaciones"] = notificaciones;
            await this.HubContext.Clients.All.SendAsync("ReceiveMessage", notificaciones);
            Response.Redirect("PanelDeControlVehiculos", false);

        }
        Temp t = Temp.Instance;
        public async Task<ActionResult> Comienzo(int id)
        {

            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var id2 = id.ToString();
                await client.GetAsync("api/Viaje/ComensarViaje/" + id2);
                await Task.Delay(7000);
                
                if(t.Usauario != null)
                {
                    viajeConductor v = new viajeConductor();
                    v.idviaje = id;
                    v.key = t.Usauario.UserName;
                    t.addviajeConductor(v);
                }
                else
                {
                    return View("Index");
                }



                return View("VerificadorDePasajes");
            }
        }

        public IActionResult PanelDeControlVehiculos()
        {
            var viajes = api.ViajesControl().Result;
            var paradas = api.GetParadas().Result;
            ViewBag.viajes = viajes;
            ViewBag.paradas = paradas;
            return View();
        }

        public IActionResult VerificadorDePasajes(DtoValidarRet valret)
        {

            valret.mensaje = "Esperando respuesta";
            valret.valido = false;
            return View(valret);

        }

        public async Task<IActionResult> Verificar(string qr)
        {
            DtoValidar val = new DtoValidar();
            DtoValidarRet valret = new DtoValidarRet();
            if (t.Usauario != null)
            {
                val.idViaje = t.getviajeConductor(t.Usauario.UserName).idviaje;
            }
            else
            {
                return View("Index");
            }
            val.qr = qr;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(val);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PostAsync("ValidarPasaje", stringContent);

                // Si el servicio responde correctamente
                if (response.IsSuccessStatusCode)
                {
                    var aux = response.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    valret = JsonConvert.DeserializeObject<DtoValidarRet>(aux);
                }
            }

            ViewBag.mensaje = valret.mensaje;
            ViewBag.valido = valret.valido;

            return new JsonResult(valret);
        }

        public async Task<ActionResult> ComienzoDeViaje(int id)
        {
            List<Viaje> ret = new List<Viaje>();
            if (t.Usauario != null)
            {
                id = int.Parse(t.Usauario.Id);
            }
            else
            {
                return View("Index");
            }
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Hace la llamada a http://url-base-del-api/api/products/<id>
                var id2 = id.ToString();
                var response = await client.GetAsync("api/Viaje/ViajesChofer/" + id2);

                // Si el servicio responde correctamente
                if (response.IsSuccessStatusCode)
                {
                    var aux = response.Content.ReadAsStringAsync().Result;

                    var root = JsonConvert.DeserializeObject<List<Viaje>>(aux);
                    foreach (var item in root)
                    {
                        Viaje listItem = new Viaje();
                        listItem.idViaje = item.idViaje;
                        listItem.asientos = item.asientos;
                        listItem.fechaFinal = item.fechaFinal;
                        listItem.fechaInicial = item.fechaInicial;
                        listItem.Horario = item.Horario;
                        listItem.estado = item.estado;
                        listItem.pasajes = item.pasajes;

                        ret.Add(listItem);
                    }
                }
            }

            return View(ret);
        }
        public IActionResult AsignarRoles()
        {
            ViewBag.buscar = null;
            ViewBag.id = null;
            return View();
        }
        [HttpPost]
        public IActionResult AsignarRoles(String email)
        {
            UruguayBusUser u = api.GetPorCorreo(email).Result;
            ViewBag.buscar = u;
            if(u != null)
                ViewBag.id = u.Id;
            else
                ViewBag.id = null;
            return View();


 

        }
        [HttpPost]
        public void AsignarRoles2(String idusuario, String inputState, String fechalibreta)
        {
            DtoRoles r = new DtoRoles();
            r.idusuario = idusuario;
            r.fechaLibreta = fechalibreta;
            r.rol = inputState;
            api.CambiarRol(r);
            Response.Redirect("AsignarRoles");
        }
    }
}
