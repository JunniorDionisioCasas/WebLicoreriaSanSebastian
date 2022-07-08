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
    public class DetalleSalidaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iddetallesalida { get; set; }

        [Required]
        public int cantidad { get; set; }

        [Required]
        public double total { get; set; }


        public int id_medicamento { get; set; }
        [JsonIgnore,ForeignKey("id_medicamento")]
        public virtual MedicamentoModel? medicamento { get; set; }

        public int id_salida { get; set; }
        [JsonIgnore,ForeignKey("id_salida")]
        public virtual SalidaModel? salida { get; set; }
    }
}
