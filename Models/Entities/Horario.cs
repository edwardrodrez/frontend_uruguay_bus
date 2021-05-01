using System;

namespace Models.Entities
{
    public class Horario
    {
        public int idHorario { get; set; }
        public DateTime hora { get; set; }
        //Listas o referencias
        public Linea linea { get; set; }
        public bool Viaje { get; set; }
        public Vehiculo vehiculo { get; set; }
        public Usuario usuario { get; set; }

        public string FullName
        {
            get
            {
                return linea.nombre +" "+ "Hora:" +" "+ hora.TimeOfDay;
            }
        }
    }
}
