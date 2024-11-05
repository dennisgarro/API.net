
using Dominio.Interfaces;
using InfraEstructura.Context;
using InfraEstructura.Servicios;
using Microsoft.EntityFrameworkCore;

namespace ApiJICD.ConexionBd
{
    public static class ConeccionBD
    {
        public static IServiceCollection AdicionarServicios(this IServiceCollection servicio, IConfiguration configuration)
        {
            servicio.AddDbContext<ConnectionContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("ConexionPoli"));
            });
            servicio.AddScoped<IServicios,Servicios>();
            return servicio;
        }
    }
}
