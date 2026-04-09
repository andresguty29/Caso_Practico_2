using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.AccesoADatos.Modelos
{
    [Table("CITAS")] 
    public class CitasAD
    {
        
        [Column("Id")] 
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Column("NombreDeLaPersona")]
        
        public string NombreDeLaPersona { get; set; }

        [Required]
        [Column("Identificacion")]
        [MaxLength(30)] 
        public string Identificacion { get; set; }

        [Required]
        [Column("Telefono")]
        [MaxLength(10)] 
        public string Telefono { get; set; }

        [Required]
        [Column("Correo")]
        [MaxLength(50)] 
        public string Correo { get; set; }

        [Required]
        [Column("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Column("Direccion")]
        [MaxLength(200)] 
        public string Direccion { get; set; }

     
        [Column("MontoTotal")]
        public decimal MontoTotal { get; set; }

        [Required]
        [Column("FechaDeLaCita")]
        public DateTime FechaDeLaCita { get; set; }

        [Required]
        [Column("FechaDeRegistro")]
        public DateTime FechaDeRegistro { get; set; }

        [Required]
        [Column("IdServicio")]
        public int IdServicio { get; set; }  

      
      
    }
}