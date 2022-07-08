using Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;
using Modelos.NoDatabase;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        EntradaLogica entradalogica = new EntradaLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<EntradaModel> listaresultado = new List<EntradaModel>();
            listaresultado = entradalogica.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            EntradaModel resultado = new EntradaModel();
            resultado = entradalogica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(EntradaModel request)
        {
            EntradaModel response = entradalogica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(EntradaModel Request)
        {
            EntradaModel resultado = entradalogica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = entradalogica.deleteRegistro(id);
            return Ok(borrar);
        }
        [HttpPost("Nueva_Entrada")]
        public IActionResult RegistrarEntrada([FromBody] EntradaRequest request)
        {
            entradalogica.registrarEntrada(request);
            return Ok(true);
        }
    }
}
