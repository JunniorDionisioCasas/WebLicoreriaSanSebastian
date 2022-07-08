using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class LaboratorioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idlaboratorio { get; set; }

        [MaxLength(80)]
        [Required]
        public string direccion { get; set; }

        [MaxLength(30)]
        [Required]
        public string razonsocial { get; set; }

        [MaxLength(40)]
        [Required]
        public string email { get; set; }

        [MaxLength(80)]
        [Required]
        public string representante { get; set; }

        [MaxLength(9)]
        [Required]
        public string celular { get; set; }

        [Required]
        public bool estado { get; set; }
    }
}
