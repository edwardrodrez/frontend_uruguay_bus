using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class DtoViaje
    {
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFinal { get; set; }
        public List<Dia> DiasViaje { get; set; } = new List<Dia>();
        public int idHorario { get; set; }
    }
}
