using Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Modelos;
using Modelos.NoDatabase;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Utilitarios;
using Microsoft.Extensions.Configuration;


namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    [Authorize]
    public class AuthController : ControllerBase
    {
        UsuarioLogica userLogica = new UsuarioLogica();

        /// <summary>
        /// indica que el servicio esta activo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult get()
        {
            return Ok("servicio en escucha");
        }

        /// <summary>
        /// realiza el proceso de login
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult post([FromBody] LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            UsuarioModel user = userLogica.ObtenerUsuarioPorUserrName(request.username);

            if (
                //UtilSecurity.encriptar_AES()
                !( // "!" significa negación
                user.username == request.username
                && user.password == request.password)
                )
            {
                return BadRequest("Usuario y/o password incorrecto");
            }

            user.password = "";
            string token = generateToken(user, 200);
            response.token = token;
            response.usuario = user;

            return Ok(response);
        }

        private string generateToken(UsuarioModel user, int expireInMinutes)
        {
            //create claims details based on the user information
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();
            // Leemos el archivo de configuración.
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, configurationFile["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", user.id.ToString()),
                        new Claim("UserName", user.username),

                    };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configurationFile["Jwt:Issuer"],
                configurationFile["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(expireInMinutes),
                signingCredentials: signIn);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        [HttpPost("Nuevo_Usuario")]
        public IActionResult RegistrarUsuario([FromBody] UsuarioRegistroRequest request)
        {
            userLogica.registrarnuevousuario(request);
            return Ok(true);
        }

    }
}
