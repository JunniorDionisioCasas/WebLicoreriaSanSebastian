using Logica.Interface;
using Modelos;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CargoLogica : ICRUDLogica<CargoModel>
    {
        CargoRepositorio repo = new CargoRepositorio();

        public CargoModel ActualizarRegistro(CargoModel input)
        {

            input = repo.ActualizarRegistro(input);
            return input;
        }

        public CargoModel CrearRegistro(CargoModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int deleteRegistro(int id)
        {
            id = repo.deleteRegistro(id);
            return id;
        }


        public List<CargoModel> ListarTodo()
        {
            List<CargoModel> lista = repo.ListarTodo();
            return lista;
        }

        public CargoModel ObtenerPorId(int id)
        {
            CargoModel resultado = repo.ObtenerPorId(id);
            return resultado;
        }

    }
}
