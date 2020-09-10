using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NET_CORE_PDF.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Nombre { get; set; }


        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "Varcahr(10)")]
        public string FechaInicio { get; set; }

        [Required]
        [Column(TypeName ="Varcahr(10)")]
        public string TipoDocumento { get; set; }

        [Required]
        [Column(TypeName = "Varcahr(10)")]
        public string Documento { get; set; }

        [Required]
        [Column(TypeName = "Varcahr(10)")]
        public string Cargo { get; set; }
    }
}
