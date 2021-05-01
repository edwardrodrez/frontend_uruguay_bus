using Models.Enums;
using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class DtoPrecio
    {
        public int idparadaAnterior { get; set; }
        public int precio { get; set; }
        public DateTime FechaCaducidad { get; set; }
    }
}
