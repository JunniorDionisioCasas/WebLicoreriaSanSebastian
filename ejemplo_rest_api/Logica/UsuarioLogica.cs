using Logica.Interface;
using Modelos;
using Modelos.NoDatabase;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioLogica : ICRUDLogica<UsuarioModel>
    {
        UsuarioRepositorio repo = new UsuarioRepositorio();
        PersonaLogica personaLogica= new PersonaLogica();
        public UsuarioModel ActualizarRegistro(UsuarioModel input)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel CrearRegistro(UsuarioModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioModel> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public UsuarioModel ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel ObtenerUsuarioPorUserrName(string username)
        {
            // sintaxis lambda
            UsuarioModel user = repo.ObtenerUsuarioPorUserrName(username);
            return user;
        }
        public bool registrarnuevousuario(UsuarioRegistroRequest Request)
        {
            PersonaModel persona=personaLogica.CrearRegistro(Request.Persona);
            Request.Usuario.id_persona = persona.idPersona;
            CrearRegistro(Request.Usuario);
            return true;
        }
    }
       
}
