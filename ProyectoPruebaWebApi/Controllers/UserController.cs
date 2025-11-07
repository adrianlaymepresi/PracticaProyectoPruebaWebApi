using Microsoft.AspNetCore.Mvc;
using ProyectoPruebaWebApi.Models;
using ProyectoPruebaWebApi.Models.DTOs;
using ProyectoPruebaWebApi.Services;

namespace ProyectoPruebaWebApi.Controllers
{
    // Para decir que es un controlador de API
    [ApiController]
    [Route("api/[controller]")]
    // Hacemos que herede de ControllerBase (Hay modelo, hay controllador
    // y no tenemos que mandarle a una vista(Interfaz Web))
    public class UserController : ControllerBase 
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        // GET api/user/obtener
        [HttpGet("obtener")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var user = await _userService.GetAllUserAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // POST api/user/register
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserDto registerUserDto)
        {
            try
            {
                var user = await _userService.RegisterUserAsync(registerUserDto);
                return Ok(new {message = "Usuario Creado", user.Id, user.UserName});
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // PUT api/user/update
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateUserDto updateUserDto)
        {
            try
            {
                var user = await _userService.UpdateUserAsync(updateUserDto);
                return Ok(new { message = "Usuario actualizado", user });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // PUT api/user/updateEmail
        [HttpPut("updateEmail")]
        public async Task<IActionResult> UpdateEmail(UpdateEmailUserDto updateEmailUserDto)
        {
            try
            {
                var user = await _userService.UpdateEmailAsync(updateEmailUserDto);
                return Ok(new { message = "Usuario actualizado", user });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }


    }
}
