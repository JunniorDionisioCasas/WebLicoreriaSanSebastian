using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DetalleSalidaRepositorio: ICRUD<DetalleSalidaModel>
    {
        _dbContext db = new _dbContext();
        public DetalleSalidaModel ActualizarRegistro(DetalleSalidaModel input)
        {
            db.DetalleSalida.Update(input);
            db.SaveChanges();
            return input;
        }

        public DetalleSalidaModel CrearRegistro(DetalleSalidaModel input)
        {
            db.DetalleSalida.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            DetalleSalidaModel carg = db.DetalleSalida.Find(id);
            db.DetalleSalida.Remove(carg);
            return db.SaveChanges();
        }

        public List<DetalleSalidaModel> ListarTodo()
        {
            List<DetalleSalidaModel> carg = db.DetalleSalida.ToList();
            return carg;
        }

        public DetalleSalidaModel ObtenerPorId(int id)
        {
            DetalleSalidaModel carg = db.DetalleSalida.Find(id);
            return carg;
        }
    }
}
