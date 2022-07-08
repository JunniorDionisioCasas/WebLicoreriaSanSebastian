using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratorioController : ControllerBase
    {
        LaboratorioLogica laboratoriologica = new LaboratorioLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<LaboratorioModel> listaresultado = new List<LaboratorioModel>();
            listaresultado = laboratoriologica.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            LaboratorioModel resultado = new LaboratorioModel();
            resultado = laboratoriologica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(LaboratorioModel request)
        {
            LaboratorioModel response = laboratoriologica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(LaboratorioModel Request)
        {
            LaboratorioModel resultado = laboratoriologica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = laboratoriologica.deleteRegistro(id);
            return Ok(borrar);
        }
    }
}
