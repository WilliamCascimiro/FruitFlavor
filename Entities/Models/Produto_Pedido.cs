using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Models
{
    public class Produto_Pedido
    {
        [Key]
        public Pedido pedido { get; set; }
        [ForeignKey("PedidoId")]
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoFinal { get; set; }                     
    }
}

