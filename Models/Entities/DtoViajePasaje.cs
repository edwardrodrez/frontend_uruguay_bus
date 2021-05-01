using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class DtoViajePasaje
    {
        public int origen { get; set; }
        public int fin { get; set; }
        public DateTime fecha { get; set; }
        public string tipoDocumento { get; set; }
        public string documento { get; set; }
    }
}
