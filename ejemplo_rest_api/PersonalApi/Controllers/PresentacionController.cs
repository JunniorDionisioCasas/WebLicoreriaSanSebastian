using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresentacionController : ControllerBase
    {
        PresentacionLogica presentacionlogica = new PresentacionLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<PresentacionModel> listaresultado = new List<PresentacionModel>();
            listaresultado = presentacionlogica.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            PresentacionModel resultado = new PresentacionModel();
            resultado = presentacionlogica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(PresentacionModel request)
        {
            PresentacionModel response = presentacionlogica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(PresentacionModel Request)
        {
            PresentacionModel resultado = presentacionlogica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = presentacionlogica.deleteRegistro(id);
            return Ok(borrar);
        }
    }
}
