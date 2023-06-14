using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required int Preco { get; set; }
        public required string Sabor { get; set; }       
        public required int? Quantidade { get; set; }
        public int QuantidadeEmEstoque { get; set; }
    }
}
