using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class SucursalModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idsucursal { get; set; }

        [MaxLength(50)]
        [Required]
        public string direccion { get; set; }

        [MaxLength(9)]
        [Required]
        public string celular { get; set; }

        [MaxLength(80)]
        [Required]
        public string representante { get; set; }

        [Required]
        public bool estado { get; set; }
    }
}
