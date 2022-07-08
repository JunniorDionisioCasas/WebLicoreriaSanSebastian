using Logica.Interface;
using Modelos;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PresentacionLogica : ICRUDLogica<PresentacionModel>
    {
        PresentacionRepositorio repo = new PresentacionRepositorio();
        public PresentacionModel ActualizarRegistro(PresentacionModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public PresentacionModel CrearRegistro(PresentacionModel input)
        {

            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            id = repo.deleteRegistro(id);
            return id;
        }

        public List<PresentacionModel> ListarTodo()
        {
            List<PresentacionModel> lista = repo.ListarTodo();
            return lista;
        }

        public PresentacionModel ObtenerPorId(int id)
        {
            PresentacionModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
