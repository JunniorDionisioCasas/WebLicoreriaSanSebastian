using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class UsuarioRepositorio : ICRUD<UsuarioModel>
    {
        _dbContext db = new _dbContext();
        public UsuarioModel ActualizarRegistro(UsuarioModel input)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel CrearRegistro(UsuarioModel input)
        {
            db.Usuario.Add(input);
            db.SaveChanges();
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
            UsuarioModel user = db.Usuario.Where(x => x.username == username).FirstOrDefault();
            return user;
        }
    }
}
