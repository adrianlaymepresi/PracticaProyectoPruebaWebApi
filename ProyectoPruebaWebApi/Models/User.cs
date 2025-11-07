using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoPruebaWebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required, MaxLength(100)]
        public string UserName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
        /*
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName 
        { 
            get { return $"{Name} {LastName}"; }
        }
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public int edad { get; set; }
        */
    }
}
