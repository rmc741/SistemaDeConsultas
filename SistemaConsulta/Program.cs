using Microsoft.EntityFrameworkCore;
using SistemaConsulta.Data;
using SistemaConsulta.Repository;
using SistemaConsulta.Repository.Interface;

namespace SistemaConsulta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<SistemaConsultaContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SistemaConsultaContext")
                ?? throw new InvalidOperationException("Connection string 'SistemaConsultaContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}