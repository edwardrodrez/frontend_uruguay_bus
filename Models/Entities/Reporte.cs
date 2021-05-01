using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Reporte
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public string tipo { get; set; }
        public string filtro { get; set; }
    }
}