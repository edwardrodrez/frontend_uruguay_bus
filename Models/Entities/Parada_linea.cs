namespace Models.Entities
{
    public class Parada_linea
    {
        public int idParada_linea { get; set; }
        public int posicion { get; set; }
        public Parada Parada { get; set; }
        public Linea Linea { get; set; }

    }
}
