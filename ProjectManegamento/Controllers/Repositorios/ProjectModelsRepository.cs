using ProjectManegamento.Controllers.Interfaces;
using ProjectManegamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManegamento.Controllers.Repositorios
{
    public class ProjectModelsRepository : IProjectModels
    {
        public ProjectModelsRepository()
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
