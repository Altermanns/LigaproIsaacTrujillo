namespace LigaproIsaacTrujillo.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posición { get; set; }
        public int Edad {  get; set; }
        public Equipo IdEquipo { get; set; }

    }

}
