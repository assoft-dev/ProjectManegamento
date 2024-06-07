using ProjectManegamento.Controllers.Interfaces;
using ProjectManegamento.Models;
using ProjectManegamento.Models.Enumeradores;
using System;
using System.Collections.Generic;

namespace ProjectManegamento.Controllers.Repositorios
{
    public class UsuariosRepository : IUsuarios
    {
        public UsuariosRepository()
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

        public Dictionary<UsuariosRetorno, ProjectModels> Login(string Email, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
