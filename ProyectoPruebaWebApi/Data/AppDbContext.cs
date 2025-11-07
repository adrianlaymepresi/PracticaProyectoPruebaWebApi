using ProyectoPruebaWebApi.Models;
using Microsoft.EntityFrameworkCore;    

namespace ProyectoPruebaWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
