using Entities.Enums;

namespace Entities.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required decimal Preco { get; set; }
        public Sabor Sabor { get; set; }
        public required int? Quantidade { get; set; }
        public int QuantidadeEmEstoque { get; set; }
    }
}
