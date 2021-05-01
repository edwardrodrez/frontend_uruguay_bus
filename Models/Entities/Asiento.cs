using System.Collections.Generic;

namespace Models.Entities
{
    public class Asiento
    {
        public int idAsiento { get; set; }
        public bool disponible { get; set; }
        public int nroAsiento { get; set; }
        public List<Pasaje> pasajes { get; set; } = new List<Pasaje>();
    }
}
