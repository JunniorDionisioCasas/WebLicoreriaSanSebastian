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
    public class SalidaLogica : ICRUDLogica<SalidaModel>
    {
        SalidaRepositorio repo = new SalidaRepositorio();
        public SalidaModel ActualizarRegistro(SalidaModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public SalidaModel CrearRegistro(SalidaModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            id = repo.deleteRegistro(id);
            return id;
        }

        public List<SalidaModel> ListarTodo()
        {
            List<SalidaModel> lista = repo.ListarTodo();
            return lista;
        }

        public SalidaModel ObtenerPorId(int id)
        {
            SalidaModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
