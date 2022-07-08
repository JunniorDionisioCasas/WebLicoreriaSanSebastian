using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ProveedorModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idproveedor { get; set; }

        [MaxLength(50)]
        [Required]
        public string razonsocial { get; set; }

        [MaxLength(11)]
        [Required]
        public string ruc { get; set; }

        [MaxLength(50)]
        [Required]
        public string direccion { get; set; }

        [MaxLength(9)]
        [Required]
        public string celular { get; set; }

        [MaxLength(60)]
        [Required]
        public string representante { get; set; }

        [Required]
        public bool estado { get; set; }
    }
}
