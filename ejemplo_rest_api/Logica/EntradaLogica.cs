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
    public class EntradaLogica : ICRUDLogica<EntradaModel>
    {
        EntradaRepositorio repo = new EntradaRepositorio();
        DetalleEntradaLogica detalle= new DetalleEntradaLogica();

        public EntradaModel ActualizarRegistro(EntradaModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public EntradaModel CrearRegistro(EntradaModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {

            id = repo.deleteRegistro(id);
            return id;
        }

        public List<EntradaModel> ListarTodo()
        {
            List<EntradaModel> lista = repo.ListarTodo();
            return lista;
        }

        public EntradaModel ObtenerPorId(int id)
        {
            EntradaModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }
        public bool registrarEntrada(EntradaRequest Request)
        {
            DetalleEntradaModel entra = detalle.CrearRegistro(Request.DetalleEntrada);
            Request.Entrada.identradas = entra.id_entrada ;
            CrearRegistro(Request.Entrada);
            return true;
        }
    }
}
