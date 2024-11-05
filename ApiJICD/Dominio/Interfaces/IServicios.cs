﻿using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IServicios
    {
        Task<Login> GetLogin(string correo);
        Task<List<Empleados>> GetEmpleadosList();
    }
}
