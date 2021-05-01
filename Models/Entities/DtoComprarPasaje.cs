using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class DtoComprarPasaje
    {
        public string token { get; set; }
        public string transaction_amount { get; set; }
        public string payment_method_id { get; set; }
        public int installments { get; set; }
        public string issuer_id { get; set; }
        public int idusuario { get; set; }
        public int idviaje { get; set; }
        public int origen { get; set; }
        public int destino { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public DateTime fecha { get; set; }
        public string plataforma { get; set; }
        public int idAsiento { get; set; }
    }
}
