using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoPruebaWebApi.Models
{
    public class Rol
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string NombreRol { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Descripcion { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public bool isDeleted { get; set; } = false;

        public List<User> Users { get; set; } = new List<User>();
    }
}
