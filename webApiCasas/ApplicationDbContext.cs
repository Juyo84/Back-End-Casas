using Microsoft.EntityFrameworkCore;
using webApiCasas.Entidades;

namespace webApiCasas
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        
            

        }

        public DbSet<Casa> Casas { get; set; }

    }
}
