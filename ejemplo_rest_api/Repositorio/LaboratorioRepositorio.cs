using Modelos;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class LaboratorioRepositorio : ICRUD<LaboratorioModel>
    {
        _dbContext db = new _dbContext();
        public LaboratorioModel ActualizarRegistro(LaboratorioModel input)
        {
            db.Laboratorio.Update(input);
            db.SaveChanges();
            return input;
        }

        public LaboratorioModel CrearRegistro(LaboratorioModel input)
        {
            db.Laboratorio.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            LaboratorioModel carg = db.Laboratorio.Find(id);
            db.Laboratorio.Remove(carg);
            return db.SaveChanges();
        }

        public List<LaboratorioModel> ListarTodo()
        {
            List<LaboratorioModel> carg = db.Laboratorio.ToList();
            return carg;
        }

        public LaboratorioModel ObtenerPorId(int id)
        {
            LaboratorioModel carg = db.Laboratorio.Find(id);
            return carg;
        }
    }
}
