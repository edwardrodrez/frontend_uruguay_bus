using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class DtoViajePrecio
    {
        public int precio { get; set; }
        public Viaje viaje { get; set; }
    }
}
