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
    public class MedicamentoRepositorio : ICRUD<MedicamentoModel>
    {
        _dbContext db = new _dbContext();
        public MedicamentoModel ActualizarRegistro(MedicamentoModel input)
        {
            db.Medicamento.Update(input);
            db.SaveChanges();
            return input;
        }

        public MedicamentoModel CrearRegistro(MedicamentoModel input)
        {

            db.Medicamento.Add(input);
            db.SaveChanges();
            return input;
        }

        public int deleteRegistro(int id)
        {
            MedicamentoModel carg = db.Medicamento.Find(id);
            db.Medicamento.Remove(carg);
            return db.SaveChanges();
        }

        public List<MedicamentoModel> ListarTodo()
        {
            List<MedicamentoModel> carg = db.Medicamento.ToList();
            return carg;
        }
        public List<MedicamentoModel> ListarTodoDetallado()
        {
            List<MedicamentoModel> lista =
                db.Medicamento
                .Include(x => x.laboratorio)
                .Include(x => x.presentacion)
                .Include(x => x.categoria)
                .ToList();

            return lista;
        }
        public MedicamentoModel ObtenerPorId(int id)
        {
            MedicamentoModel carg = db.Medicamento.Find(id);
            return carg;
        }

    }
}
