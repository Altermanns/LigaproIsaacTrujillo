namespace LigaproIsaacTrujillo.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Titulos  { get; set; }
        public Equipo Equipo { get; set; }

    }

}
