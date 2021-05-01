using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{

    public class Vehiculo
    {
        public int idVehiculo { get; set; }
        [Required(ErrorMessage = "Debe ingresar una matricula")]
        public string matricula { get; set; }
        [Required(ErrorMessage = "Debe ingresar un modelo")]
        public string modelo { get; set; }
        [Required(ErrorMessage = "Debe ingresar una marca")]
        public string marca { get; set; }
        [Required(ErrorMessage = "Debe ingresar la cantidad de Asientos")]
        public int cantAsientos { get; set; }

        //Listas o referencias
        public List<Horario> horarios { get; set; }




    }
}
