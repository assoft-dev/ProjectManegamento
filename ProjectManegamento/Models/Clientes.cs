using ProjectManegamento.Models.Enumeradores;

namespace ProjectManegamento.Models
{
    public class Clientes: ModelsBase
    {
        public TipoClientes Typo { get; set; }
        public string Nome { get; set; }
        public string localizacao { get; set; }
    }
}
