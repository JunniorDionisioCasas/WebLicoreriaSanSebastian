using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;


namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DetalleSalidaController : ControllerBase
    {
        DetalleSalidaLogica detallesalogica = new DetalleSalidaLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<DetalleSalidaModel> listaresultado = new List<DetalleSalidaModel>();
            listaresultado = detallesalogica.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            DetalleSalidaModel resultado = new DetalleSalidaModel();
            resultado = detallesalogica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(DetalleSalidaModel request)
        {
            DetalleSalidaModel response = detallesalogica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(DetalleSalidaModel Request)
        {
            DetalleSalidaModel resultado = detallesalogica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = detallesalogica.deleteRegistro(id);
            return Ok(borrar);
        }
    }
}
