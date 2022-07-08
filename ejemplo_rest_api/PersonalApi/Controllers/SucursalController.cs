using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalController : ControllerBase
    {
        SucursalLogica sucurlogico = new SucursalLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<SucursalModel> listaresultado = new List<SucursalModel>();
            listaresultado = sucurlogico.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            SucursalModel resultado = new SucursalModel();
            resultado = sucurlogico.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(SucursalModel request)
        {
            SucursalModel response = sucurlogico.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(SucursalModel Request)
        {
            SucursalModel resultado = sucurlogico.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = sucurlogico.deleteRegistro(id);
            return Ok(borrar);
        }
    }
}
