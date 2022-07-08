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
    [Table("usuario")]
    public class UsuarioModel
    {
        [Key] // es la llave primaria de mi base de datos
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int id_persona { get; set; }

        [JsonIgnore,ForeignKey("id_persona")]
        public virtual PersonaModel? Persona { get; set; }
    }
}
