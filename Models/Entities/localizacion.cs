using System;

namespace Models.Entities
{
    public class Localizacion
    {
        public int idlocalizacion { get; set; }
        public int ultimaPosicion { get; set; }
        public DateTime HoraDeLlegada { get; set; }
        public Viaje Viaje { get; set; }
    }
}
