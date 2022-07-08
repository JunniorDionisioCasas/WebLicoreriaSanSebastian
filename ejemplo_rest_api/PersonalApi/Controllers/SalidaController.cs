using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalidaController : ControllerBase
    {
        SalidaLogica salilogico = new SalidaLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<SalidaModel> listaresultado = new List<SalidaModel>();
            listaresultado = salilogico.ListarTodo();
            return Ok(listaresultado);

        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            SalidaModel resultado = new SalidaModel();
            resultado = salilogico.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(SalidaModel request)
        {
            SalidaModel response = salilogico.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(SalidaModel Request)
        {
            SalidaModel resultado = salilogico.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = salilogico.deleteRegistro(id);
            return Ok(borrar);
        }
    }
}
