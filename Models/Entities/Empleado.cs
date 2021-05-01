using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Empleado
    {
        public long Id { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public TipoSalario TipoSalario { get; set; }
        public decimal Salario { get; set; }
        public List<EmpleadoDiaTrabaja> DiasTrabaja { get; set; } = new List<EmpleadoDiaTrabaja>();
        public bool Activo { get; set; }
        public DateTime FechaDesactivado { get; set; } 

        public Empleado()
        {
            DiasTrabaja = new List<EmpleadoDiaTrabaja>();
        }
    }
}
