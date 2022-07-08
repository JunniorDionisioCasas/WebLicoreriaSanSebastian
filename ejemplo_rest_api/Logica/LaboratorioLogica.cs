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
    public class LaboratorioLogica : ICRUDLogica<LaboratorioModel>
    {
        LaboratorioRepositorio repo = new LaboratorioRepositorio();
        public LaboratorioModel ActualizarRegistro(LaboratorioModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public LaboratorioModel CrearRegistro(LaboratorioModel input)
        {

            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            id = repo.deleteRegistro(id);
            return id;
        }

        public List<LaboratorioModel> ListarTodo()
        {
            List<LaboratorioModel> lista = repo.ListarTodo();
            return lista;
        }

        public LaboratorioModel ObtenerPorId(int id)
        {
            LaboratorioModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
