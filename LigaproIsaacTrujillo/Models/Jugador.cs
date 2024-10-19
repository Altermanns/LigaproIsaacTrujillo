using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LigaproIsaacTrujillo.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Posicion { get; set; }

        [Range(16, 45)]
        public int Edad { get; set; }

        public int EquipoId { get; set; }

        [ForeignKey("EquipoId")]
        public virtual Equipo Equipo { get; set; }
    }
}
