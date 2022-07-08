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
    public class SalidaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idsalidas { get; set; }

        [Required]
        public DateTime fecha { get; set; }

        [Required]
        public DateTime hora { get; set; }

        [MaxLength(20)]
        [Required]
        public string serie { get; set; }

        [MaxLength(30)]
        [Required]
        public string numero { get; set; }

        [Required]
        public double total { get; set; }

        public int id_sucursal { get; set; }
        [JsonIgnore,ForeignKey("id_sucursal")]
        public virtual SucursalModel? sucursal { get; set; }
    }
}
