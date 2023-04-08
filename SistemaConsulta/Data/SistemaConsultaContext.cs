using Microsoft.EntityFrameworkCore;
using SistemaConsulta.Entity;

namespace SistemaConsulta.Data
{
    public class SistemaConsultaContext : DbContext
    {
        public SistemaConsultaContext (DbContextOptions<SistemaConsultaContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; } = default!;

        public DbSet<SistemaConsulta.Entity.Consulta>? Consulta { get; set; }
    }
}
