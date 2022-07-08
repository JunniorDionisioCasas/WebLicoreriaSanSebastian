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
    public class DetalleEntradaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iddetalleentradas { get; set; }

        [Required]
        public int cantidad { get; set; }

        public int id_medicamento { get; set; }

        [JsonIgnore,ForeignKey("id_medicamento")]
        public virtual MedicamentoModel? Medicamento { get; set; }

        public int id_entrada { get; set; }

        [JsonIgnore, ForeignKey("id_entrada")]
        public virtual EntradaModel? entradas { get; set; }
    }
}
