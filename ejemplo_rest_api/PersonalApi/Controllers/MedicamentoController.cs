using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentoController : ControllerBase
    {
        MedicamentoLogica medicamentologica = new MedicamentoLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<MedicamentoModel> listaresultado = new List<MedicamentoModel>();
            listaresultado = medicamentologica.ListarTodoDetallado();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            MedicamentoModel resultado = new MedicamentoModel();
            resultado = medicamentologica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(MedicamentoModel request)
        {
            MedicamentoModel response = medicamentologica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(MedicamentoModel Request)
        {
            MedicamentoModel resultado = medicamentologica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = medicamentologica.deleteRegistro(id);
            return Ok(borrar);
        }
    }
}
