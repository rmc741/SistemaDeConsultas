using Microsoft.EntityFrameworkCore;
using SistemaConsulta.Entity;

namespace SistemaConsulta.Data
{
    public class SistemaConsultaContext : DbContext
    {
        public SistemaConsultaContext(DbContextOptions<SistemaConsultaContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
