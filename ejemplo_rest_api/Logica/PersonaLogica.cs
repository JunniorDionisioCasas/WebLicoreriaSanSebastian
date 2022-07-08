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
    public class PersonaLogica : ICRUDLogica<PersonaModel>
    {
        PersonaRepositorio repo = new PersonaRepositorio();
        public PersonaModel ActualizarRegistro(PersonaModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public PersonaModel CrearRegistro(PersonaModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            int res = repo.deleteRegistro(id);
            return res;
        }

        public List<PersonaModel> ListarTodo()
        {
            List < PersonaModel > lst = repo.ListarTodo();
            return lst;
        }

        public PersonaModel ObtenerPorId(int id)
        {
            PersonaModel person = repo.ObtenerPorId(id);
            return person;
        }

        public List<PersonaModel> ListarTodoDetallado()
        {
            List<PersonaModel> lista = repo.ListarTodoDetallado();
            return lista;
        }
    }
}
