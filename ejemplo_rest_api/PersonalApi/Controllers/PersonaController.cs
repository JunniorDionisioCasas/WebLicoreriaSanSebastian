using Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;
using Utilitarios;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    [AllowAnonymous]
    public class PersonaController : ControllerBase
    {
        /*ctrl + r + r */
        PersonaLogica personaLogica = new PersonaLogica();

        [HttpGet]
        public IActionResult get()
        {
            List<PersonaModel> listaResultado = new List<PersonaModel>();
            listaResultado = personaLogica.ListarTodo();
            return Ok(listaResultado);
        }

        [HttpGet]
        [Route("detallado")]
        public IActionResult getDetallado()
        {
            List<PersonaModel> listaResultado = new List<PersonaModel>();
            listaResultado = personaLogica.ListarTodoDetallado();
            return Ok(listaResultado);
        }

        [HttpGet("{id}")]
        public IActionResult getId(int id)
        {
            PersonaModel res = new PersonaModel();
            res = personaLogica.ObtenerPorId(id);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult post(PersonaModel request)
        {
            PersonaModel response = personaLogica.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult put(PersonaModel request)
        {
            PersonaModel response = personaLogica.ActualizarRegistro(request);
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int response = personaLogica.deleteRegistro(id);
            return Ok(response);
        }
    }
}
