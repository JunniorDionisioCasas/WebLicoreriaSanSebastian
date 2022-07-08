using Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleEntradaController : ControllerBase
    {
        DetalleEntradaLogica detallelogica = new DetalleEntradaLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<DetalleEntradaModel> listaresultado = new List<DetalleEntradaModel>();
            listaresultado = detallelogica.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            DetalleEntradaModel resultado = new DetalleEntradaModel();
            resultado = detallelogica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(DetalleEntradaModel request)
        {
            DetalleEntradaModel response = detallelogica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(DetalleEntradaModel Request)
        {
            DetalleEntradaModel resultado = detallelogica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = detallelogica.deleteRegistro(id);
            return Ok(borrar);
        }

    }
}
