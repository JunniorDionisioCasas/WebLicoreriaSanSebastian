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
    public class DetalleEntradaLogica : ICRUDLogica<DetalleEntradaModel>
    {
        DetalleEntradaRepositorio repo = new DetalleEntradaRepositorio();

        public DetalleEntradaModel ActualizarRegistro(DetalleEntradaModel input)
        {

            input = repo.ActualizarRegistro(input);
            return input;
        }

        public DetalleEntradaModel CrearRegistro(DetalleEntradaModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            id = repo.deleteRegistro(id);
            return id;
        }

        public List<DetalleEntradaModel> ListarTodo()
        {
            List<DetalleEntradaModel> lista = repo.ListarTodo();
            return lista;
        }

        public DetalleEntradaModel ObtenerPorId(int id)
        {
            DetalleEntradaModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
