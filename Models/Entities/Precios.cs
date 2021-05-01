using System;

namespace Models.Entities
{
    public class Precios
    {  
        public int idPrecio { get; set; }
        public int precio { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public ParadaAnterior ParadaAnterior { get; set; }



    }
}
