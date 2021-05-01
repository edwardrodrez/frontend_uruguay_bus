
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UruguayBus.Areas.Identity.Data;

namespace UruguayBus.Data
{
    public class Temp
    {
        private static readonly Temp instance = new Temp();

        private Temp()
        {

            Usauarios = new List<UruguayBusUser>();
        }
        public static Temp Instance => instance;
        public List<UruguayBusUser> Usauarios { get; set; }
        public UruguayBusUser Usauario { get; set; }
        public List<Dia> Selected { get; set; }
        public List<viajeConductor> viajeConductor { get; set; }

        public viajeConductor getviajeConductor(string key)
        {
            foreach (viajeConductor element in viajeConductor)
            {
                if (element.key == key)
                {
                    return element;
                }
            }
            return null;
        }

        public void addviajeConductor(viajeConductor u)
        {
            foreach (viajeConductor element in viajeConductor)
            {
                if (element.key == u.key)
                {
                    element.idviaje = u.idviaje;
                    return;
                }
            }
            viajeConductor.Add(u);
        }

        public void addUsuario(UruguayBusUser u)
        {
            Usauarios.Add(u);
            Usauario = u;
        }
        public UruguayBusUser GetUs()
        {
            return Usauario;
        }
        public void AcUs(string x)
        {
            foreach (UruguayBusUser element in Usauarios)
            {
                if (element.UserName == x)
                {
                    Usauario = element;
                }
            }
        }
        public string getToken()
        {
            if (Usauario != null)
                return Usauario.SecurityStamp;
            else
                return null;
        }
    }
}
