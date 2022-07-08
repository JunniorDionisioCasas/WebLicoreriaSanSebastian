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
    public class DetalleSalidaLogica : ICRUDLogica<DetalleSalidaModel>
    {
        DetalleSalidaRepositorio repo = new DetalleSalidaRepositorio();
        public DetalleSalidaModel ActualizarRegistro(DetalleSalidaModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public DetalleSalidaModel CrearRegistro(DetalleSalidaModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            id = repo.deleteRegistro(id);
            return id;
        }

        public List<DetalleSalidaModel> ListarTodo()
        {
            List<DetalleSalidaModel> lista = repo.ListarTodo();
            return lista;
        }

        public DetalleSalidaModel ObtenerPorId(int id)
        {
            DetalleSalidaModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
