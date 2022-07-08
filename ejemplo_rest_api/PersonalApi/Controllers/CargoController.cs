using Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        CargoLogica cargologica = new CargoLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<CargoModel> listaresultado = new List<CargoModel>();
            listaresultado = cargologica.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            CargoModel resultado = new CargoModel();
            resultado = cargologica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(CargoModel request)
        {
            CargoModel response = cargologica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(CargoModel Request)
        {
            CargoModel resultado = cargologica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = cargologica.deleteRegistro(id);
            return Ok(borrar);
        }
    }

}
