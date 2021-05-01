using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class EmpleadoDiaTrabaja
    {
        public long Id { get; set; }
        public Dias Dia { get; set; }
        public int HorasTrabaja { get; set; }
        public Empleado Empleado { get; set; }
        public long EmpleadoId { get; set; }
    }
}
