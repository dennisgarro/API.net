using Dominio.Interfaces;
using Dominio.Modelos;
using InfraEstructura.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InfraEstructura.Servicios
{
    public class Servicios(ConnectionContext context) : IServicios
    {
        public async Task<List<Empleados>> GetEmpleadosList()
        {
            List<Empleados> result = await context.Empleados
                .FromSqlRaw("execute Pa_empleados")
                .ToListAsync();

            if (result == null)
            {
                throw new InvalidOperationException("no hay datos de empleados");
            }
            return result;

        }

        public async Task<Login> GetLogin(string correo)
        {
            var logins = await context.Logins
                .FromSqlInterpolated($"EXECUTE PA_Login {correo}")
                .ToListAsync(); // Convierte los resultados a una lista de forma asíncrona

            var login = logins.FirstOrDefault(); // Aplica FirstOrDefault de forma síncrona en la lista

            if (login == null)
            {
                throw new InvalidOperationException("No se encontró ningún login con las credenciales proporcionadas.");
            }

            return login;
        }



    }
}
