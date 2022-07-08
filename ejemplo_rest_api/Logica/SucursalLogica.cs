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
    public class SucursalLogica : ICRUDLogica<SucursalModel>
    {
        SucursalRepositorio repo = new SucursalRepositorio();

        public SucursalModel ActualizarRegistro(SucursalModel input)
        {

            input = repo.ActualizarRegistro(input);
            return input;
        }

        public SucursalModel CrearRegistro(SucursalModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            id = repo.deleteRegistro(id);
            return id;
        }

        public List<SucursalModel> ListarTodo()
        {
            List<SucursalModel> lista = repo.ListarTodo();
            return lista;
        }

        public SucursalModel ObtenerPorId(int id)
        {
            SucursalModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
