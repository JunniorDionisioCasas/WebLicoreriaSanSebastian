using Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoriaController : ControllerBase
    {
        CategoriaLogica categorialogica = new CategoriaLogica();

        [HttpGet]
        public IActionResult Get()
        {
            List<CategoriaModel> listaresultado = new List<CategoriaModel>();
            listaresultado = categorialogica.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            CategoriaModel resultado = new CategoriaModel();
            resultado = categorialogica.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(CategoriaModel request)
        {
            CategoriaModel response = categorialogica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(CategoriaModel Request)
        {
            CategoriaModel resultado = categorialogica.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = categorialogica.deleteRegistro(id);
            return Ok(borrar);
        }
    }
}
