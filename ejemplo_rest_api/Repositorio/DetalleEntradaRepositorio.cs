using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DetalleEntradaRepositorio: ICRUD<DetalleEntradaModel>
    {
        _dbContext db = new _dbContext();
        public DetalleEntradaModel ActualizarRegistro(DetalleEntradaModel input)
        {
            db.DetalleEntrada.Update(input);
            db.SaveChanges();
            return input;
        }

        public DetalleEntradaModel CrearRegistro(DetalleEntradaModel input)
        {
            db.DetalleEntrada.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            DetalleEntradaModel carg = db.DetalleEntrada.Find(id);
            db.DetalleEntrada.Remove(carg);
            return db.SaveChanges();
        }

        public List<DetalleEntradaModel> ListarTodo()
        {
            List<DetalleEntradaModel> carg = db.DetalleEntrada.ToList();
            return carg;
        }

        public DetalleEntradaModel ObtenerPorId(int id)
        {
            DetalleEntradaModel carg = db.DetalleEntrada.Find(id);
            return carg;
        }
    }
}
