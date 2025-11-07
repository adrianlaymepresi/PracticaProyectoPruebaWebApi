using ProyectoPruebaWebApi.Data;    
using ProyectoPruebaWebApi.Models;
using ProyectoPruebaWebApi.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace ProyectoPruebaWebApi.Services
{
    // Este es un patron de diseño llamado "Inyeccion de Dependencias"
    public class UserService
    {
        private readonly AppDbContext _context; // Referencia al contexto de la base de datos
        public UserService(AppDbContext appDbContext) // Constructor que recibe el contexto
        { 
            _context = appDbContext;
        }
        public async Task<List<User>> GetAllUserAsync()
        {
            var user = _context.Users.ToListAsync();
            return await user;
        }

        public async Task<User> RegisterUserAsync(RegisterUserDto registerUserDto)
        {
            if(await _context.Users.AnyAsync(u => u.Email == registerUserDto.Email))
            {
                throw new NotImplementedException("Email ya registrado");
            }

            var user = new User
            {
                UserName = registerUserDto.UserName,
                Email = registerUserDto.Email,
                Password = HashPassword(registerUserDto.Password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        

        // METODOS AYUDA
        private string HashPassword(string password)
        {
            var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
