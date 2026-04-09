using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.AccesoADatos.Modelos
{
    [Table("Especialidades")]
    public class EspecialidadesAD
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nombre")]
        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }

        [Column("Descripcion")]
        [MaxLength(200)]
        public string Descripcion { get; set; }

        [Column("FechaDeRegistro")]
        [Required]
        public DateTime FechaDeRegistro { get; set; }

        [Column("FechaDeModificacion")]
        public DateTime? FechaDeModificacion { get; set; }
    }
}
