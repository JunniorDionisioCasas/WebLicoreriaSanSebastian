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
    public class MedicamentoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idmedicamento { get; set; }

        [MaxLength(50)]
        [Required]
        public string medicamento { get; set; }

        [MaxLength(50)]
        [Required]
        public string descripcion { get; set; }

        [MaxLength(30)]
        [Required]
        public string concentracion { get; set; }

        [Required]
        public int stock { get; set; }

        [Required]
        public double precio { get; set; }

        [Required]
        public DateTime fechaingreso { get; set; }

        [Required]
        public DateTime fechavencimiento { get; set; }

        [Required]
        public bool estado { get; set; }

        public int id_categoria { get; set; }
        [JsonIgnore, ForeignKey("id_categoria")]
        public virtual CategoriaModel? categoria { get; set; }

        public int id_presentacion { get; set; }
        [JsonIgnore, ForeignKey("id_presentacion")]
        public virtual PresentacionModel? presentacion { get; set; }

        public int id_laboratorio { get; set; }

        [JsonIgnore, ForeignKey("id_laboratorio")]
        public virtual LaboratorioModel? laboratorio { get; set; }
    }
}
