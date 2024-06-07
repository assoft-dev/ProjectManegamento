using ProjectManegamento.Controllers.Interfaces;
using ProjectManegamento.Models;
using System;
using System.Collections.Generic;

namespace ProjectManegamento.Controllers.Repositorios
{
    public class ClientesRepository : IClientes
    {
        public ClientesRepository()
        {
            
        }
        public List<ProjectModels> Buscar()
        {
            throw new NotImplementedException();
        }

        public ProjectModels Buscar(Func<ProjectModels, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ProjectModels entity)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(ProjectModels entity)
        {
            throw new NotImplementedException();
        }
    }
}
