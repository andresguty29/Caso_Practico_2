using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.AccesoADatos.Modelos
{

        [Table("Servicios")]
        public class ServiciosAD
        {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nombre")]
        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }
        [Column("Descripcion")]
        [MaxLength(200)]
        [Required]
        public string Descripcion { get; set; }  
        [Required]
        [Column("Monto")]
        public decimal Monto { get; set; } 
        [Required]
        [Column("IVA")]
        public decimal IVA { get; set; }
        [Required]
        [Column("Especialidad")]
        public int Especialidad { get; set; }
        [MaxLength(200)]
        [Required]
        [Column("Especialista")]
        public string Especialista { get; set; }
        [MaxLength(200)]
        [Required]
        [Column("Clinica")]
        public string Clinica { get; set; }
        [Required]
        [Column("FechaDeRegistro")]
        public DateTime FechaDeRegistro { get; set; }
        [Column("FechaDeModificacion")]
        public DateTime? FechaDeModificacion { get; set; }
        [Column("ESTADO")]
        public bool Estado { get; set; }

    }
}
