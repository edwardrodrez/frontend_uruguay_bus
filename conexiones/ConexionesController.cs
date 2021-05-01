using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Newtonsoft.Json;
using Share.Entities;
using UruguayBus.Areas.Identity.Data;
using UruguayBus.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UruguayBus.conexiones
{
    public class ConexionesController : Controller
    {

        string Baseurl = "https://apprestproyectonet.azurewebsites.net/";

        public async void UpdateLineas(Linea l)
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

                var response = await client.PutAsync("api/Linea", stringContent);
            }

        }

        internal async Task<UruguayBusUser> login(string email, string password)
        {
            UruguayBusUser ret2 = new UruguayBusUser();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var dt = new DtoLogin();
                dt.correo = email;
                dt.pass = password;

                var json = JsonConvert.SerializeObject(dt);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response2 = await client.PostAsync("api/Account/login", stringContent);
                if (response2.IsSuccessStatusCode)
                {
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    ret2 = JsonConvert.DeserializeObject<UruguayBusUser>(aux2);
                    return ret2;
                }
                else return null;




            }
        }
        internal async Task<String> Token(string email, string password)
        {
            Token ret2 = new Token();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

                var dt = new DtoToken();
                dt.UserName = email;
                dt.Password = password; 
                dt.grant_type = "password";

                string json = string.Format("grant_type=password&username={0}&password={1}", email, password);

                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/x-www-form-urlencoded");

                var response2 = await client.PostAsync("Token", stringContent);
                if (response2.IsSuccessStatusCode)
                {
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    ret2 = JsonConvert.DeserializeObject<Token>(aux2);
                    return ret2.access_token;
                }
                else return null;




            }
        }

        public async Task<Linea> getLinea(int id)
        {
            Linea ret2 = new Linea();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response2 = await client.GetAsync("api/Linea/" + id2);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<Linea>(aux2);
                    ViewBag.paradaAnterior = ret2.ParadaAnterior;
                }

                return ret2;
                
            }
        }


        public async Task<Usuario> getUsuario(int id)
        {
            Usuario ret2 = new Usuario();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response2 = await client.GetAsync("api/Usuario/" + id2);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<Usuario>(aux2);
                }

                return ret2;

            }
        }

        public async Task<UruguayBusUser> getUsuarioBus(int id)
        {
            UruguayBusUser ret2 = new UruguayBusUser();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response2 = await client.GetAsync("api/Usuario/" + id2);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<UruguayBusUser>(aux2);
                }

                return ret2;

            }
        }

        public async Task<UruguayBusUser> GetPorCorreo(string correo)
        {
            UruguayBusUser ret2 = new UruguayBusUser();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var dt = new DtoString();
                dt.variable = correo;

                var json = JsonConvert.SerializeObject(dt);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response2 = await client.PostAsync("api/Usuario/CorreoUser", stringContent);
                if (response2.IsSuccessStatusCode)
                {
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    ret2 = JsonConvert.DeserializeObject<UruguayBusUser>(aux2);
                }

                return ret2;

            }
        }

        public async void CambiarRol(DtoRoles rol)
        {
            UruguayBusUser ret2 = new UruguayBusUser();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(rol);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response2 = await client.PostAsync("api/Usuario/Rol", stringContent);

            }
        }

        public async void DeleteLineas(int id)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response = await client.DeleteAsync("api/Linea/Delete/" + id2);
            }

        }


        public async Task<List<Viaje>> getViajes()
        {
            List<Viaje> ret = new List<Viaje>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response2 = await client.GetAsync("api/Viaje");
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret = JsonConvert.DeserializeObject<List<Viaje>>(aux2);
                }

                return ret;

            }
        }

        public async Task<Viaje> getViaje(int id)
        {
            Viaje ret = new Viaje();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response2 = await client.GetAsync("api/Viaje/" + id2);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret = JsonConvert.DeserializeObject<Viaje>(aux2);
                }

                return ret;

            }
        }

        public async void UpdateViaje(Viaje h)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(h);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PutAsync("api/Viaje", stringContent);
            }

        }

        public async void addViaje(DtoViaje dt)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(dt);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PostAsync("api/Viaje", stringContent);
            }

        }

        public async void DeleteViaje(int id)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response = await client.DeleteAsync("api/Viaje/" + id2);
            }

        }



        public async Task<List<Precios>> getPrecios(int id)
        {
            List<Precios> ret2 = new List<Precios>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response2 = await client.GetAsync("api/Linea/ParadaAnterior/" + id2);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    var ret = JsonConvert.DeserializeObject<ParadaAnterior>(aux2);
                    ret2 = ret.Precios;
                }

                return ret2;

            }
        }

        public async void addPrecio(DtoPrecio dt)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(dt);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PostAsync("api/Linea/AddPrecio", stringContent);
            }

        }

        public async Task<List<Horario>> getHorarios()
        {
            List<Horario> ret2 = new List<Horario>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response2 = await client.GetAsync("api/Horario");
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<Horario>>(aux2);
                }

                return ret2;

            }
        }

        public async Task<List<Vehiculo>> getVhiculos()
        {
            List<Vehiculo> ret2 = new List<Vehiculo>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Temp.Instance.getToken());

                var response2 = await client.GetAsync("api/Vehiculo");
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<Vehiculo>>(aux2);
                }

                return ret2;

            }
        }

        public async Task<List<Linea>> getlineaAll()
        {
            List<Linea> ret2 = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response2 = await client.GetAsync("api/Linea");
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<Linea>>(aux2);
                }

                return ret2;

            }
        }

        public async Task<List<Usuario>> getConductores()
        {
            List<Usuario> ret2 = new List<Usuario>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response2 = await client.GetAsync("api/Usuario/Conductores");
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<Usuario>>(aux2);
                }

                return ret2;

            }
        }

        public async void addHorario(DtoHorario dt)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(dt);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PostAsync("api/Horario", stringContent);
            }

        }
        public async void UpdateHorario(Horario h)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(h);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PutAsync("api/Horario", stringContent);
            }

        }
        public async Task<Horario> getHorario(int id)
        {
            Horario ret2 = new Horario();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response2 = await client.GetAsync("api/Horario/" + id2);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<Horario>(aux2);
                }

                return ret2;

            }
        }

        public async void UpdateVehiculoHorario(int IdVehiculo, int id)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var id3 = IdVehiculo.ToString();
                var json = JsonConvert.SerializeObject(IdVehiculo);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PutAsync("api/Horario/Vehiculo/" + id2 + "/" + id3, stringContent);
            }

        }

        public async void UpdateUsuarioHorario(int IdUsuario, int id)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var id3 = IdUsuario.ToString();
                var json = JsonConvert.SerializeObject(IdUsuario);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PutAsync("api/Horario/Usuario/" +id2 + "/" + id3, stringContent);
            }

        }

        public async void UpdateLineaHorario(int IdLinea, int id)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var id3 = IdLinea.ToString();
                var json = JsonConvert.SerializeObject(IdLinea);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response = await client.PutAsync("api/Horario/Linea/" + id2 +"/"+ id3, stringContent);
            }

        }

        public async void DeleteHorario(int id)
        {
            List<Linea> ret = new List<Linea>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var id2 = id.ToString();
                var response = await client.DeleteAsync("api/Horario/" + id2);
            }

        }
        //------- MIO
        public async Task<List<DtoViajePrecio>> ViajesPasaje(DtoViajePasaje dt)
        {
            List<DtoViajePrecio> ret2 = new List<DtoViajePrecio>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = JsonConvert.SerializeObject(dt);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response2 = await client.PostAsync("api/Viaje/ViajesPasaje", stringContent);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<DtoViajePrecio>>(aux2);
                }

                return ret2;

            }

        }
        public async Task<bool> ComprarPasaje(DtoComprarPasaje dt)
        {
            bool ret2 = false;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = JsonConvert.SerializeObject(dt);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");
                var response2 = await client.PostAsync("api/Viaje/ComprarPasaje", stringContent);
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<bool>(aux2);
                }

                return ret2;

            }

        }
        public async Task<List<DtoViajeControl>> ViajesControl()
        {
            List<DtoViajeControl> ret2 = new List<DtoViajeControl>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response2 = await client.GetAsync("api/Viaje/ViajesControl");
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<DtoViajeControl>>(aux2);
                }

                return ret2;

            }

        }


        //-----
        public async Task<List<Parada>> GetParadas()
        {
            List<Parada> ret2 = new List<Parada>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response2 = await client.GetAsync("api/Parada");
                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<List<Parada>>(aux2);
                }

                return ret2;

            }

        }
        //-----
        public async Task<string> SiguienteParada(int id)
        {
            string ret2 = "";
            using (var client = new System.Net.Http.HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var id2 = id.ToString();
                var response = await client.GetAsync("api/Viaje/MoverVehiculo/" + id);
                if (response.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret2 = JsonConvert.DeserializeObject<string>(aux2);
                }

                return ret2;
            }

        }

        //-------FIN



    }
}
