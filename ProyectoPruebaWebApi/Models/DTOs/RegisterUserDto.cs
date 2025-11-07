using System.ComponentModel.DataAnnotations;

namespace ProyectoPruebaWebApi.Models.DTOs
{
    public class RegisterUserDto
    {
        // Este DTO solo es para registrar un nuevo usuario
        // No necesita el Id porque es generado por la base de datos
        // RECOMIENDA PARA CADA METODO CREAR UN DTO ESPECIFICO
        [Required, MaxLength(100)]
        public string UserName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }

    

}
