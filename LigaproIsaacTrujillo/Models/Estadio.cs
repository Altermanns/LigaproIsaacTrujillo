using System.ComponentModel.DataAnnotations;

namespace LigaproIsaacTrujillo.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(150)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Ciudad { get; set; }

        [Range(1000, 100000)]
        public int Capacidad { get; set; }
    }
}
