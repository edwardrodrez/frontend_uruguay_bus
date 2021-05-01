using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class ReporteRet
    {
        public int cantPasajes { get; set; }
        public float precioTotal { get; set; }
        public float recaudacion { get; set; }
        public float regla { get; set; }
        public float porcentaje { get; set; }
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public string nombreLinea { get; set; }
        public DateTime horario { get; set; }
        public int idViaje { get; set; }
        public int idLinea { get; set; }
        public string matricula { get; set; }
        public int salidas { get; set; }

    }
}