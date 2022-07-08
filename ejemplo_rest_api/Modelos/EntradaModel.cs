using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Modelos
{
    public class EntradaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int identradas { get; set; }

        [Required]
        public DateTime fecha { get; set; }

        [Required]
        public DateTime hora { get; set; }

        [Required]
        public double total { get; set; }

        [MaxLength(20)]
        [Required]
        public string NumeroCompra { get; set; }

        [Required]
        public double subtotal { get; set; }


        public int id_proveedor { get; set; }
        [JsonIgnore,ForeignKey("id_proveedor")]
        public virtual ProveedorModel? proveedor { get; set; }

        public int id_persona { get; set; }
        [JsonIgnore,ForeignKey("id_persona")]
        public virtual PersonaModel? personas { get; set; }

    }
}
