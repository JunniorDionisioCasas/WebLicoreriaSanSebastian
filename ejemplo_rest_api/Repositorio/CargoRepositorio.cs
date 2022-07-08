using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class CargoRepositorio : ICRUD<CargoModel>
    {
        _dbContext db = new _dbContext();
        public CargoModel ActualizarRegistro(CargoModel input)
        {
            db.Cargo.Update(input);
            db.SaveChanges();
            return input;
        }

        public CargoModel CrearRegistro(CargoModel input)
        {
            db.Cargo.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            CargoModel carg = db.Cargo.Find(id);
            db.Cargo.Remove(carg);
            return db.SaveChanges();
        }

        public List<CargoModel> ListarTodo()
        {
            List<CargoModel> carg = db.Cargo.ToList();
            return carg;
        }

        public CargoModel ObtenerPorId(int id)
        {
            CargoModel carg = db.Cargo.Find(id);
            return carg;
        }
    }
}
