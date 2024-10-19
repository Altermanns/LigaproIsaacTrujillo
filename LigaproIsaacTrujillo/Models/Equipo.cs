using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LigaproIsaacTrujillo.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Ciudad { get; set; }

        public int Titulos { get; set; }

        public bool AceptaExtranjeros { get; set; }

        public int EstadioId { get; set; }

        [ForeignKey("EstadioId")]
        public virtual Estadio Estadio { get; set; }
    }
}
