using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.NoDatabase
{
    public class UsuarioRegistroRequest
    {
        public PersonaModel Persona { get; set; }
        public UsuarioModel Usuario { get; set; }
    }
}
