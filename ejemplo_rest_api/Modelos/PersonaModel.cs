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
    [Table("persona")]
    public class PersonaModel
    {
        [Key] // es la llave primaria de mi base de datos
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPersona { get; set; }
        [MaxLength(60)]
        public string nombre { get; set; }
        [MaxLength(60)]
        public string apellido_paterno { get; set; }
        [MaxLength(60)]
        public string apellido_materno { get; set; }
        [MaxLength(60)]
        public string gmail { get; set; }
        [MaxLength(60)]
        public string direccion { get; set; }
        [MaxLength(9)]
        public string Celular { get; set; }
        [MaxLength(8)]
        public string DNI { get; set; }
        [Required]
        public bool estado { get; set; }

        public int idcargo { get; set; }

        [JsonIgnore,ForeignKey("idcargo")]
        public virtual CargoModel? cargo { get; set; }
        
       // public virtual List<UsuarioModel> Usuario { get; set; }

    }
}
