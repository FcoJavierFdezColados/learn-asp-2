using Microsoft.EntityFrameworkCore;
using UsersCrud.Models;

namespace UsersCrud.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Contacto> Contatos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        } 
    }
}
