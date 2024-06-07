using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManegamento.Models
{
    public class Usuarios: ModelsBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool IsActived { get; set; }


        public List<ProjectModels> ProjectModels { get; set; }
    }
}
