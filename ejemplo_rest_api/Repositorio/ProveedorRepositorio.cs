using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProveedorRepositorio : ICRUD<ProveedorModel>
    {
        _dbContext db = new _dbContext();

        public ProveedorModel ActualizarRegistro(ProveedorModel input)
        {

            db.Proveedor.Update(input);
            db.SaveChanges();
            return input;
        }

        public ProveedorModel CrearRegistro(ProveedorModel input)
        {
            db.Proveedor.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            ProveedorModel carg = db.Proveedor.Find(id);
            db.Proveedor.Remove(carg);
            return db.SaveChanges();
        }

        public List<ProveedorModel> ListarTodo()
        {
            List<ProveedorModel> carg = db.Proveedor.ToList();
            return carg;
        }

        public ProveedorModel ObtenerPorId(int id)
        {
            ProveedorModel carg = db.Proveedor.Find(id);
            return carg;
        }
    }
}
