using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class SalidaRepositorio : ICRUD<SalidaModel>
    {
        _dbContext db = new _dbContext();
        public SalidaModel ActualizarRegistro(SalidaModel input)
        {
            db.Salida.Update(input);
            db.SaveChanges();
            return input;
        }

        public SalidaModel CrearRegistro(SalidaModel input)
        {
            db.Salida.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            SalidaModel carg = db.Salida.Find(id);
            db.Salida.Remove(carg);
            return db.SaveChanges();
        }

        public List<SalidaModel> ListarTodo()
        {
            List<SalidaModel> carg = db.Salida.ToList();
            return carg;
        }

        public SalidaModel ObtenerPorId(int id)
        {
            SalidaModel carg = db.Salida.Find(id);
            return carg;
        }
    }
}
