using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.AccesoADatos.Modelos
{
    [Table("Clinicas")]
    public class ClinicasAD
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nombre")]
        [MaxLength(150)]
        [Required]
        public string Nombre { get; set; }

        [Column("Direccion")]
        [MaxLength(250)]
        [Required]
        public string Direccion { get; set; }

        [Column("Telefono")]
        [MaxLength(15)]
        public string Telefono { get; set; }

        [Column("Correo")]
        [MaxLength(100)]
        public string Correo { get; set; }

        [Column("FechaDeRegistro")]
        [Required]
        public DateTime FechaDeRegistro { get; set; }

        [Column("FechaDeModificacion")]
        public DateTime? FechaDeModificacion { get; set; }
    }
}
