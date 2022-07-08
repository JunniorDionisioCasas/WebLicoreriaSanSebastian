using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{

    public class CategoriaModel
    {
        [Key] // es la llave primaria de mi base de datos
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        
        [MaxLength(30)]
        public string nombre { get; set; }
        
        [Required]
        public bool estado { get; set; } // 1 activo 2 inactivo 3 eliminado


    }
}