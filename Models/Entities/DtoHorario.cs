using System;

namespace Models.Entities
{
    public class DtoHorario
    {
        public DateTime hora { get; set; }
        public int idlinea { get; set; }
        public int idvehiculo { get; set; }
        public int idusuario { get; set; }
    }
}
