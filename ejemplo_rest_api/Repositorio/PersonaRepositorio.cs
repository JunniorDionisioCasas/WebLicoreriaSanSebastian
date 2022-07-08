using Microsoft.EntityFrameworkCore;
using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class PersonaRepositorio : ICRUD<PersonaModel>
    {
        _dbContext db = new _dbContext();
        public PersonaModel ActualizarRegistro(PersonaModel input)
        {
            db.Persona.Update(input);
            db.SaveChanges();
            return input;
        }

        public PersonaModel CrearRegistro(PersonaModel input)
        {
            db.Persona.Add(input);
            db.SaveChanges();
            return input;
            
        }

        public int deleteRegistro(int id)
        {
            PersonaModel obj = db.Persona.Find(id);
            db.Persona.Remove(obj);
            return db.SaveChanges();
        }

        public List<PersonaModel> ListarTodo()
        {
            List<PersonaModel> lista = db.Persona.ToList();

            return lista;
        }

        public PersonaModel ObtenerPorId(int id)
        {
            PersonaModel obj = db.Persona.Find(id);
            return obj;
        }

        public List<PersonaModel> ListarTodoDetallado()
        {
            List<PersonaModel> lista = 
                db.Persona
                .ToList();

            return lista;
        }

    }
}
