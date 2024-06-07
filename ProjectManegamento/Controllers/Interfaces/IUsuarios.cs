using ProjectManegamento.Models;
using ProjectManegamento.Models.Enumeradores;
using System.Collections.Generic;

namespace ProjectManegamento.Controllers.Interfaces
{
    public interface IUsuarios : IGeneric<ProjectModels>
    {
        Dictionary<UsuariosRetorno, ProjectModels> Login(string Email, string Password);
    }
}
