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
    public class MedicamentoLogica : ICRUDLogica<MedicamentoModel>
    {
        MedicamentoRepositorio repo = new MedicamentoRepositorio();
        CategoriaLogica cate= new CategoriaLogica();
        PresentacionModel presentacion = new PresentacionModel();
        LaboratorioModel laboratorio = new LaboratorioModel();

        public MedicamentoModel ActualizarRegistro(MedicamentoModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public MedicamentoModel CrearRegistro(MedicamentoModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            id = repo.deleteRegistro(id);
            return id;
        }

        public List<MedicamentoModel> ListarTodo()
        {
            List<MedicamentoModel> lista = repo.ListarTodo();
            return lista;
        }

        public MedicamentoModel ObtenerPorId(int id)
        {
            MedicamentoModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }
        public List<MedicamentoModel> ListarTodoDetallado()
        {
            List<MedicamentoModel> lista = repo.ListarTodoDetallado();
            return lista;
        }
       
    }
}
