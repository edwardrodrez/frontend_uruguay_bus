using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Parada
    {
        public int idParada { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar un geo Referencia")]
        public string geoReferencia { get; set; }
        public List<Parada_linea> Linea { get; set; } = new List<Parada_linea>();
        public Parada()
        {
            Linea = new List<Parada_linea>();
        }
    }
}
