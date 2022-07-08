using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class PresentacionRepositorio : ICRUD<PresentacionModel>
    {
        _dbContext db = new _dbContext();
        public PresentacionModel ActualizarRegistro(PresentacionModel input)
        {
            db.Presentacion.Update(input);
            db.SaveChanges();
            return input;
        }

        public PresentacionModel CrearRegistro(PresentacionModel input)
        {
            db.Presentacion.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            PresentacionModel carg = db.Presentacion.Find(id);
            db.Presentacion.Remove(carg);
            return db.SaveChanges();
        }

        public List<PresentacionModel> ListarTodo()
        {
            List<PresentacionModel> carg = db.Presentacion.ToList();
            return carg;
        }

        public PresentacionModel ObtenerPorId(int id)
        {
            PresentacionModel carg = db.Presentacion.Find(id);
            return carg;
        }
    }
}
