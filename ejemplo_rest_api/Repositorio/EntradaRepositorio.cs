using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class EntradaRepositorio : ICRUD<EntradaModel>
    {
        _dbContext db = new _dbContext();
        public EntradaModel ActualizarRegistro(EntradaModel input)
        {
            db.Entradas.Update(input);
            db.SaveChanges();
            return input;
        }

        public EntradaModel CrearRegistro(EntradaModel input)
        {
            db.Entradas.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            EntradaModel carg = db.Entradas.Find(id);
            db.Entradas.Remove(carg);
            return db.SaveChanges();
        }

        public List<EntradaModel> ListarTodo()
        {
            List<EntradaModel> carg = db.Entradas.ToList();
            return carg;
        }

        public EntradaModel ObtenerPorId(int id)
        {
            EntradaModel carg = db.Entradas.Find(id);
            return carg;
        }
    }
}
