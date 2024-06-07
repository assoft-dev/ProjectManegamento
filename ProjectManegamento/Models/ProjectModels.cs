using ProjectManegamento.Models.Enumeradores;
using System;

namespace ProjectManegamento.Models
{
    public class ProjectModels: ModelsBase
    {
        public Usuarios Usuarios { get; set; }
        public Clientes  Clientes { get; set; }

        public DateTime DatainIciado { get; set; }
        public DateTime DataEntrega { get; set; }
        public int Progresso { get; set; }
        public decimal Valor { get; set; }

        public ProjectoEstados projectoEstados { get; set; }
    }
}
