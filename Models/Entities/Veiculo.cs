using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
     public class Veiculo
    {
        public string matricula { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public int cantAsientos { get; set; }

        //Listas o referencias
        public List<Horario> horarios { get; set; }
       


    }
}
