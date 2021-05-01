
using Models.Enums;
using System;

namespace Models.Entities
{
    public class Pasaje
    {
        public int idPasaje { get; set; }
        public DateTime fecha { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string posicionOrigen { get; set; }
        public string posicionDestino { get; set; }

    }
}
