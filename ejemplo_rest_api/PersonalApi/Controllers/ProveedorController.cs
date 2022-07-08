using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;
using Logica;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        ProveedorLogica provelogica = new ProveedorLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<ProveedorModel> listaresultado = new List<ProveedorModel>();
            listaresultado = provelogica.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            ProveedorModel resultado = new ProveedorModel();
            resultado = provelogica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(ProveedorModel request)
        {
            ProveedorModel response = provelogica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(ProveedorModel Request)
        {
            ProveedorModel resultado = provelogica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = provelogica.deleteRegistro(id);
            return Ok(borrar);
        }
    }
}
