using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class SucursalRepositorio : ICRUD<SucursalModel>
    {
        _dbContext db = new _dbContext();
        public SucursalModel ActualizarRegistro(SucursalModel input)
        {
            db.Sucursal.Update(input);
            db.SaveChanges();
            return input;
        }

        public SucursalModel CrearRegistro(SucursalModel input)
        {
            db.Sucursal.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            SucursalModel carg = db.Sucursal.Find(id);
            db.Sucursal.Remove(carg);
            return db.SaveChanges();
        }

        public List<SucursalModel> ListarTodo()
        {
            List<SucursalModel> carg = db.Sucursal.ToList();
            return carg;
        }

        public SucursalModel ObtenerPorId(int id)
        {
            SucursalModel carg = db.Sucursal.Find(id);
            return carg;
        }
    }
}
