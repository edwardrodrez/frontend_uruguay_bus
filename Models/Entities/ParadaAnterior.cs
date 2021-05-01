using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class ParadaAnterior
    {
        public int idAnterior { get; set; }
        public int posicion { get; set; }
        public DateTime tiempo { get; set; }
        public Linea linea { get; set; }
        public List<Precios> Precios { get; set; } = new List<Precios>();
        public ParadaAnterior()
        {
            Precios = new List<Precios>();
        }

    }
}
