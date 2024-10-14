namespace LigaproIsaacTrujillo.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ciudad {  get; set; }
        public int Titulos { get; set; }
        public bool AceptaExtrangeros { get; set; }
        public Estadio Estadio { get; set; }
    }
}
